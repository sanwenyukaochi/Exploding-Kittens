@backend @api @game-engine
Feature: 爆炸猫游戏引擎
  作为 游戏服务器
  我想要 正确执行游戏规则和状态管理
  以便 保证游戏的公平性和数据一致性

  Background: 游戏引擎初始化
    Given 游戏引擎支持 2 到 5 名玩家
    And 牌堆服务已初始化并包含完整卡牌
    And 玩家服务已注册所有玩家
    And 游戏状态存储已准备就绪

  Rule: 游戏状态机规则
  - 游戏状态流转：SETUP → PLAYING → TURN_END → GAME_OVER
  - 只有处于 PLAYING 状态才能执行出牌操作
  - 只有当前回合玩家才能出牌
  - 抽牌后必须验证是否抽到爆炸猫

    Rule: 数据一致性规则
    - 所有状态变更必须在同一事务中完成
    - 并发操作必须使用乐观锁
    - 领域事件必须在事务提交后发布

    @happy-path @api-contract
    Scenario: 后端正确响应获取游戏状态请求
      Given 游戏 "game-123" 已创建
      And 游戏包含 4 名玩家
      When 客户端请求 GET /api/games/game-123
      Then 返回 HTTP 状态码 200
      And 响应体应包含字段:
        | 字段名           | 期望值                          |
        | gameId           | "game-123"                      |
        | players.length   | 4                               |
        | currentPlayerId  | <当前回合玩家ID>                 |
        | deckSize         | <剩余牌堆数量>                   |
        | phase            | "PLAYING" 或 "TURN_END"        |
      And 响应时间应小于 200ms
      But 如果游戏不存在
      Then 返回 HTTP 状态码 404
      And 响应体包含错误消息 "游戏未找到"

    @happy-path @skip-logic
    Scenario: 跳过牌业务逻辑正确执行
      Given 游戏 "game-123" 处于 PLAYING 状态
      And 当前回合玩家是 playerA
      And playerA 的手牌包含 card-001（类型 SKIP）
      When 客户端请求 POST /api/games/game-123/play
      And 请求体包含:
      """
      {
        "playerId": "playerA",
        "cardId": "card-001"
      }
      """
      Then 后端执行以下操作:
        | 操作                      | 验证点                        |
        | 验证玩家是否为当前回合玩家 | playerA 必须是当前回合玩家     |
        | 验证卡牌是否在手牌中      | card-001 必须在 playerA 手牌  |
        | 从手牌移除 card-001       | playerA 手牌不包含 card-001   |
        | 将 card-001 加入弃牌堆    | 弃牌堆包含 card-001           |
        | 当前回合切换到 playerB    | currentPlayerId = playerB    |
        | 阶段切换为 TURN_END       | phase = TURN_END             |
      And 返回 HTTP 状态码 200
      And 响应体包含:
        | 字段                  | 期望值                      |
        | success               | true                        |
        | message               | "跳过成功"                  |
        | newState.currentPlayer | "playerB"                  |
        | newState.phase        | "TURN_END"                 |
      And 发布领域事件 CardPlayedEvent
      And 事件包含:
        | 字段         | 期望值      |
        | gameId       | "game-123"  |
        | playerId     | "playerA"   |
        | cardType     | "SKIP"      |

    @happy-path @attack-logic
    Scenario: 攻击牌正确累加额外回合
      Given 游戏 "game-123" 处于 PLAYING 状态
      And 当前回合玩家是 playerA
      And playerA 手牌包含 card-002（类型 ATTACK）
      And playerB（下家）当前额外回合数为 0
      When playerA 打出 ATTACK 牌
      Then playerB 的额外回合数变为 2
      And 当前回合切换到 playerB
      And 返回响应包含:
        | 字段                            | 期望值      |
        | newState.nextPlayer.extraTurns  | 2           |
      And 如果 playerB 也打出 ATTACK 牌
      Then playerC 的额外回合数变为 3（2 + 1）
      And 当前回合切换到 playerC

    @happy-path @draw-logic
    Scenario: 抽牌逻辑正确返回普通牌
      Given 游戏 "game-123" 处于 PLAYING 阶段
      And 当前回合玩家是 playerA
      And 牌堆顶部第 1 张牌是 card-003（类型 SKIP）
      When 客户端请求 POST /api/games/game-123/draw
      And 请求体包含:
      """
      {
        "playerId": "playerA"
      }
      """
      Then 后端执行以下操作:
        | 操作                         | 验证点                         |
        | 从牌堆顶部抽取 1 张牌         | 抽出的牌是 card-003            |
        | 将 card-003 加入 playerA 手牌 | playerA 手牌包含 card-003     |
        | 当前回合切换到 playerB        | currentPlayerId = playerB     |
        | 阶段切换为 TURN_END          | phase = TURN_END              |
      And 返回 HTTP 状态码 200
      And 响应体包含:
        | 字段           | 期望值                       |
        | success        | true                         |
        | cardType       | "SKIP"                       |
        | cardName       | "跳过"                       |
        | newState.phase | "TURN_END"                   |
      And 不触发任何领域事件

    @edge-case @exploding-with-defuse
    Scenario: 抽到爆炸猫且有拆弹牌时正确化解
      Given 游戏 "game-123" 处于 PLAYING 阶段
      And 当前回合玩家是 playerA
      And 牌堆顶部第 1 张牌是 card-004（类型 EXPLODING）
      And playerA 手牌包含 card-005（类型 DEFUSE）
      When playerA 请求抽牌
      Then 后端执行以下操作:
        | 操作                         | 验证点                              |
        | 检测到抽到爆炸猫              | drawnCard.type = EXPLODING          |
        | 检测 playerA 是否有拆弹牌     | playerA 手牌包含 DEFUSE              |
        | 从 playerA 手牌移除 DEFUSE    | playerA 手牌不包含 DEFUSE            |
        | 将 DEFUSE 加入弃牌堆         | 弃牌堆包含 DEFUSE                    |
        | 将 EXPLODING 放回牌堆        | 牌堆包含 1 张 EXPLODING              |
        | 放回位置可配置               | 支持 TOP/BOTTOM/RANDOM/SPECIFIC     |
        | 当前回合切换到 playerB        | currentPlayerId = playerB           |
        | 阶段切换为 TURN_END          | phase = TURN_END                    |
      And 返回响应包含:
        | 字段                     | 期望值         |
        | cardType                 | "EXPLODING"    |
        | hasDefuse                | true           |
        | defuseCardId             | "card-005"     |
        | eliminated               | false          |
        | message                  | "拆弹成功！"    |
      And 发布领域事件 ExplodingCatDrawnEvent
      And 事件包含:
        | 字段           | 期望值          |
        | defused        | true            |
        | defuseCardId   | "card-005"      |

    @negative @exploding-without-defuse
    Scenario: 抽到爆炸猫且无拆弹牌时正确淘汰
      Given 游戏 "game-123" 包含 4 名玩家
      And 当前回合玩家是 playerA
      And 牌堆顶部是 EXPLODING 牌
      And playerA 手牌不包含 DEFUSE 牌
      When playerA 请求抽牌
      Then 后端执行以下操作:
        | 操作                         | 验证点                              |
        | 检测到抽到爆炸猫              | drawnCard.type = EXPLODING          |
        | 检测 playerA 无拆弹牌         | playerA 手牌不包含 DEFUSE            |
        | 标记 playerA 为已淘汰         | playerA.alive = false               |
        | 从游戏中移除 playerA          | players 列表长度减 1                 |
        | 将 EXPLODING 加入弃牌堆      | 弃牌堆包含 EXPLODING                 |
        | 当前回合切换到 playerB        | currentPlayerId = playerB           |
        | 阶段切换为 TURN_END          | phase = TURN_END                    |
      And 返回响应包含:
        | 字段         | 期望值         |
        | cardType     | "EXPLODING"    |
        | hasDefuse    | false          |
        | eliminated   | true           |
        | eliminatedPlayerId | "playerA"  |
        | message      | "💀 playerA 被淘汰！" |
      And 发布领域事件 PlayerEliminatedEvent
      And 事件包含:
        | 字段           | 期望值          |
        | playerId       | "playerA"       |
        | eliminatedBy   | "EXPLODING"     |

    @edge-case @game-over
    Scenario: 只剩一名玩家时触发游戏结束
      Given 游戏 "game-123" 原本有 4 名玩家
      And 已有 3 名玩家被淘汰
      And 场上只剩 playerD 存活
      When 第 3 名玩家被淘汰（触发淘汰逻辑）
      Then 检测到存活玩家数量为 1
      And 游戏阶段切换为 GAME_OVER
      And 记录胜利者 playerD
      And 返回响应包含:
        | 字段         | 期望值         |
        | phase        | "GAME_OVER"    |
        | winnerId     | "playerD"      |
        | message      | "🏆 playerD 获胜！" |
      And 发布领域事件 GameOverEvent
      And 禁止后续所有出牌/抽牌操作

    @edge-case @concurrency
    Scenario: 并发操作时使用乐观锁防止重复操作
      Given 游戏 "game-123" 当前状态版本号为 5
      When 两个并发请求同时尝试打出同一张牌
      Then 第一个请求成功执行（版本号 5 → 6）
      And 第二个请求检测到版本号冲突（当前已是 6）
      And 第二个请求返回 HTTP 409 冲突
      And 响应体包含错误消息 "游戏状态已变更，请刷新重试"

    @scenario-outline @card-validation
    Scenario Template: 出牌操作的参数校验
      Given 游戏 "game-123" 处于 PLAYING 阶段
      When 客户端请求 POST /api/games/game-123/play
      And 请求体包含 "<异常场景>"
      Then 返回 HTTP 状态码 "<状态码>"
      And 响应体包含错误消息包含 "<错误信息>"

      Examples: 参数校验场景
        | 异常场景                        | 状态码 | 错误信息                   |
        | playerId 为空                   | 400    | "玩家ID不能为空"            |
        | cardId 为空                     | 400    | "卡牌ID不能为空"            |
        | playerId 不存在                 | 404    | "玩家不存在"                |
        | cardId 不存在                   | 404    | "卡牌不存在"                |
        | playerId 不是当前回合玩家       | 403    | "不是你的回合"              |
        | 卡牌不在玩家手牌中              | 400    | "该卡牌不在手牌中"          |
        | 游戏阶段不是 PLAYING            | 400    | "当前阶段不能出牌"          |

    @scenario-outline @rule-enforcement
    Scenario Template: 不同卡牌类型的规则验证
      Given 游戏 "game-123" 处于 PLAYING 阶段
      And 当前回合玩家是 playerA
      And playerA 手牌包含 "<卡牌类型>" 牌
      When playerA 打出 "<卡牌类型>" 牌
      Then 后端应验证以下规则 "<验证规则>"

      Examples: 卡牌规则映射
        | 卡牌类型     | 验证规则                                                   |
        | 跳过         | 回合结束，不抽牌，下家无额外回合                            |
        | 攻击         | 回合结束，下家额外回合数 +2                                 |
        | 预见未来     | 回合继续，牌堆顶3张被查看但不改变顺序                       |
        | 洗牌         | 回合继续，牌堆顺序被随机打乱                                |
        | 人情         | 回合继续，指定玩家必须选择一张牌交出                        |