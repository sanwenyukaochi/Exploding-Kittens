# Exploding Kittens GDX 复刻设计文档

## 1. 文档目的

这份文档不是单纯描述“最终要做成什么”，而是给当前仓库一条可执行的落地路线：

1. 先做什么。
2. 这一阶段要读哪些反向文件和当前项目文件。
3. 这一阶段做到什么程度，才允许进入下一阶段。
4. 哪些内容现在不要碰，避免把项目拖进 UI、联网、动画和规则同时开工的泥潭。

目标是使用 libGDX 复刻《爆炸猫》，优先做出一个可验证、可测试、可逐步扩展的版本，而不是一开始就追求和手机版完全一致。

## 2. 当前仓库现状

### 当前 libGDX 项目

- 当前真正的游戏入口只有 `core/src/main/java/com/exploding_kittens/ExplodingKittens.java`。
- 这个入口目前还是 gdx-liftoff 生成的示例界面，不包含任何爆炸猫规则。
- `assets/` 里目前只有默认 UI 皮肤资源，没有真正的卡牌、音频、牌组配置。
- 项目结构目前是标准双模块：
  - `core/`: 共享逻辑。
  - `lwjgl3/`: 桌面启动器。

### 反向工程项目能提供什么

- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/` 提供了大量类名、字段名、职责命名。
- `Kittens_5.3.11_project/Assets/TextAsset/Cards.*.csv` 提供了最关键的牌组配置数据。
- `Kittens_5.3.11_project/Assets/AudioClip/` 提供了音频命名规则。
- `Kittens_5.3.11_project/Assets/TextAsset/EmotePacks.csv`、头像和其他资源能帮助后期做元内容。

### 一个非常重要的判断

`Kittens_5.3.11_project/Scripts/Assembly-CSharp/` 里的很多 `.cs` 文件方法体是空的，说明你现在拿到的不是可以直接复用的游戏源码，而更像：

- 类名和系统边界说明。
- 字段和事件命名说明。
- 数据文件和资源命名说明。

所以复刻策略应该是：

1. 把反向项目当作“领域词典”和“数据样本”。
2. 不要照抄 Unity 的 `MonoBehaviour` 组织方式。
3. 新项目的核心必须是纯 Java 的规则内核，libGDX 只负责表现和输入。

## 3. 反向资料里最值得优先吃透的内容

### 第一优先级：规则和数据

这些文件会直接决定你怎么建立规则内核：

- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/Card.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/CardCategory.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/Deck.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/Player.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/TurnQueue.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/PlayerPhase.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/CurrentTurnState.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/CardCommand.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/GameSetup.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/StartingHandDistributor.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/RandomKittenInserter.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/CardReader.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/CardRepository.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/DeckMetadata.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/DeckMetadataRepository.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/DeckType.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/GameOptions.cs`

最关键的数据文件：

- `Kittens_5.3.11_project/Assets/TextAsset/Cards.Core.csv`
- `Kittens_5.3.11_project/Assets/TextAsset/Cards.Party.csv`
- `Kittens_5.3.11_project/Assets/TextAsset/Cards.Betrayal.csv`
- `Kittens_5.3.11_project/Assets/TextAsset/Cards.Streaking.csv`
- `Kittens_5.3.11_project/Assets/TextAsset/Cards.Barking.csv`
- `Kittens_5.3.11_project/Assets/TextAsset/Cards.Mixed.csv`

### 第二优先级：单机和 AI

这些文件告诉你单机模式大概怎么切分系统：

- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/SinglePlayerManager.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/EndTurnController.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/DrawPile.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/DiscardPile.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/ChooseCoreDeckAction.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/ExplodingKittensAI/AIGameState.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/ExplodingKittensAI/CardAction.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/ExplodingKittensAI/CardActionTypes.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/ExplodingKittensAI/DifficultyLevel.cs`

### 第三优先级：后期参考，先不要做

这些内容会在后期才有价值：

- Photon 联网相关：`Photon*`, `Multipeer*`, `Networking*`, `GameLobby*`
- 商店/IAP：`Purchasing*`, `DeckPurchase*`
- 分析和成就：`Analytics`, `Achievements`
- 大量弹窗和 Unity 动画控制器：`*Controller`, `*Modal`, `*Animation`

## 4. 推荐的 GDX 架构

不要把新项目做成一个巨大的 `ApplicationAdapter`。当前入口类只保留启动职责，真正的游戏拆成四层。

### 4.1 目标目录结构

建议最终把 `core/src/main/java/com/exploding_kittens/` 组织成下面这样：

```text
com.exploding_kittens
  ExplodingKittensGame.java
  bootstrap/
    GameContext.java
    AssetRegistry.java
  screen/
    BootScreen.java
    MainMenuScreen.java
    GameScreen.java
    DebugRulesScreen.java
  asset/
    GameAssetPaths.java
    GameAssetLoader.java
  data/
    csv/
      CsvCardSetLoader.java
      CsvDeckMetadataLoader.java
    model/
      CardDefinition.java
      DeckDefinition.java
  domain/
    model/
      CardInstance.java
      PlayerState.java
      DeckState.java
      DiscardState.java
      TurnState.java
      MatchState.java
    command/
      GameCommand.java
      PlayCardCommand.java
      DrawCardCommand.java
    rule/
      RuleEngine.java
      CardEffectResolver.java
      StartGameService.java
      TurnService.java
  ai/
    AiDifficulty.java
    AiVisibleState.java
    AiDecision.java
    AiPlanner.java
  presentation/
    hand/
    board/
    hud/
    modal/
  debug/
    MatchSimulator.java
    RuleTraceLogger.java
```

### 4.2 四层职责

| 层 | 责任 | 现在就要做吗 |
| --- | --- | --- |
| `data` | 读取 CSV 和资源描述，构建静态牌定义 | 是 |
| `domain` | 规则、回合、出牌、抽牌、爆炸、胜负 | 是 |
| `presentation` | Scene2D 界面、拖拽、动画、按钮 | 稍后 |
| `ai` / `network` | AI 与联网 | AI 中期，联网后期 |

### 4.3 最重要的工程原则

1. 规则内核不能依赖 libGDX UI 类。
2. `domain` 层必须可以不启动窗口就运行。
3. 每一张牌效果都必须能通过命令和状态变化表达，而不是散落在 UI 组件里。
4. 先做单机可验证版本，再谈联网。
5. 先做 Core deck，再扩 Party/Streaking/Barking/Mixed。

## 5. 第一阶段到底先做什么

先做的不是正式 UI，也不是 AI，也不是联网。

先做：

**数据驱动的规则内核 + 无界面调试沙盒**

原因很简单：

- 你现在最可靠的逆向资料是 CSV 牌组配置。
- `Card.cs`、`Deck.cs`、`Player.cs`、`TurnQueue.cs` 明确了核心领域对象。
- 如果没有独立规则内核，后面每加一个按钮、动画、AI、联网消息都会把规则打散。

这也是整个项目的第一条主线。

## 6. 分阶段实施路线

下面按“阶段目标 -> 必读文件 -> 要实现的东西 -> 完成标准 -> 才能进入下一步”来拆。

---

## 阶段 0：建立复刻基线

### 目标

把当前仓库从“libGDX 示例工程”变成“可以承载爆炸猫规则开发”的工程壳子。

### 先读这些文件

- `README.md`
- `core/src/main/java/com/exploding_kittens/ExplodingKittens.java`
- `build.gradle`
- `core/build.gradle`
- `lwjgl3/build.gradle`

### 要做的事情

1. 把当前示例入口改成真正的 `Game` 类，而不是示例 `ApplicationAdapter`。
2. 建立基础包结构：`screen`, `data`, `domain`, `debug`。
3. 增加一个最简单的 `BootScreen` 或 `MainMenuScreen`。
4. 保留桌面启动链路正常可跑。

### 阶段完成标准

- 项目能正常启动到一个空白主菜单或开发菜单。
- 入口类不再直接写示例窗口代码。
- 目录结构已经为规则内核预留好位置。

### 不要做

- 不要开始拖 UI 皮肤。
- 不要实现卡牌动画。
- 不要接 AI。

---

## 阶段 1：静态数据层

### 目标

把 `Cards.Core.csv` 这类文件变成你自己的静态牌定义对象。

### 必读文件

- `Kittens_5.3.11_project/Assets/TextAsset/Cards.Core.csv`
- `Kittens_5.3.11_project/Assets/TextAsset/Cards.Party.csv`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/CardReader.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/CardRepository.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/CardCategory.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/DeckMetadata.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/DeckMetadataRepository.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/DeckType.cs`

### 你应该实现什么

1. 定义静态数据对象：
   - `CardDefinition`
   - `DeckDefinition`
   - `DeckType`
   - `CardCategory`
2. 写 CSV 解析器，把一行转成 `CardDefinition`。
3. 支持按玩家人数读取一副牌的实际构成。
4. 能从 `Cards.Core.csv` 得到“2/3/4/5 人分别有多少张什么牌”。
5. 把资源名、音效名、文案字段保留下来，即使暂时不用。

### 推荐输出

- 一个开发日志界面或控制台输出：
  - 当前 deck 类型
  - 玩家人数
  - 每种牌数量
  - 总牌数

### 阶段完成标准

- 你能在运行时选择 `Core` 牌组并加载出完整的牌定义列表。
- 2 到 5 人的牌数量统计正确。
- 读取错误时能报出哪一行 CSV 有问题。

### 下一阶段前必须确认

- `Cards.Core.csv` 已经能稳定解析。
- 你清楚哪些字段是展示字段，哪些字段是规则字段。

---

## 阶段 2：纯规则域模型

### 目标

先不做 UI，先把一局牌最核心的运行状态建出来。

### 必读文件

- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/Card.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/Deck.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/Player.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/TurnQueue.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/PlayerPhase.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/CurrentTurnState.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/GameOptions.cs`

### 你应该实现什么

1. 运行时对象：
   - `CardInstance`
   - `PlayerState`
   - `DeckState`
   - `DiscardState`
   - `TurnState`
   - `MatchState`
2. `DeckState` 的基础操作：
   - 抽顶部
   - 抽底部
   - 洗牌
   - 插入指定位置
   - 查看顶部 N 张
   - 移动指定卡到顶部
3. `TurnState` 的基础能力：
   - 当前玩家
   - 顺时针/逆时针
   - 剩余回合数
   - 跳过/额外回合/反转
4. `PlayerState` 的基础能力：
   - 手牌
   - 存活状态
   - 当前阶段
   - 是否本地玩家
   - 是否 AI

### 阶段完成标准

- 可以在不启动 libGDX 窗口的情况下创建一局游戏状态。
- 可以通过单元测试或调试主函数验证：
  - 洗牌正常。
  - 发牌正常。
  - 回合轮转正常。
  - 死亡玩家会被跳过。

### 下一阶段前必须确认

- 规则状态已经不依赖 `Actor`, `Stage`, `Texture`, `Sound`。
- 你的状态对象可以序列化或至少能打印完整调试日志。

---

## 阶段 3：开局流程

### 目标

做出一局牌从“选择牌组”到“发手牌完成”的完整开局。

### 必读文件

- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/GameSetup.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/StartingHandDistributor.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/RandomKittenInserter.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/CardRepository.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/DeckMetadata.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/ChooseCoreDeckAction.cs`

### 你应该实现什么

1. `StartGameService`
   - 根据 deck type 和玩家人数创建牌堆。
   - 分离 Defuse 和 Bomb。
   - 发起始手牌。
   - 把爆炸猫重新插回牌堆。
2. 明确你的开局规则策略：
   - 初始手牌固定几张。
   - Defuse 是直接进手牌还是从定义中单独剥离。
   - 爆炸猫何时插入。
3. 提供一个无 UI 的“新开一局”入口。

### 最小可交付结果

输入：

- 2 人
- `Core` 牌组

输出：

- 两个玩家的手牌列表
- 抽牌堆剩余张数
- 每个玩家起始是否拥有 Defuse
- 爆炸猫是否已经正确插回牌堆

### 阶段完成标准

- 重复开局 100 次不会出现总牌数不守恒。
- 没有玩家开局就抽到爆炸猫。
- 开局后的牌堆、弃牌堆、玩家手牌数量都正确。

### 下一阶段前必须确认

- 你已经能稳定“新建一局”。
- 所有牌数量守恒。

---

## 阶段 4：核心出牌与回合循环

### 目标

做出真正可玩的最小规则闭环。

### 先只支持这些牌

第一批只实现最核心、最容易验证的牌：

- `Bomb`
- `Defuse`
- `Skip`
- `Shuffle`
- `Future3`
- `DrawFromBottom`
- `Reverse`
- `Steal`
- `Slap1`

先不要一口气做：

- `StreakingKitten`
- `BarkingKitten`
- `ShareTheFuture`
- `TowerOfPower`
- `PotLuck`
- `Bury`
- `TakeThat`
- `GarbageCollection`

### 必读文件

- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/CardCommand.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/EndTurnController.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/Player.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/TurnQueue.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/DrawPile.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/DiscardPile.cs`

### 你应该实现什么

1. 命令对象：
   - `PlayCardCommand`
   - `DrawCardCommand`
   - `EndTurnCommand`
2. 规则服务：
   - `CardEffectResolver`
   - `TurnService`
3. 基础规则：
   - 玩家出牌
   - 卡牌进入弃牌堆
   - 手牌变化
   - 回合结束
   - 抽牌
   - 抽到爆炸猫后触发 Defuse 或死亡
4. 规则结果结构：
   - 状态变化
   - 事件日志
   - 需要 UI 决策的挂起状态

### 为什么这一阶段不能直接做完整 UI

因为完整 UI 之前，你必须先搞清楚：

- 哪些牌是立即结算。
- 哪些牌需要玩家二次选择。
- 哪些牌会改写回合数和方向。
- 哪些牌需要“看见但不改变状态”的信息揭示。

这些不先落在规则层，后面的 Scene2D 只会越写越乱。

### 阶段完成标准

- 两个本地玩家可以通过命令行、测试或调试按钮完成一整局。
- Core deck 的基础牌型能跑通。
- 抽到爆炸猫、Defuse、死亡、胜利都能正确发生。

### 下一阶段前必须确认

- 一局牌可以从开局跑到结束。
- 规则 bug 可以通过日志定位。

---

## 阶段 5：调试型游戏界面

### 目标

在 libGDX 里做一个“开发者可玩”的界面，不追求美术还原。

### 必读文件

- `core/src/main/java/com/exploding_kittens/ExplodingKittens.java`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/DrawPile.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/DiscardPile.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/PlayerHand.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/HandCard.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/PlayerHud.cs`

### 你应该实现什么

1. `GameScreen`
2. 最基础的 Scene2D 组件：
   - 手牌列表
   - 抽牌堆
   - 弃牌堆
   - 当前玩家标签
   - 简单按钮：出牌、抽牌、结束
3. 一份调试 HUD：
   - 当前回合方向
   - 剩余回合数
   - 顶部三张预览调试开关
   - 规则日志滚动区

### 这一阶段的原则

- 先用文字和简单矩形代替精美卡牌。
- 卡牌交互先用点击，不要先上拖拽。
- 动画只做最小反馈。

### 阶段完成标准

- 可以在桌面窗口里玩完一局最小版本。
- 所有规则操作都能从界面发出。
- 调试信息足够排查规则错误。

### 下一阶段前必须确认

- 不看控制台也能完成一局。
- UI 只是规则层的映射，没有独自保存规则状态。

---

## 阶段 6：单机 AI

### 目标

把第二个玩家从“热座玩家”替换成 AI。

### 必读文件

- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/SinglePlayerManager.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/ExplodingKittensAI/AIGameState.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/ExplodingKittensAI/CardAction.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/ExplodingKittensAI/CardActionTypes.cs`
- `Kittens_5.3.11_project/Scripts/Assembly-CSharp/ExplodingKittensAI/DifficultyLevel.cs`

### 你应该实现什么

1. 一个简化的 `AiVisibleState`
   - AI 自己的手牌
   - 已知牌堆信息
   - 玩家公开动作
   - 当前风险值
2. 一个最小 AI 策略：
   - 高风险时优先出保命牌
   - 能结束回合时评估是否 Skip/Slap
   - 能看未来时适当看未来
   - 必要时直接抽牌
3. 三档难度可以后做，先做一种稳定策略。

### 阶段完成标准

- 人类玩家可以稳定对战一个 AI。
- AI 不会经常出现非法出牌。
- AI 至少能处理爆炸猫、Defuse、回合结束和基础战术牌。

### 下一阶段前必须确认

- AI 使用的输入是领域状态，不是 UI 对象。
- AI 决策失败不会破坏整局状态。

---

## 阶段 7：扩展牌和扩展牌组

### 目标

从 Core 版本扩到更多牌和更多 deck。

### 推荐顺序

1. `Party`
2. `Streaking`
3. `Betrayal`
4. `Barking`
5. `Mixed`

### 原因

- `Core` 是最适合建立基本规则的牌组。
- `StreakingKitten` 和 `BarkingKitten` 会明显增加状态复杂度。
- `Mixed` 本质上是多个扩展规则叠加后的压力测试。

### 必读文件

- 所有 `Cards.*.csv`
- `CardCategory.cs`
- 相关控制器命名：
  - `StreakingKittenController.cs`
  - `BarkingKittenController.cs`
  - `ShareTheFuture*`
  - `Bury*`
  - `PotLuck*`
  - `TowerOfPower*`

### 你应该实现什么

每增加一张复杂牌，都要做三件事：

1. 静态定义支持。
2. 规则层支持。
3. 界面决策流程支持。

### 阶段完成标准

- 新牌不会破坏老牌。
- 不同 deck type 可以正确开局和跑完整局。

### 下一阶段前必须确认

- 每张复杂牌都至少有一组针对性的规则测试。

---

## 阶段 8：正式表现层

### 目标

在规则已经稳定后，再去追原作体验。

### 可利用的反向资源

- `Kittens_5.3.11_project/Assets/AudioClip/`
- 各种 `Card.*.ogg`
- 各种 `emote.*.ogg`
- 各种资源命名

### 这一阶段可以做

- 真正的卡牌贴图
- 手牌扇形布局
- 拖拽和投放
- 抽牌/弃牌动画
- 音效
- 回合提示
- 模态框

### 阶段完成标准

- 不改变规则层的前提下，UI 和音效可以替换和重做。
- 游戏的“可玩性”和“表现力”分层清晰。

---

## 阶段 9：联网

### 目标

最后再考虑多人联网。

### 为什么必须最后做

反向项目里联网链路非常大：

- `GameLobby*`
- `Photon*`
- `Multipeer*`
- `Networking*`
- `PunTurnManager`

如果前面的单机规则、状态同步边界、命令序列都没稳定，联网只会把 bug 放大。

### 联网前提

你必须先具备：

1. 纯规则命令流。
2. 可序列化的 `MatchState`。
3. 可重放的操作日志。
4. 稳定的 AI 或热座模式验证结果。

### 联网阶段完成标准

- 同一套命令在本地重放和远端同步结果一致。

## 7. 推荐的里程碑顺序

### 里程碑 A：规则沙盒

内容：

- CSV 读取
- 领域模型
- 开局
- 基础出牌
- 无界面日志模拟

完成标准：

- 命令行或测试里能打完整局 Core deck。

### 里程碑 B：可玩桌面原型

内容：

- Scene2D 调试界面
- 两人本地对战

完成标准：

- 可以在桌面上手动玩一局。

### 里程碑 C：单机版本

内容：

- AI
- 更完整的 Core 规则
- 基础表现

完成标准：

- 人类 vs AI 可以稳定游玩。

### 里程碑 D：扩展内容

内容：

- 其他 deck
- 更复杂牌
- 音效和动画

完成标准：

- 至少两个 deck 稳定可玩。

### 里程碑 E：联网版本

内容：

- 房间
- 同步
- 断线处理

完成标准：

- 两台客户端能稳定完成一局。

## 8. 当前最建议你立刻开始的任务

如果你现在准备真正开工，建议按下面的顺序开始，不要跳：

1. 重构 `core/src/main/java/com/exploding_kittens/ExplodingKittens.java`，把示例入口换成真正的 `Game`。
2. 在 `core` 下建立 `data` 和 `domain` 包。
3. 先把 `Cards.Core.csv` 复制或转换到当前 `assets/` 中自己的数据目录。
4. 实现 `CardCategory`, `CardDefinition`, `CsvCardSetLoader`。
5. 写一个调试入口，打印 2 人 `Core` 牌组的统计结果。
6. 再实现 `DeckState`, `PlayerState`, `TurnState`, `StartGameService`。
7. 做一个纯规则模拟，直到可以无 UI 跑完一局。
8. 然后才开始做 `GameScreen`。

## 9. 一句话总结

这个项目最正确的起手式不是“先做漂亮的卡牌界面”，而是：

**先用 CSV 驱动出一个纯规则内核，再用 libGDX 把规则映射成桌面可玩界面，最后再加 AI、表现和联网。**
