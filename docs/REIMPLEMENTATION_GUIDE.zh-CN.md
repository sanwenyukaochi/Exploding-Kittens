# Exploding Kittens 跨语言复刻说明

## 先说结论

`Kittens_5.3.11_project` 更像一份反编译后的 Unity 工程参考，而不是一份可以直接移植的完整源码。

最重要的判断有两点：

1. `Scripts/Assembly-CSharp` 里确实保留了游戏的类型命名、状态字段、动作分类、控制器拆分方式。
2. 但很多核心类的方法体已经退化成占位实现，比如 `return null`、`return false`、`return 0`，所以规则逻辑不能直接照搬执行代码，必须自己重写。

因此，如果你要用别的语言重做爆炸猫，应该把这份项目当成：

- 数据定义参考
- 命名和协议参考
- 资源映射参考
- 状态机拆分参考

而不是当成“可直接翻译成另一门语言的完整业务代码”。

## 最值得优先看的核心文件

### 1. 牌库定义和卡牌元数据

这是第一优先级，价值最高。

- `Assets/TextAsset/Cards.Core.csv`
- `Assets/TextAsset/Cards.Streaking.csv`
- `Assets/TextAsset/Cards.Party.csv`
- `Assets/TextAsset/Cards.Barking.csv`
- `Assets/TextAsset/Cards.Betrayal.csv`
- `Assets/TextAsset/Cards.Mixed.csv`

这些 CSV 基本定义了：

- 卡牌类别 `category`
- 卡牌 ID 模板 `idFormat`
- 对应图片资源名 `textureFilename`
- 对应音效 ID `jukeboxId`
- 文案/音效字幕 `soundCaption`
- 不同人数下的张数分布 `2 players` 到 `5 players`

如果只看一组文件就开始复刻，先看这 6 个。

### 2. 基础枚举和规则分类

这些文件定义了整个游戏规则层的“词汇表”，建议一比一保留名字和值：

- `Scripts/Assembly-CSharp/CardCategory.cs`
- `Scripts/Assembly-CSharp/DeckType.cs`
- `Scripts/Assembly-CSharp/PlayerPhase.cs`
- `Scripts/Assembly-CSharp/ActivityType.cs`
- `Scripts/Assembly-CSharp/ExplodingKittensAI/CardActionTypes.cs`
- `Scripts/Assembly-CSharp/ExplodingKittensAI/DifficultyLevel.cs`

这些文件告诉你：

- 有哪些卡牌效果
- 有哪些牌组模式
- 玩家状态机有哪些阶段
- 游戏日志/行为流有哪些活动类型
- 单机 AI 认知中的动作字符串是什么

### 3. 核心领域模型

这些类虽然方法体不能直接用，但字段设计非常值得照抄：

- `Scripts/Assembly-CSharp/Card.cs`
- `Scripts/Assembly-CSharp/Deck.cs`
- `Scripts/Assembly-CSharp/Player.cs`
- `Scripts/Assembly-CSharp/GameDeck.cs`
- `Scripts/Assembly-CSharp/GameOptions.cs`
- `Scripts/Assembly-CSharp/CardCommand.cs`
- `Scripts/Assembly-CSharp/CategoryMetadata.cs`
- `Scripts/Assembly-CSharp/DeckMetadata.cs`
- `Scripts/Assembly-CSharp/ExplodingKittensAI/CardAction.cs`

其中最关键的是：

- `Card.cs`：卡牌实例有哪些运行时状态
- `Deck.cs`：牌堆应该提供哪些操作
- `Player.cs`：玩家状态、回合状态、手牌状态、特殊标记有哪些
- `CardCommand.cs`：出牌命令至少要带哪些参数
- `CardAction.cs`：AI 和规则决策层使用的动作结构

### 4. 规则装配和加载入口

这些文件说明“游戏是怎么被拼起来的”：

- `Scripts/Assembly-CSharp/CardReader.cs`
- `Scripts/Assembly-CSharp/CsvParser.cs`
- `Scripts/Assembly-CSharp/CardRepository.cs`
- `Scripts/Assembly-CSharp/DeckMetadataRepository.cs`
- `Scripts/Assembly-CSharp/CategoryMetadataRepository.cs`
- `Scripts/Assembly-CSharp/GameSetup.cs`
- `Scripts/Assembly-CSharp/GameStarter.cs`
- `Scripts/Assembly-CSharp/GameMessages.cs`
- `Scripts/Assembly-CSharp/SinglePlayerManager.cs`

建议重点理解它们各自的职责，而不是去抄它们的方法体。

### 5. 每张牌效果对应的控制器

如果你要逐张牌重做规则，这一组文件是“功能目录”：

- `SkipDrawController.cs`
- `ShuffleController.cs`
- `FakeShuffleController.cs`
- `StealController.cs`
- `SlapController.cs`
- `SelfSlapController.cs`
- `ReverseController.cs`
- `DrawCardController.cs`
- `SeeTheFutureController.cs`
- `AlterTheFutureController.cs`
- `ShareTheFutureController.cs`
- `DefuseController.cs`
- `DefusableKittenController.cs`
- `OpponentDefusableKittenController.cs`
- `BombPlayedController.cs`
- `CatButtController.cs`
- `DiarrheaController.cs`
- `StreakingKittenController.cs`
- `BarkingKittenController.cs`
- `TakeThatController.cs`
- `BuryController.cs`
- `PotLuckController.cs`
- `TowerOfPowerController.cs`
- `GarbageCollectionController.cs`
- `CatomicBombController.cs`
- `SwapTopBottomController.cs`
- `KittenRollCallController.cs`
- `MarkController.cs`

它们适合拿来建立“规则分发器”的模块边界，例如：

- `CardCategory.Skip -> SkipDrawResolver`
- `CardCategory.Shuffle -> ShuffleResolver`
- `CardCategory.BarkingKitten -> BarkingKittenResolver`

## 如果目标是“换语言实现玩法”，真正该按什么顺序看

建议顺序如下：

1. 先看 `Cards.*.csv`
2. 再看 `CardCategory.cs`、`DeckType.cs`、`PlayerPhase.cs`
3. 再看 `Card.cs`、`Deck.cs`、`Player.cs`
4. 再看 `CardReader.cs`、`CsvParser.cs`、`CardRepository.cs`
5. 再看 `GameMessages.cs` 和各类 `*Controller.cs`
6. 最后再看 `SinglePlayerManager.cs` 和 `ExplodingKittensAI/*`

原因很简单：

- CSV 和枚举决定“游戏里有什么”
- `Card/Deck/Player` 决定“状态怎么存”
- `GameMessages + Controllers` 决定“动作怎么分发”
- `SinglePlayerManager + AI` 决定“单机怎么思考”

## 哪些内容可以 1:1 复刻

下面这些内容技术上都可以尽量一比一保留。

### A. 可以直接照抄的数据定义

- `Cards.*.csv` 的列结构
- `Cards.*.csv` 的行内容
- 每张卡的 `category`
- 每张卡的 `idFormat`
- 每张卡的 `textureFilename`
- 每张卡的 `jukeboxId`
- 每张卡在 2 到 5 人局中的数量
- 各牌组文件名和牌组划分方式

这部分最适合直接原样迁移到你的新语言项目里，比如：

- 原样保留为 CSV
- 转成 JSON
- 转成内嵌常量表

### B. 可以直接照抄的枚举和字符串协议

- `CardCategory` 的成员名和值
- `DeckType` 的成员名和值
- `PlayerPhase` 的成员名和值
- `ActivityType` 的成员名和值
- `DifficultyLevel` 的成员名和值
- `CardActionTypes` 里的所有动作字符串

这一层非常建议原样保留，不要擅自改名。  
原因是它们天然就是跨模块协议。

### C. 可以直接照抄的字段结构

这些类的“字段和属性命名”很值得一比一保留：

- `Card`
- `Deck`
- `Player`
- `CardCommand`
- `CardAction`
- `CategoryMetadata`
- `DeckMetadata`

尤其是 `Player.cs` 里的状态字段，几乎就是一份现成的状态机需求清单，例如：

- 是否死亡
- 是否 AI
- 是否正在选目标
- 是否正在拆弹
- 是否被 Cat Butt 影响
- 是否有 Barking/TowerOfPower 等特殊标记
- 当前玩家阶段

如果你换语言实现，这些变量名和含义基本都可以照抄。

### D. 可以直接照抄的资源命名

如果你想连资源映射也保持一致，这些也可以直接沿用：

- `Assets/Resources/*` 里的卡图文件名
- `Assets/AudioClip/*` 里的卡牌音效命名
- `Assets/TextAsset/EmotePacks.csv`
- 资源名和 `textureFilename` / `jukeboxId` 的对应关系

## 哪些文件适合“照抄结构，重写执行方法”

这类文件最适合你说的那种做法：变量、参数、公共接口照抄，执行逻辑重写。

- `Scripts/Assembly-CSharp/Card.cs`
- `Scripts/Assembly-CSharp/Deck.cs`
- `Scripts/Assembly-CSharp/Player.cs`
- `Scripts/Assembly-CSharp/GameDeck.cs`
- `Scripts/Assembly-CSharp/GameOptions.cs`
- `Scripts/Assembly-CSharp/CardReader.cs`
- `Scripts/Assembly-CSharp/CsvParser.cs`
- `Scripts/Assembly-CSharp/CardRepository.cs`
- `Scripts/Assembly-CSharp/GameSetup.cs`
- `Scripts/Assembly-CSharp/GameMessages.cs`
- `Scripts/Assembly-CSharp/SinglePlayerManager.cs`
- `Scripts/Assembly-CSharp/ExplodingKittensAI/AIGameState.cs`
- 各类卡牌效果控制器 `*Controller.cs`

这类文件的正确使用方式是：

- 抄字段
- 抄方法签名
- 抄模块边界
- 抄输入输出参数
- 自己重写方法体

不要把这些文件当成“完整可运行逻辑源”。

## 哪些文件不用作为核心复刻依据

如果你的目标是“实现玩法”，下面这些目录基本都不是首要阅读对象：

- `Scripts/mscorlib`
- `Scripts/System*`
- `Scripts/UnityEngine*`
- `Scripts/Photon3Unity3D`
- `Scripts/PlayMaker`
- `Scripts/Unity.Services.*`
- `Scripts/UnityEngine.Purchasing*`
- `Scripts/__Generated`
- `Assemblies`
- 大部分 `Assets/Shader`
- 大部分 `Assets/SceneHierarchyObject`
- 大部分 `Assets/PrefabHierarchyObject`

它们主要属于：

- 引擎库
- 网络库
- 商店/IAP
- 分析埋点
- UI 依赖
- 反编译生成物

除非你还要复刻 Unity 端表现层，否则不值得优先看。

## 最推荐的跨语言重构方式

建议你把新项目拆成下面几层：

### 1. 纯数据层

- `CardCategory`
- `DeckType`
- `PlayerPhase`
- `ActivityType`
- `CardDefinition`
- `DeckDefinition`

这一层直接由 `Cards.*.csv` 和几个枚举生成。

### 2. 运行时状态层

- `CardState`
- `DeckState`
- `PlayerState`
- `GameState`
- `TurnState`

这一层主要参考 `Card.cs`、`Deck.cs`、`Player.cs`、`GameOptions.cs`。

### 3. 规则执行层

- `playCard`
- `drawCard`
- `resolveBomb`
- `resolveDefuse`
- `resolveAttack`
- `resolveSteal`
- `resolveFuture`
- `resolveAlter`
- `resolveBarking`
- `resolvePotLuck`

这一层主要参考 `GameMessages.cs` 和各 `*Controller.cs` 的职责划分。

### 4. AI 层

- `CardAction`
- `CardActionTypes`
- `AIGameState`

如果你要做单机，这层可以沿用现有命名协议，但逻辑要自己实现。

### 5. 表现层

- CLI
- Web UI
- 桌面 UI
- 移动端 UI

这一层与 Unity 工程耦合最大，最不值得直接照搬。

## 实操建议

如果你现在就要开工，最小可行阅读集合是：

- `Assets/TextAsset/Cards.Core.csv`
- `Assets/TextAsset/Cards.Streaking.csv`
- `Assets/TextAsset/Cards.Party.csv`
- `Assets/TextAsset/Cards.Barking.csv`
- `Assets/TextAsset/Cards.Betrayal.csv`
- `Assets/TextAsset/Cards.Mixed.csv`
- `Scripts/Assembly-CSharp/CardCategory.cs`
- `Scripts/Assembly-CSharp/DeckType.cs`
- `Scripts/Assembly-CSharp/PlayerPhase.cs`
- `Scripts/Assembly-CSharp/Card.cs`
- `Scripts/Assembly-CSharp/Deck.cs`
- `Scripts/Assembly-CSharp/Player.cs`
- `Scripts/Assembly-CSharp/GameMessages.cs`
- `Scripts/Assembly-CSharp/SinglePlayerManager.cs`
- `Scripts/Assembly-CSharp/ExplodingKittensAI/CardActionTypes.cs`
- `Scripts/Assembly-CSharp/ExplodingKittensAI/CardAction.cs`
- `Scripts/Assembly-CSharp/ExplodingKittensAI/AIGameState.cs`

如果你时间更有限，可以再缩成最小核心四组：

1. `Cards.*.csv`
2. `CardCategory.cs + DeckType.cs + PlayerPhase.cs`
3. `Card.cs + Deck.cs + Player.cs`
4. `GameMessages.cs + 各卡效果 Controller`

## 最后一个重要提醒

技术上可以 1:1 复刻的数据主要是：

- 牌表
- 资源命名
- 枚举
- 状态字段
- 动作协议

技术上不应该指望直接 1:1 复刻的方法主要是：

- 核心规则执行方法
- AI 决策方法
- Unity 事件驱动逻辑
- 网络同步逻辑

如果你用于公开项目或商用发行，还需要另外确认：

- 卡图
- 音频
- 角色名
- 文案
- 游戏规则/IP

这些是法律和版权问题，不是技术问题。
