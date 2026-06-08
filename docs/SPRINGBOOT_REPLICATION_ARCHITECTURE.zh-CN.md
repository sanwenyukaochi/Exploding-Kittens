# Spring Boot 复刻 Exploding Kittens 方案

## 结论

可以用 Spring Boot 复刻，但推荐把它定位成：

- 服务端权威规则引擎
- 房间与回合同步服务
- 对局存档与战绩服务
- AI 服务宿主

不推荐把它当成：

- Unity 式高表现客户端
- 动画和拖拽交互层

最合理的形态是：

- 后端：Spring Boot
- 前端：独立 Web / 桌面 / 移动客户端
- 核心规则：纯 Java 领域模块

## 推荐版本

基于官方文档，截至 `2026-06-09`：

- Spring Boot 稳定版包含 `4.0.6`
- 同时还有稳定的 `3.5.14`

我的建议：

- 如果你要稳妥、生态兼容更轻松：`Java 21 + Spring Boot 3.5.14`
- 如果你是全新项目并愿意跟新主线：`Java 21 + Spring Boot 4.0.6`

统一建议仍然是：

- `Java 21`
- `Maven`

## 最推荐的技术栈

### 后端主栈

- `Java 21`
- `Spring Boot 3.5.14` 或 `4.0.6`
- `Spring MVC`
- `Spring WebSocket`
- `Spring Security`
- `Spring Data JPA`
- `PostgreSQL`
- `Redis`
- `Flyway`
- `Jackson`
- `JUnit 5`
- `Testcontainers`

### 为什么不优先推荐 WebFlux

爆炸猫是回合制卡牌游戏，不是高频帧同步游戏。

它的核心压力来自：

- 房间状态一致性
- 回合和出牌合法性校验
- 重连恢复
- 定时器

而不是超高吞吐流式 IO。

所以第一版最推荐：

- `Spring MVC + WebSocket`

而不是：

- `Spring WebFlux`

除非你后面明确要做：

- 超大规模同时在线房间
- 极高连接数
- 统一响应式链路

否则没必要先把复杂度拉高。

## 总体架构

推荐拆成 5 个模块。

### 1. `ek-domain`

纯规则核心，不依赖 Spring。

职责：

- 卡牌定义
- 牌堆操作
- 玩家状态
- 游戏状态
- 回合推进
- 出牌结算
- 胜负判定

这是最重要的模块，未来如果你换成：

- CLI
- Android
- Web
- 桌面客户端

都不需要重写规则。

### 2. `ek-application`

应用服务层。

职责：

- 创建房间
- 开始游戏
- 玩家出牌
- 抽牌
- 拆弹
- 选目标
- 结束回合
- AI 回合执行
- 生成对局事件

它负责“调领域模型做事”，但不直接关心 HTTP 或 WebSocket。

### 3. `ek-infra`

基础设施层。

职责：

- JPA 持久化
- Redis 房间态缓存
- 定时任务
- WebSocket Session 管理
- 序列化
- 用户认证

### 4. `ek-api`

接口层。

职责：

- REST API
- WebSocket 入口
- DTO 转换
- 鉴权入口

### 5. `ek-client`

独立前端。

如果你做 Web 版，推荐：

- `Vue 3 + TypeScript + Vite`

原因：

- 状态管理简单
- WebSocket 集成直观
- UI 上手快

如果你本来更熟 React，也可以直接用 React，不影响后端设计。

## Maven 模块建议

```text
exploding-kittens/
  pom.xml
  ek-domain/
  ek-application/
  ek-infra/
  ek-api/
  ek-client/
```

如果你只想先做后端，也可以先这样：

```text
exploding-kittens/
  pom.xml
  ek-domain/
  ek-server/
```

其中：

- `ek-domain`：纯 Java
- `ek-server`：包含 application + infra + api

这是最适合 MVP 的拆法。

## 后端包结构建议

```text
com.example.ek
  common
  config
  domain
    card
    deck
    player
    game
    turn
    rule
    event
    ai
  application
    room
    match
    command
    query
    service
  infrastructure
    persistence
    redis
    websocket
    security
    scheduler
  api
    rest
    ws
    dto
```

## 领域模型设计

### 核心实体

建议优先定义这些类。

#### `CardDefinition`

对应静态卡牌定义。

字段建议：

- `id`
- `category`
- `textureFilename`
- `jukeboxId`
- `soundCaption`
- `deckType`
- `copiesFor2Players`
- `copiesFor3Players`
- `copiesFor4Players`
- `copiesFor5Players`

这部分基本可以直接来自：

- `Assets/TextAsset/Cards.*.csv`

#### `CardInstance`

对应一张运行中的具体牌。

字段建议：

- `instanceId`
- `definitionId`
- `category`
- `marked`
- `diarrhea`
- `disguised`
- `placingPlayerId`

这部分主要参考：

- `Card.cs`

#### `DeckState`

字段建议：

- `drawPile`
- `discardPile`
- `towerOfPowerPile`

方法建议：

- `drawTop()`
- `drawBottom()`
- `peekTop(n)`
- `shuffle()`
- `insertAt(index, card)`
- `moveToTop(cards)`
- `remove(card)`

这部分主要参考：

- `Deck.cs`
- `GameDeck.cs`

#### `PlayerState`

字段建议：

- `playerId`
- `username`
- `ai`
- `dead`
- `connected`
- `phase`
- `hand`
- `defuseCount`
- `nextCardIsRandom`
- `playedCatButted`
- `playedStreaking`
- `gaveStreaking`
- `barkingKittenFlag`
- `towerOfPowerFlag`
- `defusingTakeThatBomb`
- `choosingOpponent`
- `choosingStealCard`
- `choosingGarbageCard`
- `choosingPotLuckCard`

这部分主要参考：

- `Player.cs`
- `PlayerPhase.cs`

#### `TurnState`

字段建议：

- `currentPlayerId`
- `remainingTurns`
- `direction`
- `waitingAction`
- `deadlineAt`

这里建议你显式补一个方向枚举：

- `CLOCKWISE`
- `COUNTER_CLOCKWISE`

因为 `Reverse` 会影响它。

#### `GameState`

字段建议：

- `gameId`
- `deckType`
- `status`
- `seed`
- `players`
- `deckState`
- `turnState`
- `winnerPlayerId`
- `activityLog`
- `version`

其中 `version` 很重要，用于并发控制。

## 规则引擎设计

推荐你不要写成“大 if-else 文件”，而要写成卡牌效果分发器。

### 核心接口

```java
public interface CardEffectResolver {
    CardCategory supports();
    RuleResult resolve(PlayCardCommand command, GameState gameState);
}
```

### 规则入口

```java
public interface RuleEngine {
    RuleResult playCard(PlayCardCommand command, GameState gameState);
    RuleResult drawCard(DrawCardCommand command, GameState gameState);
    RuleResult chooseTarget(ChooseTargetCommand command, GameState gameState);
    RuleResult placeDefusedBomb(PlaceBombCommand command, GameState gameState);
    RuleResult endTurn(EndTurnCommand command, GameState gameState);
}
```

### 推荐的 resolver 类

- `SkipResolver`
- `SuperSkipResolver`
- `ShuffleResolver`
- `FakeShuffleResolver`
- `StealResolver`
- `SlapResolver`
- `SelfSlapResolver`
- `ReverseResolver`
- `SeeTheFutureResolver`
- `AlterTheFutureResolver`
- `ShareTheFutureResolver`
- `DrawFromBottomResolver`
- `DefuseResolver`
- `BombResolver`
- `StreakingKittenResolver`
- `BarkingKittenResolver`
- `TakeThatResolver`
- `BuryResolver`
- `PotLuckResolver`
- `TowerOfPowerResolver`
- `GarbageCollectionResolver`
- `SwapTopBottomResolver`
- `MarkResolver`
- `KittenRollCallResolver`
- `CatButtResolver`
- `DiarrheaResolver`
- `CatomicBombResolver`

这些名字可以直接对齐当前 Unity 项目里的 `*Controller.cs`。

## 推荐的命令模型

### 命令对象

- `CreateRoomCommand`
- `JoinRoomCommand`
- `StartGameCommand`
- `PlayCardCommand`
- `DrawCardCommand`
- `ChooseTargetCommand`
- `ChooseCardCommand`
- `PlaceBombCommand`
- `ReorderTopCardsCommand`
- `EndTurnCommand`
- `ReconnectCommand`

### `PlayCardCommand` 建议字段

- `gameId`
- `playerId`
- `cardInstanceId`
- `targetPlayerId`
- `selectedCardInstanceId`
- `clientActionId`
- `expectedGameVersion`

`expectedGameVersion` 很关键，用来防止并发覆盖。

## REST API 设计

REST 主要负责：

- 大颗粒管理动作
- 登录鉴权
- 房间列表
- 历史战绩

### 推荐接口

- `POST /api/auth/guest`
- `POST /api/auth/login`
- `GET /api/me`
- `POST /api/rooms`
- `POST /api/rooms/{roomId}/join`
- `POST /api/rooms/{roomId}/leave`
- `GET /api/rooms/{roomId}`
- `POST /api/rooms/{roomId}/start`
- `GET /api/matches/{matchId}`
- `GET /api/matches/{matchId}/replay`
- `GET /api/me/history`

真正的出牌、抽牌、倒计时广播，建议走 WebSocket，不要全靠 REST 轮询。

## WebSocket 设计

## 推荐做法

第一版建议：

- 使用 `Spring WebSocket`
- 传输格式统一用 JSON
- 自定义消息协议

不建议第一版就先上复杂 STOMP 抽象，除非你非常确定前端只会是浏览器，并且你想快速用 topic 订阅模型。

### 连接地址

- `/ws/game`

### 客户端上行消息

统一格式建议：

```json
{
  "type": "PLAY_CARD",
  "gameId": "g_123",
  "playerId": "p_1",
  "payload": {
    "cardInstanceId": "ci_1001",
    "targetPlayerId": "p_2"
  },
  "clientActionId": "act_999",
  "expectedGameVersion": 17
}
```

### 服务端下行消息

统一格式建议：

```json
{
  "type": "GAME_EVENT",
  "gameId": "g_123",
  "serverEventId": "evt_701",
  "gameVersion": 18,
  "payload": {
    "eventType": "CARD_PLAYED",
    "playerId": "p_1",
    "cardCategory": "Skip"
  }
}
```

### 推荐消息类型

客户端到服务端：

- `PING`
- `READY`
- `PLAY_CARD`
- `DRAW_CARD`
- `CHOOSE_TARGET`
- `CHOOSE_CARD`
- `PLACE_BOMB`
- `REORDER_TOP_CARDS`
- `END_TURN`
- `EMOTE`

服务端到客户端：

- `CONNECTED`
- `ROOM_SNAPSHOT`
- `GAME_SNAPSHOT`
- `GAME_EVENT`
- `TURN_STARTED`
- `TURN_UPDATED`
- `PLAYER_PHASE_CHANGED`
- `CARD_REQUESTED`
- `ACTION_REJECTED`
- `GAME_OVER`
- `PLAYER_DISCONNECTED`
- `PLAYER_RECONNECTED`
- `TIMER_UPDATED`

### 为什么要有 snapshot

因为卡牌游戏天然需要处理：

- 掉线重连
- 前端状态丢失
- 多端不同步

所以服务端必须支持：

- 周期性或关键节点全量快照
- 基于 `gameVersion` 的增量事件

## 数据库设计

数据库不要直接存“整个房间实时状态”。

推荐分成两类：

- PostgreSQL：持久业务数据
- Redis：实时运行态

### PostgreSQL 表建议

#### `user_account`

- `id`
- `username`
- `password_hash`
- `guest`
- `avatar`
- `created_at`
- `updated_at`

#### `game_room`

- `id`
- `room_code`
- `host_user_id`
- `deck_type`
- `status`
- `max_players`
- `created_at`

#### `room_player`

- `id`
- `room_id`
- `user_id`
- `seat_no`
- `ready`
- `joined_at`

#### `match_record`

- `id`
- `room_id`
- `deck_type`
- `seed`
- `status`
- `winner_user_id`
- `started_at`
- `ended_at`

#### `match_player`

- `id`
- `match_id`
- `user_id`
- `seat_no`
- `is_ai`
- `placement`
- `eliminated`

#### `match_action_log`

- `id`
- `match_id`
- `seq_no`
- `player_id`
- `action_type`
- `payload_json`
- `created_at`

#### `match_snapshot`

- `id`
- `match_id`
- `version`
- `snapshot_json`
- `created_at`

这个表用于：

- 回放
- 断点恢复
- 排查规则 bug

### Redis key 建议

- `ek:room:{roomId}:state`
- `ek:room:{roomId}:players`
- `ek:game:{gameId}:state`
- `ek:game:{gameId}:timer`
- `ek:user:{userId}:session`

## 状态存储策略

推荐：

- 实时游戏状态主存 Redis
- 关键版本和日志异步刷 PostgreSQL

不要第一版就把每一步都完全走数据库事务驱动，否则实时交互会很重。

更合理的链路是：

1. 收到 WebSocket 命令
2. 加载 Redis 中的 `GameState`
3. 执行 `RuleEngine`
4. 写回 Redis
5. 广播事件
6. 异步落 `match_action_log`
7. 每 N 步或关键节点落 `match_snapshot`

## 并发与一致性

爆炸猫的服务端必须是权威的。

建议遵守三条规则：

### 1. 同一对局串行执行

同一个 `gameId` 的命令必须串行处理。

可以用：

- 单机：`ReentrantLock` / 单线程执行器
- 多机：Redis 分布式锁或按 `gameId` 分片路由

第一版最简单的做法：

- 单机部署
- 每局一个内存锁

### 2. 所有客户端动作都带版本号

例如：

- `expectedGameVersion`

版本不匹配就拒绝并下发最新快照。

### 3. 前端不能自行判定结果

前端只做：

- 展示
- 选择
- 发命令

最终结果始终以服务端为准。

## AI 设计

你当前项目里有：

- `ExplodingKittensAI/CardActionTypes.cs`
- `ExplodingKittensAI/CardAction.cs`
- `ExplodingKittensAI/AIGameState.cs`

建议保留这套抽象，但不要尝试复用反编译出来的方法体。

### AI 模块建议

- `AiGameState`
- `AiAction`
- `AiDecisionService`
- `HeuristicEvaluator`

### 难度设计

- `Easy`
  - 基本随机
  - 只做最明显的保命动作
- `Medium`
  - 简单风险评估
  - 会优先拆弹、跳过、洗牌
- `Hard`
  - 记牌
  - 根据已知炸弹位置和牌差做动作

第一版建议只做：

- `Easy`
- `Medium`

## 安全设计

推荐：

- 匿名游客可玩
- 注册用户可保存战绩

### 鉴权方式

- REST：JWT
- WebSocket：连接时携带 token

### 最少要做的校验

- 用户是否在该房间
- 是否轮到该玩家
- 牌是否在手里
- 当前 phase 是否允许该动作
- 目标玩家是否合法
- 命令版本是否匹配

## 测试策略

这是卡牌游戏，测试必须重。

### 单元测试

重点测：

- 各类 `Resolver`
- `DeckState`
- `TurnState`
- 胜负判定

### 集成测试

重点测：

- 创建房间
- 开始对局
- WebSocket 命令链路
- Redis 状态写回
- 断线重连

### 回归测试

建议做“脚本化对局回放”：

- 输入一组命令序列
- 检查最终 `GameState`

这对爆炸猫这种规则很多的游戏非常重要。

## MVP 开发顺序

建议分 4 期。

### Phase 1：单机规则核心

只做：

- `Core` 牌组
- 2 人对局
- 不接 WebSocket
- 不接数据库
- 纯 Java 测试跑通

目标是证明：

- 抽牌
- 出牌
- 炸弹
- 拆弹
- 回合推进

都正确。

### Phase 2：房间 + WebSocket

加入：

- 创建房间
- 加入房间
- 开始游戏
- 实时广播
- 断线重连

### Phase 3：持久化 + 战绩

加入：

- 用户系统
- 战绩
- 回放
- 关键快照

### Phase 4：扩展牌组与 AI

逐步加入：

- `Streaking`
- `Party`
- `Barking`
- `Betrayal`
- `Mixed`

## 第一版最小依赖清单

如果你现在就要建项目，建议依赖只放这些：

- `spring-boot-starter-web`
- `spring-boot-starter-websocket`
- `spring-boot-starter-security`
- `spring-boot-starter-data-jpa`
- `spring-boot-starter-validation`
- `postgresql`
- `spring-data-redis`
- `flyway-core`
- `lombok`
- `jackson-databind`
- `spring-boot-starter-test`
- `testcontainers`

## 不推荐一开始就做的事

- 不要一开始就微服务化
- 不要一开始就强上 WebFlux
- 不要一开始就把所有扩展牌组都做完
- 不要把规则逻辑写进 Controller
- 不要把房间实时状态只存在数据库
- 不要让前端本地决定规则结果

## 我对这个项目的最终推荐

如果你要我只给一个最务实的答案，那就是：

- 后端：`Java 21 + Spring Boot 3.5.14`
- Web 栈：`Spring MVC + Spring WebSocket`
- 存储：`PostgreSQL + Redis`
- 持久层：`Spring Data JPA`
- 迁移：`Flyway`
- 测试：`JUnit 5 + Testcontainers`
- 前端：`Vue 3 + TypeScript`
- 规则核心：独立 `ek-domain` 纯 Java 模块

这是我认为最平衡的方案：

- 学习成本不高
- 规则层可维护
- 实时性足够
- 后期可扩
- 最适合从你当前这份 Unity 反编译项目迁移

## 下一步怎么做

如果继续往下，最合理的下一步不是先写 Controller，而是先做这 6 件事：

1. 把 `Cards.*.csv` 转成后端可加载的静态资源
2. 定义 `CardCategory`、`DeckType`、`PlayerPhase`
3. 写 `CardDefinition`、`CardInstance`、`DeckState`、`PlayerState`、`GameState`
4. 先实现 `Core` 牌组规则
5. 用单元测试跑通 2 人局
6. 再接 WebSocket 房间逻辑

如果你同意，我下一步可以直接继续给你出：

- 一版 Maven 多模块骨架
- 一版数据库表 SQL
- 一版 WebSocket JSON 协议草案
- 一版 `ek-domain` 的核心 Java 类清单
