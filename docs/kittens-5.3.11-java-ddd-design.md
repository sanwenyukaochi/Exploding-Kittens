# Kittens_5.3.11 Project Java 微服务建模说明

## 1. 原始目录内容总结

`Kittens_5.3.11_project` 不是原始 Unity 工程，而是一个已经导出的客户端工程快照，核心内容分为三块：

| 目录 | 作用 | 对服务端建模的启发 |
| --- | --- | --- |
| `Assemblies/` | Unity、Photon、分析、支付等 DLL | 说明客户端原先依赖 Photon 做联机，同步逻辑较多放在客户端 |
| `Assets/` | 场景、音频、贴图、卡牌配置、表情包配置 | 说明游戏有明显的“静态配置域”，包括卡牌、牌组、表情、头像、资源包 |
| `Scripts/` | 反编译后的 C# 脚本 | 可以从类名和字段中提炼业务边界与状态模型 |

关键场景只有三个：

| 场景 | 含义 |
| --- | --- |
| `Launch` | 启动、版本、初始化 |
| `Home` | 玩家资料、牌组选择、匹配、房间大厅 |
| `Game` | 对局运行时 |

从 `Scripts/Assembly-CSharp` 中能稳定识别出的业务模块如下：

| 业务模块 | 关键类/资源 | 说明 |
| --- | --- | --- |
| 玩家资料 | `Player`、`PlayerAvatar`、`PlayerProfileSettings` | 玩家名称、头像、设备标识、状态 |
| 房间大厅 | `Room`、`GameLobbyController`、`PhotonRoomJoinHandler`、`LobbyAvatarGridController` | 建房、加入、准备、房间码、房主控制 |
| 匹配 | `JoinRandomInternetGameWindowController`、`PhotonRandomRoomJoinHandler` | 随机匹配与公开房间 |
| 卡牌目录 | `Card`、`CardCategory`、`CategoryMetadata`、`DeckMetadata` | 卡牌分类、说明、牌组定义 |
| 对局运行时 | `Deck`、`TurnQueue`、`PlayerHand`、`DrawCardController`、`GameStarter` | 发牌、摸牌、出牌、回合推进 |
| 规则效果 | `BarkingKittenController`、`GarbageCollectionController`、`StealController`、`PotLuckController` | 说明卡牌效果已高度业务化，不适合散落在控制器里 |
| 结算与成长 | `PlayerStats`、`AchievementsManager`、`RematchGameAction` | 对局结果、统计、成就、再来一局 |
| 社交表现 | `Emote`、`EmotePack`、`InRoomChat`、`Blacklist.bytes` | 表情、聊天、屏蔽、轻社交 |
| 商品与扩展包 | `PurchasableDeckButton`、`DeckMetadata.RequiresPurchase`、`Sku` | 牌组扩展与内购所有权 |

静态配置资源也很明确：

| 资源 | 含义 |
| --- | --- |
| `Assets/TextAsset/Cards.*.bytes` | 牌组卡牌定义 |
| `Assets/TextAsset/EmotePacks.bytes` | 表情包目录 |
| `Assets/TextAsset/Blacklist.bytes` | 敏感词/黑名单 |

结论：这个项目的服务端重写，不应该照着 Unity 控件或 Photon 消息建模，而应该围绕四类核心业务对象建模：`用户`、`房间`、`对局`、`结算成长`。

## 2. Java 重写时的总体拆分建议

### 2.1 建议的微服务数量

当前阶段建议保留 **4 个核心业务微服务**，与仓库现有模块骨架保持一致：

1. `user-service`
2. `room-service`
3. `game-service`
4. `settlement-service`

另外再补两个基础组件，但它们不算业务微服务：

1. `api-gateway`
2. `realtime-gateway` 或 `game-realtime` WebSocket 节点

### 2.2 为什么是 4 个，而不是更多

原因很直接：

- `卡牌规则` 与 `对局状态` 强一致，必须在一个服务里，不要拆成多个小服务。
- `房间大厅` 和 `对局运行时` 生命周期不同，应该分开。
- `用户资料/背包` 与 `结算/积分/成就` 更新频率不同，应该分开。
- `牌组目录` 虽然是配置域，但和出牌规则强相关，初期不要单独拆 `catalog-service`。

### 2.3 服务职责边界

| 服务 | 负责什么 | 不负责什么 |
| --- | --- | --- |
| `user-service` | 账号、玩家资料、头像、表情包、拥有的扩展包、屏蔽偏好 | 不负责房间、不负责回合 |
| `room-service` | 建房、匹配、准备、座位、房间码、房主操作、开局前规则选择 | 不负责真正的发牌和出牌 |
| `game-service` | 对局创建、洗牌、发牌、摸牌、出牌、卡牌效果、回合推进、重连快照 | 不负责账号资料 |
| `settlement-service` | 对局结果、积分、段位、成就、统计、奖励结算 | 不负责实时回合控制 |

### 2.4 服务之间的事件流

| 事件来源 | 事件 | 接收方 |
| --- | --- | --- |
| `room-service` | `RoomReadyToStartEvent` | `game-service` |
| `game-service` | `GameCreatedEvent` | `room-service` |
| `game-service` | `GameFinishedEvent` | `settlement-service` |
| `settlement-service` | `PlayerProgressUpdatedEvent` | `user-service` |

## 3. 推荐的分层方式

建议继续沿用当前仓库的模块划分：

| 模块 | 职责 |
| --- | --- |
| `*-domain-core` | 纯领域对象、领域规则、领域事件、仓储接口 |
| `*-application-service` | 用例编排、事务边界、命令查询处理 |
| `*-data-access` | JPA/Redis/EventStore 持久化实现、Mapper、DAO |
| `*-container` | Spring Boot 启动、Bean 装配、配置 |
| `*-security` | JWT、鉴权、权限校验 |
| `game-realtime` | WebSocket 会话管理、订阅推送、命令入口适配 |

统一原则：

- `domain` 不依赖 Spring。
- 一个聚合根只保证自己内部一致性。
- 跨聚合、跨服务通信只通过应用服务和领域事件。
- 一个文件只做一件事，禁止把 DTO、Entity、Mapper、规则都塞进一个类。

## 4. 各微服务的领域建模

---

## 4.1 user-service

### 4.1.1 服务职责

管理玩家身份、资料展示、头像/表情/牌组扩展所有权、个性化偏好。

### 4.1.2 建议的领域

| 领域 | 聚合根 | 说明 |
| --- | --- | --- |
| `profile` | `UserProfile` | 玩家基础资料 |
| `inventory` | `CosmeticInventory` | 拥有的头像、表情包、牌组扩展 |
| `preference` | `PlayerPreference` | 屏蔽、静音、展示偏好 |

### 4.1.3 `profile` 领域

聚合根：`UserProfile`

值对象：

- `UserId`
- `DisplayName`
- `AvatarId`
- `EmotePackId`
- `DeviceFingerprint`

建议文件：

| 文件 | 职责 |
| --- | --- |
| `UserId.java` | 用户主键值对象 |
| `UserProfile.java` | 聚合根，维护昵称、当前头像、当前表情包、安全展示名 |
| `DisplayName.java` | 昵称合法性校验与标准化 |
| `AvatarId.java` | 头像标识值对象 |
| `EmotePackId.java` | 表情包标识值对象 |
| `DeviceFingerprint.java` | 设备标识值对象 |
| `UserProfileRepository.java` | 领域仓储接口 |
| `UserProfileCreatedEvent.java` | 创建资料事件 |
| `UserProfileChangedEvent.java` | 修改资料事件 |

### 4.1.4 `inventory` 领域

聚合根：`CosmeticInventory`

值对象：

- `InventoryId`
- `SkuId`
- `DeckPackId`
- `AvatarPackId`
- `OwnershipStatus`

建议文件：

| 文件 | 职责 |
| --- | --- |
| `InventoryId.java` | 背包主键值对象 |
| `CosmeticInventory.java` | 聚合根，管理用户已拥有的扩展物品 |
| `SkuId.java` | 商业 SKU 值对象 |
| `DeckPackId.java` | 牌组扩展包标识 |
| `AvatarPackId.java` | 头像包标识 |
| `OwnedDeckPack.java` | 已拥有牌组扩展实体 |
| `OwnedAvatarPack.java` | 已拥有头像包实体 |
| `OwnedEmotePack.java` | 已拥有表情包实体 |
| `OwnershipStatus.java` | 所有权状态枚举 |
| `CosmeticInventoryRepository.java` | 领域仓储接口 |
| `InventoryItemGrantedEvent.java` | 发放物品事件 |

### 4.1.5 `preference` 领域

聚合根：`PlayerPreference`

值对象：

- `PreferenceId`
- `TargetUserId`
- `MuteState`
- `BlockState`

建议文件：

| 文件 | 职责 |
| --- | --- |
| `PreferenceId.java` | 偏好聚合 ID |
| `PlayerPreference.java` | 聚合根，管理静音、屏蔽、展示偏好 |
| `TargetUserId.java` | 被作用对象 ID |
| `MuteState.java` | 静音状态值对象 |
| `BlockState.java` | 屏蔽状态值对象 |
| `MutedPlayer.java` | 静音记录实体 |
| `BlockedPlayer.java` | 屏蔽记录实体 |
| `PlayerPreferenceRepository.java` | 领域仓储接口 |
| `PreferenceChangedEvent.java` | 偏好变更事件 |

---

## 4.2 room-service

### 4.2.1 服务职责

负责开局前世界：匹配、建房、加入房间、准备、座位、牌组选择、房间码、房主操作。

### 4.2.2 建议的领域

| 领域 | 聚合根 | 说明 |
| --- | --- | --- |
| `matchmaking` | `MatchTicket` | 排队与匹配条件 |
| `room` | `Room` | 房间本身及大厅状态 |

### 4.2.3 `matchmaking` 领域

聚合根：`MatchTicket`

值对象：

- `MatchTicketId`
- `QueueType`
- `MatchMode`
- `ExpectedPlayerCount`
- `TicketStatus`

建议文件：

| 文件 | 职责 |
| --- | --- |
| `MatchTicketId.java` | 匹配票据 ID |
| `MatchTicket.java` | 聚合根，描述一个玩家或队伍的排队请求 |
| `QueueType.java` | 随机匹配、私人房、好友房等 |
| `MatchMode.java` | 单人/多人/扩展模式 |
| `ExpectedPlayerCount.java` | 目标人数值对象 |
| `TicketStatus.java` | 排队状态枚举 |
| `MatchCriteria.java` | 匹配条件值对象 |
| `MatchTicketRepository.java` | 领域仓储接口 |
| `TicketMatchPolicy.java` | 匹配规则领域服务 |
| `MatchTicketCreatedEvent.java` | 排队开始事件 |
| `TicketMatchedEvent.java` | 匹配成功事件 |

### 4.2.4 `room` 领域

聚合根：`Room`

实体：

- `RoomMember`
- `Seat`

值对象：

- `RoomId`
- `RoomCode`
- `RoomStatus`
- `RoomVisibility`
- `ReadyState`
- `SeatNo`
- `SelectedDeck`

建议文件：

| 文件 | 职责 |
| --- | --- |
| `RoomId.java` | 房间 ID |
| `Room.java` | 聚合根，管理成员、座位、准备状态、开局前约束 |
| `RoomCode.java` | 可分享的房间码 |
| `RoomStatus.java` | 房间状态枚举 |
| `RoomVisibility.java` | 公有/私有/仅邀请码 |
| `SeatNo.java` | 座位号值对象 |
| `ReadyState.java` | 准备状态值对象 |
| `SelectedDeck.java` | 当前房间选中的牌组配置 |
| `RoomMember.java` | 房间成员实体 |
| `Seat.java` | 房间座位实体 |
| `RoomRepository.java` | 领域仓储接口 |
| `RoomStartPolicy.java` | 是否满足开局条件的领域服务 |
| `RoomCreatedEvent.java` | 建房事件 |
| `RoomReadyToStartEvent.java` | 房间满足开局条件事件 |
| `RoomClosedEvent.java` | 房间关闭事件 |

聚合边界说明：

- `Room` 只关心开局前状态，不保存发牌、手牌、弃牌堆。
- `Room` 内部必须保证“人数、准备状态、房主权限、房间可见性”一致。
- 一旦开始游戏，运行时状态转交给 `game-service`。

---

## 4.3 game-service

### 4.3.1 服务职责

负责整个对局生命周期，是最核心的服务。所有卡牌效果、回合推进、摸牌出牌、死亡判定、重连快照，都应该以它为权威。

### 4.3.2 建议的领域

| 领域 | 聚合根 | 说明 |
| --- | --- | --- |
| `catalog` | `CardDefinition`、`DeckDefinition` | 静态卡牌与牌组规则 |
| `session` | `GameSession` | 单局运行时 |

### 4.3.3 `catalog` 领域

聚合根：

- `CardDefinition`
- `DeckDefinition`

值对象：

- `CardCode`
- `CardCategory`
- `CardEffectType`
- `CardPlayTiming`
- `DeckType`
- `PlayerCountCardAmount`

建议文件：

| 文件 | 职责 |
| --- | --- |
| `CardCode.java` | 卡牌编码值对象 |
| `CardDefinition.java` | 卡牌定义聚合根，描述效果、阶段、展示文案、元数据 |
| `CardCategory.java` | 卡牌分类枚举，对应客户端 `CardCategory` |
| `CardEffectType.java` | 效果类型枚举，例如偷牌、洗牌、反转、埋牌 |
| `CardPlayTiming.java` | 可使用阶段枚举 |
| `DeckType.java` | 牌组类型枚举 |
| `DeckDefinition.java` | 牌组定义聚合根，描述某牌组包含哪些卡和数量 |
| `PlayerCountCardAmount.java` | 不同人数下的卡牌数量规则 |
| `CardCatalogRepository.java` | 卡牌目录读取接口 |
| `DeckCatalogRepository.java` | 牌组目录读取接口 |
| `CatalogLoadedEvent.java` | 配置加载完成事件 |

边界说明：

- `catalog` 是静态配置域，读多写少。
- `user-service` 只保存“用户拥有哪个牌组扩展”，不保存牌组内的卡牌规则。
- 真正的出牌合法性必须由 `game-service` 基于 `catalog` 判定。

### 4.3.4 `session` 领域

聚合根：`GameSession`

实体：

- `PlayerState`
- `CardInstance`
- `DrawPile`
- `DiscardPile`
- `HandCards`
- `PendingEffect`
- `TurnState`

值对象：

- `GameSessionId`
- `PlayerId`
- `CardInstanceId`
- `GameStatus`
- `PlayerPhase`
- `CurrentTurnState`
- `TurnQueueDirection`
- `AttackStackCount`

建议文件：

| 文件 | 职责 |
| --- | --- |
| `GameSessionId.java` | 对局 ID |
| `GameSession.java` | 核心聚合根，维护整局状态和规则入口 |
| `GameStatus.java` | 对局状态枚举 |
| `PlayerState.java` | 玩家在本局中的运行时实体 |
| `PlayerPhase.java` | 玩家阶段枚举，例如等待、我的回合、偷牌选择、埋牌 |
| `CurrentTurnState.java` | 当前回合细状态，例如空闲、摸牌中 |
| `TurnQueueDirection.java` | 顺时针/逆时针方向 |
| `TurnState.java` | 当前回合实体，记录当前玩家、剩余回合数、额外攻击层数 |
| `CardInstanceId.java` | 卡牌实例 ID |
| `CardInstance.java` | 单张运行时卡牌实体，记录来源、标记、伪装、腹泻等状态 |
| `DrawPile.java` | 抽牌堆实体 |
| `DiscardPile.java` | 弃牌堆实体 |
| `HandCards.java` | 手牌集合实体 |
| `PendingEffect.java` | 待决效果实体，解决多阶段卡牌效果 |
| `AttackStackCount.java` | 叠加回合/攻击计数值对象 |
| `GameSessionRepository.java` | 领域仓储接口 |
| `StartingDeckBuilder.java` | 根据牌组和人数构建初始牌堆 |
| `GameRuleEngine.java` | 核心规则引擎，校验命令合法性 |
| `CardEffectResolver.java` | 结算卡牌效果的领域服务 |
| `ExplosionResolutionService.java` | 炸弹与拆弹结算规则 |
| `GameCreatedEvent.java` | 对局创建事件 |
| `TurnStartedEvent.java` | 回合开始事件 |
| `CardPlayedEvent.java` | 出牌事件 |
| `PlayerExplodedEvent.java` | 玩家爆炸事件 |
| `GameFinishedEvent.java` | 对局结束事件 |

聚合边界说明：

- `GameSession` 必须是聚合根，因为回合、牌堆、弃牌堆、手牌、玩家死亡状态需要原子一致。
- 不要把 `TurnState`、`DrawPile`、`PlayerState` 拆成独立聚合，否则一次出牌会跨多个聚合提交，规则会失真。
- `CardInstance` 必须区分“卡牌定义”和“卡牌实例”。定义属于 `catalog`，实例属于 `session`。

---

## 4.4 settlement-service

### 4.4.1 服务职责

负责对局结束后的世界：结果落库、排行分、成就、统计、奖励。

### 4.4.2 建议的领域

| 领域 | 聚合根 | 说明 |
| --- | --- | --- |
| `result` | `MatchResult` | 一局比赛的不可变结果 |
| `rating` | `PlayerRating` | 积分与段位 |
| `achievement` | `AchievementProgress` | 成就与进度 |

### 4.4.3 `result` 领域

聚合根：`MatchResult`

实体：

- `PlayerPlacement`
- `EliminationRecord`

值对象：

- `MatchResultId`
- `MatchId`
- `Rank`
- `MatchDuration`

建议文件：

| 文件 | 职责 |
| --- | --- |
| `MatchResultId.java` | 结果聚合 ID |
| `MatchResult.java` | 聚合根，保存一局比赛最终结果，写入后不再修改 |
| `MatchId.java` | 关联对局 ID |
| `PlayerPlacement.java` | 玩家名次实体 |
| `EliminationRecord.java` | 淘汰顺序实体 |
| `Rank.java` | 名次值对象 |
| `MatchDuration.java` | 对局时长值对象 |
| `MatchResultRepository.java` | 领域仓储接口 |
| `MatchResultRecordedEvent.java` | 结果落库事件 |

### 4.4.4 `rating` 领域

聚合根：`PlayerRating`

值对象：

- `PlayerRatingId`
- `SeasonId`
- `RatingScore`
- `RatingDelta`

建议文件：

| 文件 | 职责 |
| --- | --- |
| `PlayerRatingId.java` | 玩家积分聚合 ID |
| `PlayerRating.java` | 聚合根，维护赛季积分和段位 |
| `SeasonId.java` | 赛季标识值对象 |
| `RatingScore.java` | 当前积分值对象 |
| `RatingDelta.java` | 本局积分变化值对象 |
| `RankTier.java` | 段位枚举 |
| `RatingPolicy.java` | 积分结算规则领域服务 |
| `PlayerRatingRepository.java` | 领域仓储接口 |
| `RatingAdjustedEvent.java` | 积分更新事件 |

### 4.4.5 `achievement` 领域

聚合根：`AchievementProgress`

实体：

- `AchievementCounter`

值对象：

- `AchievementProgressId`
- `AchievementCode`
- `ProgressValue`

建议文件：

| 文件 | 职责 |
| --- | --- |
| `AchievementProgressId.java` | 成就进度聚合 ID |
| `AchievementProgress.java` | 聚合根，维护用户的成就进度和解锁状态 |
| `AchievementCode.java` | 成就编码值对象 |
| `ProgressValue.java` | 进度值对象 |
| `AchievementCounter.java` | 单项成就计数实体 |
| `AchievementRule.java` | 成就判定规则领域服务 |
| `AchievementProgressRepository.java` | 领域仓储接口 |
| `AchievementUnlockedEvent.java` | 成就解锁事件 |

---

## 5. 每个服务在应用层、数据层应有哪些文件

下面这套模板四个服务都通用，保持“一个文件一件事”：

### 5.1 application-service

| 文件类型 | 示例 | 职责 |
| --- | --- | --- |
| Command | `CreateRoomCommand.java` | 写操作输入模型 |
| CommandHandler | `CreateRoomCommandHandler.java` | 只处理一个写用例 |
| Query | `GetRoomDetailQuery.java` | 读操作输入模型 |
| QueryHandler | `GetRoomDetailQueryHandler.java` | 只处理一个读用例 |
| Response | `RoomDetailResponse.java` | 返回给接口层的只读 DTO |
| ApplicationService | `RoomApplicationService.java` | 编排多个 handler 或统一事务入口 |

### 5.2 data-access

| 文件类型 | 示例 | 职责 |
| --- | --- | --- |
| PersistenceEntity | `RoomEntity.java` | 数据库存储结构 |
| JpaRepository | `RoomJpaRepository.java` | Spring Data 接口 |
| RepositoryImpl | `RoomRepositoryImpl.java` | 实现领域仓储接口 |
| Mapper | `RoomDataMapper.java` | 领域对象与持久化对象转换 |
| RedisCache | `RoomCacheRepository.java` | 缓存或快照读模型 |
| EventStoreEntity | `GameEventEntity.java` | 事件流持久化结构 |

### 5.3 interface/adapters

| 文件类型 | 示例 | 职责 |
| --- | --- | --- |
| REST Controller | `RoomCommandController.java` | HTTP 写接口 |
| Query Controller | `RoomQueryController.java` | HTTP 读接口 |
| WebSocket Controller | `GameRealtimeController.java` | 实时命令入口 |
| Message Listener | `GameFinishedEventListener.java` | 消费其他服务事件 |
| Event Publisher | `RoomDomainEventPublisher.java` | 发送领域事件 |

## 6. 推荐的包结构

以 `game-service` 为例：

```text
game-service/
  game-domain/
    game-domain-core/
      src/main/java/com/kittens/exploding/game/domain/catalog/
      src/main/java/com/kittens/exploding/game/domain/session/
    game-application-service/
      src/main/java/com/kittens/exploding/game/application/catalog/
      src/main/java/com/kittens/exploding/game/application/session/
  game-data-access/
    src/main/java/com/kittens/exploding/game/dataaccess/catalog/
    src/main/java/com/kittens/exploding/game/dataaccess/session/
  game-realtime/
    src/main/java/com/kittens/exploding/game/realtime/
  game-container/
  game-security/
```

其他服务完全照这个方式平移即可。

## 7. 最重要的建模决策

### 7.1 哪些必须是聚合根

| 聚合根 | 原因 |
| --- | --- |
| `UserProfile` | 玩家基础资料要单点维护 |
| `CosmeticInventory` | 所有权发放需要一致性 |
| `Room` | 开局前成员、准备、座位必须一致 |
| `MatchTicket` | 匹配票据生命周期独立 |
| `GameSession` | 对局状态必须由一个聚合统一裁决 |
| `MatchResult` | 结果天然不可变，适合作为独立聚合 |
| `PlayerRating` | 每次结算只改一个玩家一个赛季的积分 |
| `AchievementProgress` | 成就进度和解锁状态要一起提交 |

### 7.2 哪些应该是值对象

凡是以下对象，优先建成值对象，不要偷懒用 `String` 或 `int` 裸奔：

- 各类 ID：`UserId`、`RoomId`、`GameSessionId`、`CardInstanceId`
- 业务码：`RoomCode`、`SkuId`、`DeckType`、`AchievementCode`
- 展示值：`DisplayName`
- 状态值：`ReadyState`、`GameStatus`、`PlayerPhase`
- 计数值：`ExpectedPlayerCount`、`AttackStackCount`、`RatingScore`

## 8. 最终建议

如果要把这个 Unity 客户端背后的逻辑迁移到 Java 服务端，最稳妥的方案不是“把 Photon 消息翻译成接口”，而是：

1. 先建立 `room-service` 和 `game-service` 的清晰边界。
2. 把所有卡牌规则集中进 `game-service` 的 `GameSession` 聚合。
3. 把静态卡牌配置放进 `game-service.catalog`，不要分散到多个服务。
4. 把用户资料/库存、结算/成长从对局实时状态中彻底剥离。
5. 所有用例按 `Command + Handler`、`Query + Handler`、`Repository + Impl + Mapper` 方式拆文件，严格保持单一职责。

按这个结构推进，后续无论是补 AI、补排行榜、补赛季、补扩展卡牌，都会比直接照着客户端脚本翻译安全得多。
