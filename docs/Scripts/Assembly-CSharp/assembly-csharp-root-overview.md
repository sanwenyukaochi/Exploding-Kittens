# Assembly-CSharp 根目录说明

本文档说明 `Scripts/Assembly-CSharp` 根目录下的一级文件和一级文件夹职责。

说明：
- 只覆盖根目录直接包含的文件和文件夹。
- 根目录下的文件夹只说明文件夹职责，不展开其内部文件。
- 根目录下的文件说明主要依据文件名、顶层类型声明和少量抽样内容整理，适合做代码导航。

统计：共 10 个根级文件夹，829 个根级文件。

## 根级文件夹

| 文件夹 | 主要职责 |
| --- | --- |
| `EK` | 项目自定义核心命名空间目录，通常承载爆炸猫业务模型、流程和基础设施实现。 |
| `ExitGames` | ExitGames/Photon 底层支持目录，负责网络通信基础类型、工具和调试辅助。 |
| `ExplodingKittensAI` | AI 决策目录，负责电脑玩家状态建模、出牌选择和难度逻辑。 |
| `GameAnalyticsSDK` | GameAnalytics SDK 目录，负责埋点、统计事件和分析上报。 |
| `HutongGames` | PlayMaker 扩展动作目录，负责将项目逻辑接入可视化状态机。 |
| `Photon` | Photon Unity 网络层目录，负责联网行为、Ping、房间和多人同步适配。 |
| `Properties` | 程序集属性目录，负责 Assembly 元数据声明。 |
| `Spine` | Spine 动画运行时目录，负责骨骼动画、图集和附件驱动。 |
| `StansAssets` | 第三方通用工具目录，当前主要用于 iTween 一类动画/补间能力。 |
| `UnityEngine` | 并入项目的 Unity 补充脚本目录，当前主要承载 IAP 收据校验等 Unity 扩展代码。 |

## 根级文件

| 文件 | 类型 | 主要职责 |
| --- | --- | --- |
| `AchievementsManager.cs` | MonoBehaviour 组件 | 统一管理 `Achievements` 相关的状态、数据或整体流程。 |
| `ActionDebouncer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ActionDebouncer` 相关的场景逻辑、表现或交互。 |
| `Activity.cs` | 类 | 封装 `Activity` 相关的核心数据结构或功能逻辑。 |
| `ActivityBanner.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ActivityBanner` 相关的场景逻辑、表现或交互。 |
| `ActivityBannerQueue.cs` | MonoBehaviour 组件 | 维护 `ActivityBanner` 的排队、顺序或待处理集合。 |
| `ActivityEvent.cs` | 委托 | 声明 `Activity` 相关事件或回调约定。 |
| `ActivityGate.cs` | 类 | 封装 `ActivityGate` 相关的核心数据结构或功能逻辑。 |
| `ActivityMessages.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ActivityMessages` 相关的场景逻辑、表现或交互。 |
| `ActivityStream.cs` | MonoBehaviour 组件 | 维护 `Activity` 数据流、展示流或事件流。 |
| `ActivityType.cs` | 枚举 | 定义 `Activity` 的类型枚举或分类。 |
| `ActorProperties.cs` | 类 | 封装 `ActorProperties` 相关的核心数据结构或功能逻辑。 |
| `AITurnOff.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `AITurnOff` 相关的场景逻辑、表现或交互。 |
| `AlterTheFutureController.cs` | MonoBehaviour 组件 | 控制 `AlterTheFuture` 相关的界面交互、表现或流程推进。 |
| `AlterTheFutureEventHandler.cs` | MonoBehaviour 组件 | 监听并处理 `AlterTheFuture` 相关事件。 |
| `AlterTheFutureModal.cs` | MonoBehaviour 组件 | 提供 `AlterTheFuture` 相关的弹窗界面与交互逻辑。 |
| `AlterTimerPosition.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `AlterTimerPosition` 相关的场景逻辑、表现或交互。 |
| `AndroidGenuineChecker.cs` | MonoBehaviour 组件 | 检查 `AndroidGenuine` 的状态、合法性或运行条件。 |
| `AnimateTexture.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `AnimateTexture` 相关的场景逻辑、表现或交互。 |
| `ApiVersionError.cs` | 枚举 | 定义 `ApiVersionError` 的枚举选项或状态分类。 |
| `ApiVersionValidator.cs` | MonoBehaviour 组件 | 校验 `ApiVersion` 是否满足版本、规则或输入要求。 |
| `AppConfig.cs` | 类 | 保存 `App` 相关的配置项。 |
| `ApplicationVersionLabelController.cs` | MonoBehaviour 组件 | 控制 `ApplicationVersionLabel` 相关的界面交互、表现或流程推进。 |
| `Assembly-CSharp.csproj` | 项目文件 | 定义 `Assembly-CSharp` 程序集的编译输入、引用关系和工程配置。 |
| `AtlasAsset.cs` | ScriptableObject 资源 | 以资源对象形式保存 `AtlasAsset` 相关配置或静态数据。 |
| `AtlasRegionAttacher.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `AtlasRegionAttacher` 相关的场景逻辑、表现或交互。 |
| `AttackActivityDefinition.cs` | 类 | 定义 `AttackActivity` 的静态描述或规则数据。 |
| `AudioListenerVolumeController.cs` | MonoBehaviour 组件 | 控制 `AudioListenerVolume` 相关的界面交互、表现或流程推进。 |
| `AuthenticationValues.cs` | 类 | 封装 `Authentication` 相关参数、认证值或配置值。 |
| `AuthModeOption.cs` | 枚举 | 定义 `AuthModeOption` 的枚举选项或状态分类。 |
| `Avatar.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `Avatar` 相关的场景逻辑、表现或交互。 |
| `AvatarDeathController.cs` | MonoBehaviour 组件 | 控制 `AvatarDeath` 相关的界面交互、表现或流程推进。 |
| `AvatarEmoter.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `AvatarEmoter` 相关的场景逻辑、表现或交互。 |
| `AvatarEmoterFactory.cs` | MonoBehaviour 组件 | 负责创建 `AvatarEmoter` 相关对象、组件或界面实例。 |
| `AvatarGrid.cs` | MonoBehaviour 组件 | 负责 `Avatar` 的网格布局与排列。 |
| `AvatarIcon.cs` | MonoBehaviour 组件 | 展示 `Avatar` 图标或图标状态。 |
| `AvatarPack.cs` | 类 | 表示 `Avatar` 的数据集合或资源包。 |
| `AvatarPackCodeRedemption.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `AvatarPackCodeRedemption` 相关的场景逻辑、表现或交互。 |
| `AvatarPackEvent.cs` | 委托 | 声明 `AvatarPack` 相关事件或回调约定。 |
| `AvatarPackPurchaseEvent.cs` | 委托 | 声明 `AvatarPackPurchase` 相关事件或回调约定。 |
| `AvatarPackRepository.cs` | MonoBehaviour 组件 | 负责 `AvatarPack` 相关数据的读取、缓存或查询。 |
| `AvatarPackType.cs` | 枚举 | 定义 `AvatarPack` 的类型枚举或分类。 |
| `AvatarPackVisibilityType.cs` | 枚举 | 定义 `AvatarPackVisibility` 的类型枚举或分类。 |
| `AvatarTurnSelectionController.cs` | MonoBehaviour 组件 | 控制 `AvatarTurnSelection` 相关的界面交互、表现或流程推进。 |
| `BackButton.cs` | MonoBehaviour 组件 | 实现 `Back` 按钮的交互或表现逻辑。 |
| `BackButtonEnabledGateAction.cs` | 类 | 封装 `BackButtonEnabledGate` 相关的可执行动作或状态机步骤。 |
| `BackButtonFactory.cs` | MonoBehaviour 组件 | 负责创建 `BackButton` 相关对象、组件或界面实例。 |
| `BackButtonStyle.cs` | 枚举 | 定义 `BackButton` 的样式选项。 |
| `BackgroundChooser.cs` | MonoBehaviour 组件 | 选择 `Background` 对应资源、背景或策略。 |
| `Badge.cs` | MonoBehaviour 组件 | 展示 `Badge` 徽章或状态标识。 |
| `BannerFactoryCriteria.cs` | 类 | 封装 `BannerFactoryCriteria` 相关的核心数据结构或功能逻辑。 |
| `BannerMetadata.cs` | 类 | 描述 `Banner` 相关的元数据或展示信息。 |
| `BannerMetadataFactory.cs` | MonoBehaviour 组件 | 构建 `Banner` 相关的元数据对象。 |
| `BarkingKittenController.cs` | MonoBehaviour 组件 | 控制 `BarkingKitten` 相关的界面交互、表现或流程推进。 |
| `BarkingKittenModal.cs` | MonoBehaviour 组件 | 提供 `BarkingKitten` 相关的弹窗界面与交互逻辑。 |
| `BlacklistedNameReplacer.cs` | 类 | 封装 `BlacklistedNameReplacer` 相关的核心数据结构或功能逻辑。 |
| `BlacklistedWordRepository.cs` | MonoBehaviour 组件 | 负责 `BlacklistedWord` 相关数据的读取、缓存或查询。 |
| `BombPlacementButtonList.cs` | MonoBehaviour 组件 | 管理 `BombPlacement` 相关按钮集合及其排列。 |
| `BombPlacementModal.cs` | MonoBehaviour 组件 | 提供 `BombPlacement` 相关的弹窗界面与交互逻辑。 |
| `BombPlacementOptionsProvider.cs` | MonoBehaviour 组件 | 提供 `BombPlacement` 可选项或配置候选集合。 |
| `BombPlacementRadioButton.cs` | 类 | 实现 `BombPlacement` 单选按钮逻辑。 |
| `BombPlayedController.cs` | MonoBehaviour 组件 | 控制 `BombPlayed` 相关的界面交互、表现或流程推进。 |
| `BombPlayedEffect.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `BombPlayedEffect` 相关的场景逻辑、表现或交互。 |
| `BoneFollower.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `BoneFollower` 相关的场景逻辑、表现或交互。 |
| `BoolEvent.cs` | 委托 | 声明 `Bool` 相关事件或回调约定。 |
| `BoundingBoxFollower.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `BoundingBoxFollower` 相关的场景逻辑、表现或交互。 |
| `BubbleCaption.cs` | MonoBehaviour 组件 | 显示 `Bubble` 说明文字、气泡或文案。 |
| `BubbleCaptionFactory.cs` | MonoBehaviour 组件 | 创建 `Bubble` 说明文字或气泡文案。 |
| `BuryController.cs` | MonoBehaviour 组件 | 控制 `Bury` 相关的界面交互、表现或流程推进。 |
| `BuryPlacementModal.cs` | MonoBehaviour 组件 | 提供 `BuryPlacement` 相关的弹窗界面与交互逻辑。 |
| `ButtonPressedAnimation.cs` | MonoBehaviour 组件 | 实现 `ButtonPressed` 的动画逻辑。 |
| `ButtonPressTrigger.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ButtonPressTrigger` 相关的场景逻辑、表现或交互。 |
| `CallbackAction.cs` | 类 | 封装 `Callback` 相关的可执行动作或状态机步骤。 |
| `Card.cs` | 类 | 封装 `Card` 相关的核心数据结构或功能逻辑。 |
| `CardActuator.cs` | 类 | 封装 `CardActuator` 相关的核心数据结构或功能逻辑。 |
| `CardBack.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `CardBack` 相关的场景逻辑、表现或交互。 |
| `CardBackEvent.cs` | 委托 | 声明 `CardBack` 相关事件或回调约定。 |
| `CardBackFactory.cs` | MonoBehaviour 组件 | 负责创建 `CardBack` 相关对象、组件或界面实例。 |
| `CardBackSounds.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `CardBackSounds` 相关的场景逻辑、表现或交互。 |
| `CardBannerMetadataFactory.cs` | 类 | 构建 `CardBanner` 相关的元数据对象。 |
| `CardCategory.cs` | 枚举 | 定义 `Card` 的分类信息。 |
| `CardCommand.cs` | 类 | 表达 `Card` 相关命令、指令或操作请求。 |
| `CardCommandAction.cs` | MonoBehaviour 组件 | 封装 `Card` 相关命令动作的执行逻辑。 |
| `CardCommandDelegate.cs` | 委托 | 声明 `CardCommand` 相关的委托回调签名。 |
| `CardDetailsModal.cs` | MonoBehaviour 组件 | 提供 `CardDetails` 相关的弹窗界面与交互逻辑。 |
| `CardDisguiseController.cs` | MonoBehaviour 组件 | 控制 `CardDisguise` 相关的界面交互、表现或流程推进。 |
| `CardDropTarget.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `CardDropTarget` 相关的场景逻辑、表现或交互。 |
| `CardEvent.cs` | 委托 | 声明 `Card` 相关事件或回调约定。 |
| `CardPhaseGuardAction.cs` | 类 | 在执行 `CardPhase` 前进行条件守卫或流程拦截。 |
| `CardProvider.cs` | 类 | 提供 `Card` 所需的数据、引用、选项或运行时上下文。 |
| `CardReader.cs` | MonoBehaviour 组件 | 负责读取 `Card` 相关资源、文本或配置数据。 |
| `CardRepository.cs` | MonoBehaviour 组件 | 负责 `Card` 相关数据的读取、缓存或查询。 |
| `CardRepositoryInitializer.cs` | MonoBehaviour 组件 | 初始化 `Card` 仓储的数据装载与启动流程。 |
| `CardsLeftDataProvider.cs` | 类 | 为界面或流程提供 `CardsLeft` 相关数据。 |
| `CardSpawnLocationProvider.cs` | MonoBehaviour 组件 | 提供 `CardSpawnLocation` 所需的数据、引用、选项或运行时上下文。 |
| `CardStackPositionCalculator.cs` | MonoBehaviour 组件 | 计算 `CardStackPosition` 相关位置、数值或结果。 |
| `CatButtController.cs` | MonoBehaviour 组件 | 控制 `CatButt` 相关的界面交互、表现或流程推进。 |
| `CatButtShuffler.cs` | MonoBehaviour 组件 | 执行 `CatButt` 的洗牌、打乱或重排逻辑。 |
| `CategoryMetadata.cs` | 类 | 描述 `Category` 相关的元数据或展示信息。 |
| `CategoryMetadataRepository.cs` | MonoBehaviour 组件 | 负责 `CategoryMetadata` 相关数据的读取、缓存或查询。 |
| `CatomicBombController.cs` | MonoBehaviour 组件 | 控制 `CatomicBomb` 相关的界面交互、表现或流程推进。 |
| `CatPawCountdown.cs` | MonoBehaviour 组件 | 处理 `CatPaw` 倒计时逻辑与展示。 |
| `CatPawCountdownFactory.cs` | MonoBehaviour 组件 | 负责创建 `CatPawCountdown` 相关对象、组件或界面实例。 |
| `CatPawEvent.cs` | 委托 | 声明 `CatPaw` 相关事件或回调约定。 |
| `CellTree.cs` | 类 | 封装 `CellTree` 相关的核心数据结构或功能逻辑。 |
| `CellTreeNode.cs` | 类 | 封装 `CellTreeNode` 相关的核心数据结构或功能逻辑。 |
| `ChanceOfKittenDataProvider.cs` | 类 | 为界面或流程提供 `ChanceOfKitten` 相关数据。 |
| `ChangeAvatarPanel.cs` | MonoBehaviour 组件 | 承载 `ChangeAvatar` 相关的面板界面与展示逻辑。 |
| `ChangeAvatarPanelFactory.cs` | 类 | 负责创建 `ChangeAvatarPanel` 相关对象、组件或界面实例。 |
| `ChangeAvatarPanelProvider.cs` | MonoBehaviour 组件 | 提供 `ChangeAvatarPanel` 所需的数据、引用、选项或运行时上下文。 |
| `ChangeSceneAction.cs` | 类 | 封装 `ChangeScene` 相关的可执行动作或状态机步骤。 |
| `ChatButtonController.cs` | MonoBehaviour 组件 | 控制 `Chat` 按钮的行为与交互反馈。 |
| `ChatMenuGridController.cs` | MonoBehaviour 组件 | 控制 `ChatMenuGrid` 相关的界面交互、表现或流程推进。 |
| `ChatMenuItem.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ChatMenuItem` 相关的场景逻辑、表现或交互。 |
| `ChatMenuItemEvent.cs` | 委托 | 声明 `ChatMenuItem` 相关事件或回调约定。 |
| `ChatMenuItemFactory.cs` | MonoBehaviour 组件 | 负责创建 `ChatMenuItem` 相关对象、组件或界面实例。 |
| `ChatMenuModal.cs` | MonoBehaviour 组件 | 提供 `ChatMenu` 相关的弹窗界面与交互逻辑。 |
| `CheatUnlockerWindowController.cs` | 类 | 控制 `CheatUnlocker` 窗口的展示、关闭与内部流程。 |
| `CheckPassword.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `CheckPassword` 相关的场景逻辑、表现或交互。 |
| `ChooseCoreDeckAction.cs` | 类 | 封装 `ChooseCoreDeck` 相关的可执行动作或状态机步骤。 |
| `ChooseDeckWindowController.cs` | MonoBehaviour 组件 | 控制 `ChooseDeck` 窗口的展示、关闭与内部流程。 |
| `ChooseDifficulty.cs` | 类 | 封装 `ChooseDifficulty` 相关的核心数据结构或功能逻辑。 |
| `ChooseOpponentAvatarController.cs` | MonoBehaviour 组件 | 控制 `ChooseOpponentAvatar` 相关的界面交互、表现或流程推进。 |
| `ChooseOpponentMonitor.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ChooseOpponentMonitor` 相关的场景逻辑、表现或交互。 |
| `ChoosingTargetMetadataFactory.cs` | 类 | 构建 `ChoosingTarget` 相关的元数据对象。 |
| `ClientPhase.cs` | 枚举 | 定义 `ClientPhase` 的枚举选项或状态分类。 |
| `ClientState.cs` | 枚举 | 描述 `Client` 的状态结构或状态枚举。 |
| `CloudRegionCode.cs` | 枚举 | 定义 `CloudRegionCode` 的枚举选项或状态分类。 |
| `CloudRegionFlag.cs` | 枚举 | 定义 `CloudRegionFlag` 的枚举选项或状态分类。 |
| `ConnectAndJoinRandom.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ConnectAndJoinRandom` 相关的场景逻辑、表现或交互。 |
| `ConnectionState.cs` | 枚举 | 描述 `Connection` 的状态结构或状态枚举。 |
| `Countdown.cs` | MonoBehaviour 组件 | 处理 `Countdown` 倒计时逻辑与展示。 |
| `CountdownEvent.cs` | 委托 | 声明 `Countdown` 相关事件或回调约定。 |
| `CountdownExpirationAnnouncer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `CountdownExpirationAnnouncer` 相关的场景逻辑、表现或交互。 |
| `CountdownGateController.cs` | MonoBehaviour 组件 | 控制 `CountdownGate` 相关的界面交互、表现或流程推进。 |
| `CountdownLabelUpdater.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `CountdownLabelUpdater` 相关的场景逻辑、表现或交互。 |
| `CountdownNeedleAnimator.cs` | MonoBehaviour 组件 | 驱动 `CountdownNeedle` 的动画表现。 |
| `CountdownPlungerAnimator.cs` | MonoBehaviour 组件 | 驱动 `CountdownPlunger` 的动画表现。 |
| `CountdownProvider.cs` | 类 | 提供 `Countdown` 所需的数据、引用、选项或运行时上下文。 |
| `CountdownState.cs` | 枚举 | 描述 `Countdown` 的状态结构或状态枚举。 |
| `CountdownTickEmitter.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `CountdownTickEmitter` 相关的场景逻辑、表现或交互。 |
| `CountdownUpdateEvent.cs` | 委托 | 声明 `CountdownUpdate` 相关事件或回调约定。 |
| `CountdownVisibilityController.cs` | MonoBehaviour 组件 | 控制 `CountdownVisibility` 相关的界面交互、表现或流程推进。 |
| `CsvParser.cs` | 类 | 封装 `CsvParser` 相关的核心数据结构或功能逻辑。 |
| `CSVReader.cs` | 类 | 负责读取 `CSV` 相关资源、文本或配置数据。 |
| `CullArea.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `CullArea` 相关的场景逻辑、表现或交互。 |
| `CurrentDeckLabelUpdater.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `CurrentDeckLabelUpdater` 相关的场景逻辑、表现或交互。 |
| `CurrentTurnState.cs` | 枚举 | 描述 `CurrentTurn` 的状态结构或状态枚举。 |
| `CustomAuthenticationType.cs` | 枚举 | 定义 `CustomAuthentication` 的类型枚举或分类。 |
| `CustomSkin.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `CustomSkin` 相关的场景逻辑、表现或交互。 |
| `CustomTypes.cs` | 类 | 封装 `CustomTypes` 相关的核心数据结构或功能逻辑。 |
| `CycleAction.cs` | 类 | 封装 `Cycle` 相关的可执行动作或状态机步骤。 |
| `Debug.cs` | 类 | 封装 `Debug` 相关的核心数据结构或功能逻辑。 |
| `DebugPlayersInjector.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `DebugPlayersInjector` 相关的场景逻辑、表现或交互。 |
| `Deck.cs` | 类 | 封装 `Deck` 相关的核心数据结构或功能逻辑。 |
| `DeckChangeNotificationAction.cs` | 类 | 封装 `DeckChangeNotification` 相关的可执行动作或状态机步骤。 |
| `DeckDetailsModal.cs` | MonoBehaviour 组件 | 提供 `DeckDetails` 相关的弹窗界面与交互逻辑。 |
| `DeckDetailsRow.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `DeckDetailsRow` 相关的场景逻辑、表现或交互。 |
| `DeckDetailsRowFactory.cs` | MonoBehaviour 组件 | 负责创建 `DeckDetailsRow` 相关对象、组件或界面实例。 |
| `DeckEvent.cs` | 委托 | 声明 `Deck` 相关事件或回调约定。 |
| `DeckMetadata.cs` | 类 | 描述 `Deck` 相关的元数据或展示信息。 |
| `DeckMetadataRepository.cs` | MonoBehaviour 组件 | 负责 `DeckMetadata` 相关数据的读取、缓存或查询。 |
| `DeckOutputScript.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `DeckOutputScript` 相关的场景逻辑、表现或交互。 |
| `DeckProvider.cs` | 类 | 提供 `Deck` 所需的数据、引用、选项或运行时上下文。 |
| `DeckPurchaseEvent.cs` | 委托 | 声明 `DeckPurchase` 相关事件或回调约定。 |
| `DeckReminder.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `DeckReminder` 相关的场景逻辑、表现或交互。 |
| `DeckStats.cs` | MonoBehaviour 组件 | 记录 `Deck` 相关统计结果。 |
| `DeckStatsEvent.cs` | 委托 | 声明 `DeckStats` 相关事件或回调约定。 |
| `DeckType.cs` | 枚举 | 定义 `Deck` 的类型枚举或分类。 |
| `DeckTypeEvent.cs` | 委托 | 声明 `DeckType` 相关事件或回调约定。 |
| `DefaultNameProvider.cs` | 类 | 提供 `DefaultName` 所需的数据、引用、选项或运行时上下文。 |
| `DefusableKittenAnimation.cs` | MonoBehaviour 组件 | 实现 `DefusableKitten` 的动画逻辑。 |
| `DefusableKittenController.cs` | MonoBehaviour 组件 | 控制 `DefusableKitten` 相关的界面交互、表现或流程推进。 |
| `DefuseController.cs` | MonoBehaviour 组件 | 控制 `Defuse` 相关的界面交互、表现或流程推进。 |
| `DefuseModal.cs` | MonoBehaviour 组件 | 提供 `Defuse` 相关的弹窗界面与交互逻辑。 |
| `DefuseModalFactory.cs` | MonoBehaviour 组件 | 负责创建 `DefuseModal` 相关对象、组件或界面实例。 |
| `Dialog.cs` | 类 | 提供 `Dialog` 相关的对话框逻辑。 |
| `DialogId.cs` | 枚举 | 定义 `DialogId` 的枚举选项或状态分类。 |
| `DialogRepository.cs` | MonoBehaviour 组件 | 负责 `Dialog` 相关数据的读取、缓存或查询。 |
| `DiarrheaController.cs` | MonoBehaviour 组件 | 控制 `Diarrhea` 相关的界面交互、表现或流程推进。 |
| `DirectionChangeEvent.cs` | 委托 | 声明 `DirectionChange` 相关事件或回调约定。 |
| `DisableButtonAction.cs` | 类 | 封装 `DisableButton` 相关的可执行动作或状态机步骤。 |
| `DisablyButton.cs` | MonoBehaviour 组件 | 实现 `Disably` 按钮的交互或表现逻辑。 |
| `DiscardCounter.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `DiscardCounter` 相关的场景逻辑、表现或交互。 |
| `DiscardDropTarget.cs` | 类 | 封装 `DiscardDropTarget` 相关的核心数据结构或功能逻辑。 |
| `DiscardedCard.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `DiscardedCard` 相关的场景逻辑、表现或交互。 |
| `DiscardedCardEffect.cs` | 枚举 | 定义 `DiscardedCardEffect` 的枚举选项或状态分类。 |
| `DiscardedCardFactory.cs` | MonoBehaviour 组件 | 负责创建 `DiscardedCard` 相关对象、组件或界面实例。 |
| `DiscardPile.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `DiscardPile` 相关的场景逻辑、表现或交互。 |
| `DiscardPileProvider.cs` | 类 | 提供 `DiscardPile` 所需的数据、引用、选项或运行时上下文。 |
| `DiscardPopup.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `DiscardPopup` 相关的场景逻辑、表现或交互。 |
| `DisconnectCause.cs` | 枚举 | 定义 `DisconnectCause` 的枚举选项或状态分类。 |
| `Dot.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `Dot` 相关的场景逻辑、表现或交互。 |
| `DotsAnimator.cs` | MonoBehaviour 组件 | 驱动 `Dots` 的动画表现。 |
| `DragDropDrawableCard.cs` | 类 | 封装 `DragDropDrawableCard` 相关的核心数据结构或功能逻辑。 |
| `DragDropHandCard.cs` | 类 | 封装 `DragDropHandCard` 相关的核心数据结构或功能逻辑。 |
| `DraggableCard.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `DraggableCard` 相关的场景逻辑、表现或交互。 |
| `DraggableCardFactory.cs` | MonoBehaviour 组件 | 负责创建 `DraggableCard` 相关对象、组件或界面实例。 |
| `DrawCardController.cs` | MonoBehaviour 组件 | 控制 `DrawCard` 相关的界面交互、表现或流程推进。 |
| `DrawFromBottomCardRemover.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `DrawFromBottomCardRemover` 相关的场景逻辑、表现或交互。 |
| `DrawPile.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `DrawPile` 相关的场景逻辑、表现或交互。 |
| `DrawPileProvider.cs` | 类 | 提供 `DrawPile` 所需的数据、引用、选项或运行时上下文。 |
| `DrawType.cs` | 枚举 | 定义 `Draw` 的类型枚举或分类。 |
| `Emote.cs` | 类 | 封装 `Emote` 相关的核心数据结构或功能逻辑。 |
| `EmoteAnimationController.cs` | MonoBehaviour 组件 | 控制 `EmoteAnimation` 相关的界面交互、表现或流程推进。 |
| `EmoteBubble.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `EmoteBubble` 相关的场景逻辑、表现或交互。 |
| `EmoteController.cs` | MonoBehaviour 组件 | 控制 `Emote` 相关的界面交互、表现或流程推进。 |
| `EmotePack.cs` | 类 | 表示 `Emote` 的数据集合或资源包。 |
| `EmotePackLoader.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `EmotePackLoader` 相关的场景逻辑、表现或交互。 |
| `EmotePackRepository.cs` | MonoBehaviour 组件 | 负责 `EmotePack` 相关数据的读取、缓存或查询。 |
| `EncryptionDataParameters.cs` | 类 | 封装 `EncryptionDataParameters` 相关的核心数据结构或功能逻辑。 |
| `EncryptionMode.cs` | 枚举 | 定义 `Encryption` 的模式选项。 |
| `EndTurnController.cs` | MonoBehaviour 组件 | 控制 `EndTurn` 相关的界面交互、表现或流程推进。 |
| `EnterCodeFrame.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `EnterCodeFrame` 相关的场景逻辑、表现或交互。 |
| `EnterCodeFrameBottomStyle.cs` | 枚举 | 定义 `EnterCodeFrameBottom` 的样式选项。 |
| `EnterCodeFrameEvent.cs` | 委托 | 声明 `EnterCodeFrame` 相关事件或回调约定。 |
| `EnterCodeFrameFactory.cs` | MonoBehaviour 组件 | 负责创建 `EnterCodeFrame` 相关对象、组件或界面实例。 |
| `EnterCodeFrameProvider.cs` | MonoBehaviour 组件 | 提供 `EnterCodeFrame` 所需的数据、引用、选项或运行时上下文。 |
| `EnterCodeInputController.cs` | MonoBehaviour 组件 | 控制 `EnterCodeInput` 相关的界面交互、表现或流程推进。 |
| `EnterRoomParams.cs` | 类 | 封装 `EnterRoomParams` 相关的核心数据结构或功能逻辑。 |
| `ErrorCode.cs` | 类 | 封装 `ErrorCode` 相关的核心数据结构或功能逻辑。 |
| `EscapeKeyHandler.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `EscapeKeyHandler` 相关的场景逻辑、表现或交互。 |
| `EventCaching.cs` | 枚举 | 定义 `EventCaching` 的枚举选项或状态分类。 |
| `EventCode.cs` | 类 | 封装 `EventCode` 相关的核心数据结构或功能逻辑。 |
| `ExitGameAction.cs` | 类 | 封装 `ExitGame` 相关的可执行动作或状态机步骤。 |
| `ExplicitRenderSettings.cs` | MonoBehaviour 组件 | 保存 `ExplicitRender` 相关设置。 |
| `ExplodingKittenLabelController.cs` | MonoBehaviour 组件 | 控制 `ExplodingKittenLabel` 相关的界面交互、表现或流程推进。 |
| `ExplodingKittenRemover.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ExplodingKittenRemover` 相关的场景逻辑、表现或交互。 |
| `ExplodingKittensDataProvider.cs` | 类 | 为界面或流程提供 `ExplodingKittens` 相关数据。 |
| `Extensions.cs` | 类 | 提供 `Extensions` 相关扩展方法。 |
| `FactDataProvider.cs` | MonoBehaviour 组件 | 为界面或流程提供 `Fact` 相关数据。 |
| `FactStamp.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `FactStamp` 相关的场景逻辑、表现或交互。 |
| `FactStampFactory.cs` | MonoBehaviour 组件 | 负责创建 `FactStamp` 相关对象、组件或界面实例。 |
| `FadeCard.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `FadeCard` 相关的场景逻辑、表现或交互。 |
| `FadeOutScript.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `FadeOutScript` 相关的场景逻辑、表现或交互。 |
| `FadeOutSprite.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `FadeOutSprite` 相关的场景逻辑、表现或交互。 |
| `FadePanelAction.cs` | 类 | 封装 `FadePanel` 相关的可执行动作或状态机步骤。 |
| `FadeWidgetAction.cs` | 类 | 封装 `FadeWidget` 相关的可执行动作或状态机步骤。 |
| `FakeShuffleController.cs` | MonoBehaviour 组件 | 控制 `FakeShuffle` 相关的界面交互、表现或流程推进。 |
| `FlagButtonController.cs` | MonoBehaviour 组件 | 控制 `Flag` 按钮的行为与交互反馈。 |
| `FlaggedDeviceIdRepository.cs` | MonoBehaviour 组件 | 负责 `FlaggedDeviceId` 相关数据的读取、缓存或查询。 |
| `FlushCard.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `FlushCard` 相关的场景逻辑、表现或交互。 |
| `FramerateController.cs` | MonoBehaviour 组件 | 控制 `Framerate` 相关的界面交互、表现或流程推进。 |
| `FreshTutorialSpawner.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `FreshTutorialSpawner` 相关的场景逻辑、表现或交互。 |
| `FriendInfo.cs` | 类 | 封装 `Friend` 相关信息结构。 |
| `FuseScaleScript.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `FuseScaleScript` 相关的场景逻辑、表现或交互。 |
| `FutureBannerGenerator.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `FutureBannerGenerator` 相关的场景逻辑、表现或交互。 |
| `GAAdMobIntegration.cs` | 类 | 封装 `GAAdMobIntegration` 相关的核心数据结构或功能逻辑。 |
| `GAAequusIntegration.cs` | 类 | 封装 `GAAequusIntegration` 相关的核心数据结构或功能逻辑。 |
| `GAFyberIntegration.cs` | 类 | 封装 `GAFyberIntegration` 相关的核心数据结构或功能逻辑。 |
| `GAHyperBidIntegration.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `GAHyperBidIntegration` 相关的场景逻辑、表现或交互。 |
| `GAIronSourceIntegration.cs` | 类 | 封装 `GAIronSourceIntegration` 相关的核心数据结构或功能逻辑。 |
| `GAManager.cs` | MonoBehaviour 组件 | 统一管理 `GA` 相关的状态、数据或整体流程。 |
| `GAMaxIntegration.cs` | 类 | 封装 `GAMaxIntegration` 相关的核心数据结构或功能逻辑。 |
| `GameAlert.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `GameAlert` 相关的场景逻辑、表现或交互。 |
| `GameClient.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `GameClient` 相关的场景逻辑、表现或交互。 |
| `GameDeck.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `GameDeck` 相关的场景逻辑、表现或交互。 |
| `GameDisconnectionHandler.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `GameDisconnectionHandler` 相关的场景逻辑、表现或交互。 |
| `GameFailedToStartDetector.cs` | MonoBehaviour 组件 | 检测 `GameFailedToStart` 是否出现、可见或满足条件。 |
| `GameFailedToStartDetectorEvent.cs` | 委托 | 声明 `GameFailedToStartDetector` 相关事件或回调约定。 |
| `GameListWindowInitializer.cs` | 类 | 执行 `GameListWindow` 的初始化与启动准备。 |
| `GameLobbyController.cs` | MonoBehaviour 组件 | 控制 `GameLobby` 相关的界面交互、表现或流程推进。 |
| `GameLobbyEvent.cs` | 委托 | 声明 `GameLobby` 相关事件或回调约定。 |
| `GameLobbyListController.cs` | MonoBehaviour 组件 | 控制 `GameLobbyList` 相关的界面交互、表现或流程推进。 |
| `GameMessages.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `GameMessages` 相关的场景逻辑、表现或交互。 |
| `GameObjectExtensions.cs` | 类 | 提供 `GameObject` 相关扩展方法。 |
| `GameOptions.cs` | 类 | 封装 `GameOptions` 相关的核心数据结构或功能逻辑。 |
| `GameplayAnnouncer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `GameplayAnnouncer` 相关的场景逻辑、表现或交互。 |
| `GamePropertyKey.cs` | 类 | 封装 `GamePropertyKey` 相关的核心数据结构或功能逻辑。 |
| `GameSceneClientMessages.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `GameSceneClientMessages` 相关的场景逻辑、表现或交互。 |
| `GameSceneInitializer.cs` | MonoBehaviour 组件 | 执行 `GameScene` 的初始化与启动准备。 |
| `GameSetup.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `GameSetup` 相关的场景逻辑、表现或交互。 |
| `GameStartEnsurer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `GameStartEnsurer` 相关的场景逻辑、表现或交互。 |
| `GameStarter.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `GameStarter` 相关的场景逻辑、表现或交互。 |
| `GameStartMessages.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `GameStartMessages` 相关的场景逻辑、表现或交互。 |
| `GameStats.cs` | MonoBehaviour 组件 | 记录 `Game` 相关统计结果。 |
| `GAMopubIntegration.cs` | 类 | 封装 `GAMopubIntegration` 相关的核心数据结构或功能逻辑。 |
| `GarbageCollectionController.cs` | MonoBehaviour 组件 | 控制 `GarbageCollection` 相关的界面交互、表现或流程推进。 |
| `GarbageCollectionModal.cs` | MonoBehaviour 组件 | 提供 `GarbageCollection` 相关的弹窗界面与交互逻辑。 |
| `Gate.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `Gate` 相关的场景逻辑、表现或交互。 |
| `GATopOnIntegration.cs` | 类 | 封装 `GATopOnIntegration` 相关的核心数据结构或功能逻辑。 |
| `GenericBannerMetadataFactory.cs` | 类 | 构建 `GenericBanner` 相关的元数据对象。 |
| `GenericButtonToggler.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `GenericButtonToggler` 相关的场景逻辑、表现或交互。 |
| `GenericEvent.cs` | 委托 | 声明 `Generic` 相关事件或回调约定。 |
| `GenericNagRepository.cs` | MonoBehaviour 组件 | 负责 `GenericNag` 相关数据的读取、缓存或查询。 |
| `GenericProvider.cs` | MonoBehaviour 组件 | 提供 `Generic` 所需的数据、引用、选项或运行时上下文。 |
| `GenericProviderValueChangedEvent.cs` | 委托 | 声明 `GenericProviderValueChanged` 相关事件或回调约定。 |
| `GridAccessoryPositionCalculator.cs` | MonoBehaviour 组件 | 计算 `GridAccessoryPosition` 相关位置、数值或结果。 |
| `GridController.cs` | MonoBehaviour 组件 | 控制 `Grid` 相关的界面交互、表现或流程推进。 |
| `HandCard.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `HandCard` 相关的场景逻辑、表现或交互。 |
| `HandCardPositionCalculator.cs` | 类 | 计算 `HandCardPosition` 相关位置、数值或结果。 |
| `HandCardStaggerer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `HandCardStaggerer` 相关的场景逻辑、表现或交互。 |
| `HandshakeMessageEvent.cs` | 委托 | 声明 `HandshakeMessage` 相关事件或回调约定。 |
| `HideWindowAction.cs` | 类 | 封装 `HideWindow` 相关的可执行动作或状态机步骤。 |
| `HighlightOwnedGameObj.cs` | 类 | 封装 `HighlightOwnedGameObj` 相关的核心数据结构或功能逻辑。 |
| `HomeSceneInitializer.cs` | MonoBehaviour 组件 | 执行 `HomeScene` 的初始化与启动准备。 |
| `HomeSceneWindowController.cs` | MonoBehaviour 组件 | 控制 `HomeScene` 窗口的展示、关闭与内部流程。 |
| `HomeWindowController.cs` | MonoBehaviour 组件 | 控制 `Home` 窗口的展示、关闭与内部流程。 |
| `HostEvent.cs` | 委托 | 声明 `Host` 相关事件或回调约定。 |
| `HostPinger.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `HostPinger` 相关的场景逻辑、表现或交互。 |
| `HostWindowButtonController.cs` | MonoBehaviour 组件 | 控制 `HostWindow` 按钮的行为与交互反馈。 |
| `HostWindowController.cs` | 类 | 控制 `Host` 窗口的展示、关闭与内部流程。 |
| `HourglassScript.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `HourglassScript` 相关的场景逻辑、表现或交互。 |
| `IabEvent.cs` | 委托 | 声明 `Iab` 相关事件或回调约定。 |
| `IapButtonLabelUpdater.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `IapButtonLabelUpdater` 相关的场景逻辑、表现或交互。 |
| `IconController.cs` | MonoBehaviour 组件 | 控制 `Icon` 相关的界面交互、表现或流程推进。 |
| `IInitializable.cs` | 接口 | 承载 `IInitializable` 相关逻辑。 |
| `IMessageClient.cs` | 接口 | 承载 `IMessageClient` 相关逻辑。 |
| `IModal.cs` | 接口 | 提供 `I` 相关的弹窗界面与交互逻辑。 |
| `InAppPurchaseController.cs` | MonoBehaviour 组件 | 控制 `InAppPurchase` 相关的界面交互、表现或流程推进。 |
| `InAppPurchaseRequest.cs` | 类 | 封装 `InAppPurchaseRequest` 相关的核心数据结构或功能逻辑。 |
| `IncrementWidgetDepthAction.cs` | 类 | 封装 `IncrementWidgetDepth` 相关的可执行动作或状态机步骤。 |
| `InitializablePrefabFactory.cs` | MonoBehaviour 组件 | 负责创建 `InitializablePrefab` 相关对象、组件或界面实例。 |
| `InnocuousWordRepository.cs` | MonoBehaviour 组件 | 负责 `InnocuousWord` 相关数据的读取、缓存或查询。 |
| `InputToEvent.cs` | MonoBehaviour 组件 | 声明 `InputTo` 相关事件或回调约定。 |
| `InRoomChat.cs` | 类 | 封装 `InRoomChat` 相关的核心数据结构或功能逻辑。 |
| `InRoomRoundTimer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `InRoomRoundTimer` 相关的场景逻辑、表现或交互。 |
| `InRoomTime.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `InRoomTime` 相关的场景逻辑、表现或交互。 |
| `IntegerRadioOption.cs` | 类 | 封装 `IntegerRadioOption` 相关的核心数据结构或功能逻辑。 |
| `IntegerValueRadioButton.cs` | 类 | 实现 `IntegerValue` 单选按钮逻辑。 |
| `InternetGameStarter.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `InternetGameStarter` 相关的场景逻辑、表现或交互。 |
| `InternetLobbyAvatarGridController.cs` | MonoBehaviour 组件 | 控制 `InternetLobbyAvatarGrid` 相关的界面交互、表现或流程推进。 |
| `IntIntEvent.cs` | 委托 | 声明 `IntInt` 相关事件或回调约定。 |
| `InventoryAvatar.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `InventoryAvatar` 相关的场景逻辑、表现或交互。 |
| `InventoryAvatarFactory.cs` | MonoBehaviour 组件 | 负责创建 `InventoryAvatar` 相关对象、组件或界面实例。 |
| `InventoryAvatarGridController.cs` | 类 | 控制 `InventoryAvatarGrid` 相关的界面交互、表现或流程推进。 |
| `InventoryErrorEvent.cs` | 委托 | 声明 `InventoryError` 相关事件或回调约定。 |
| `InventoryLoadEvent.cs` | 委托 | 声明 `InventoryLoad` 相关事件或回调约定。 |
| `IPhoneXScaler.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `IPhoneXScaler` 相关的场景逻辑、表现或交互。 |
| `IPlayerInterface.cs` | 接口 | 承载 `IPlayerInterface` 相关逻辑。 |
| `IPunCallbacks.cs` | 接口 | 承载 `IPunCallbacks` 相关逻辑。 |
| `IPunObservable.cs` | 接口 | 承载 `IPunObservable` 相关逻辑。 |
| `IPunPrefabPool.cs` | 接口 | 承载 `IPunPrefabPool` 相关逻辑。 |
| `IPunTurnManagerCallbacks.cs` | 接口 | 承载 `IPunTurnManagerCallbacks` 相关逻辑。 |
| `ISkeletonAnimation.cs` | 接口 | 实现 `ISkeleton` 的动画逻辑。 |
| `JoinMode.cs` | 枚举 | 定义 `Join` 的模式选项。 |
| `JoinRandomInternetGameWindowController.cs` | 类 | 控制 `JoinRandomInternetGame` 窗口的展示、关闭与内部流程。 |
| `JoinType.cs` | 枚举 | 定义 `Join` 的类型枚举或分类。 |
| `JoinWindowController.cs` | 类 | 控制 `Join` 窗口的展示、关闭与内部流程。 |
| `JuicyThing.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `JuicyThing` 相关的场景逻辑、表现或交互。 |
| `Jukebox.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `Jukebox` 相关的场景逻辑、表现或交互。 |
| `KittenMeter.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `KittenMeter` 相关的场景逻辑、表现或交互。 |
| `KittenMeterAnimator.cs` | MonoBehaviour 组件 | 驱动 `KittenMeter` 的动画表现。 |
| `KittenMeterBean.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `KittenMeterBean` 相关的场景逻辑、表现或交互。 |
| `KittenMeterBeanAnimator.cs` | MonoBehaviour 组件 | 驱动 `KittenMeterBean` 的动画表现。 |
| `KittenMeterBeanFactory.cs` | MonoBehaviour 组件 | 负责创建 `KittenMeterBean` 相关对象、组件或界面实例。 |
| `KittenMeterNeedleAnimator.cs` | 类 | 驱动 `KittenMeterNeedle` 的动画表现。 |
| `KittenMeterPunchAnimator.cs` | 类 | 驱动 `KittenMeterPunch` 的动画表现。 |
| `KittenMeterReadoutAnimator.cs` | 类 | 驱动 `KittenMeterReadout` 的动画表现。 |
| `KittenMeterReadoutSize.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `KittenMeterReadoutSize` 相关的场景逻辑、表现或交互。 |
| `KittenMeterShakeAnimator.cs` | 类 | 驱动 `KittenMeterShake` 的动画表现。 |
| `KittenMeterSteamAnimator.cs` | 类 | 驱动 `KittenMeterSteam` 的动画表现。 |
| `KittenRollCallController.cs` | MonoBehaviour 组件 | 控制 `KittenRollCall` 相关的界面交互、表现或流程推进。 |
| `KittensAnalytics.cs` | 类 | 封装 `KittensAnalytics` 相关的核心数据结构或功能逻辑。 |
| `KittenSwitch.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `KittenSwitch` 相关的场景逻辑、表现或交互。 |
| `LaunchMailAction.cs` | 类 | 封装 `LaunchMail` 相关的可执行动作或状态机步骤。 |
| `LeftIconHanger.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `LeftIconHanger` 相关的场景逻辑、表现或交互。 |
| `ListExtensions.cs` | 类 | 提供 `List` 相关扩展方法。 |
| `LoadBalancingPeer.cs` | 类 | 封装 `LoadBalancingPeer` 相关的核心数据结构或功能逻辑。 |
| `LobbyAvatar.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `LobbyAvatar` 相关的场景逻辑、表现或交互。 |
| `LobbyAvatarFactory.cs` | MonoBehaviour 组件 | 负责创建 `LobbyAvatar` 相关对象、组件或界面实例。 |
| `LobbyAvatarGridController.cs` | MonoBehaviour 组件 | 控制 `LobbyAvatarGrid` 相关的界面交互、表现或流程推进。 |
| `LobbyFrame.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `LobbyFrame` 相关的场景逻辑、表现或交互。 |
| `LobbyFrameBottomStyle.cs` | 枚举 | 定义 `LobbyFrameBottom` 的样式选项。 |
| `LobbyFrameEvent.cs` | 委托 | 声明 `LobbyFrame` 相关事件或回调约定。 |
| `LobbyFrameFactory.cs` | MonoBehaviour 组件 | 负责创建 `LobbyFrame` 相关对象、组件或界面实例。 |
| `LobbyFrameProvider.cs` | MonoBehaviour 组件 | 提供 `LobbyFrame` 所需的数据、引用、选项或运行时上下文。 |
| `LobbyFrozenTimeout.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `LobbyFrozenTimeout` 相关的场景逻辑、表现或交互。 |
| `LobbyFrozenTooLongEventHandler.cs` | MonoBehaviour 组件 | 监听并处理 `LobbyFrozenTooLong` 相关事件。 |
| `LobbyFrozenUiDisabler.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `LobbyFrozenUiDisabler` 相关的场景逻辑、表现或交互。 |
| `LobbyHostDisconnectionHandler.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `LobbyHostDisconnectionHandler` 相关的场景逻辑、表现或交互。 |
| `LobbyStateHashGenerator.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `LobbyStateHashGenerator` 相关的场景逻辑、表现或交互。 |
| `LobbyType.cs` | 枚举 | 定义 `Lobby` 的类型枚举或分类。 |
| `LocalMessage.cs` | 类 | 封装 `LocalMessage` 相关的核心数据结构或功能逻辑。 |
| `LocalMessageClient.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `LocalMessageClient` 相关的场景逻辑、表现或交互。 |
| `LockDifficulty.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `LockDifficulty` 相关的场景逻辑、表现或交互。 |
| `LogicalOrGateController.cs` | MonoBehaviour 组件 | 控制 `LogicalOrGate` 相关的界面交互、表现或流程推进。 |
| `LookAtCamera.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `LookAtCamera` 相关的场景逻辑、表现或交互。 |
| `MainThreadQueue.cs` | MonoBehaviour 组件 | 维护 `MainThread` 的排队、顺序或待处理集合。 |
| `ManualPhotonViewAllocator.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ManualPhotonViewAllocator` 相关的场景逻辑、表现或交互。 |
| `MarkController.cs` | MonoBehaviour 组件 | 控制 `Mark` 相关的界面交互、表现或流程推进。 |
| `MasterClientSwitchedEvent.cs` | 委托 | 声明 `MasterClientSwitched` 相关事件或回调约定。 |
| `MatchmakingMode.cs` | 枚举 | 定义 `Matchmaking` 的模式选项。 |
| `MaterialsTextureLoader.cs` | 类 | 封装 `MaterialsTextureLoader` 相关的核心数据结构或功能逻辑。 |
| `MaxPlayerCountGateController.cs` | MonoBehaviour 组件 | 控制 `MaxPlayerCountGate` 相关的界面交互、表现或流程推进。 |
| `MCPeerConnectionReadinessMonitor.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `MCPeerConnectionReadinessMonitor` 相关的场景逻辑、表现或交互。 |
| `MCPeerConnectionsMonitor.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `MCPeerConnectionsMonitor` 相关的场景逻辑、表现或交互。 |
| `MCPeerEvent.cs` | 委托 | 声明 `MCPeer` 相关事件或回调约定。 |
| `MessageBoxDisplayer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `MessageBoxDisplayer` 相关的场景逻辑、表现或交互。 |
| `MessageBoxModal.cs` | MonoBehaviour 组件 | 提供 `MessageBox` 相关的弹窗界面与交互逻辑。 |
| `MessageOfTheDay.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `MessageOfTheDay` 相关的场景逻辑、表现或交互。 |
| `MGSDebugManager.cs` | MonoBehaviour 组件 | 统一管理 `MGSDebug` 相关的状态、数据或整体流程。 |
| `MinPlayerCountGateController.cs` | MonoBehaviour 组件 | 控制 `MinPlayerCountGate` 相关的界面交互、表现或流程推进。 |
| `MobileDeviceSleepDisabler.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `MobileDeviceSleepDisabler` 相关的场景逻辑、表现或交互。 |
| `ModalAnnouncer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ModalAnnouncer` 相关的场景逻辑、表现或交互。 |
| `ModalDelegate.cs` | 委托 | 声明 `Modal` 相关的委托回调签名。 |
| `ModalQueue.cs` | MonoBehaviour 组件 | 维护 `Modal` 的排队、顺序或待处理集合。 |
| `MoveAddAction.cs` | 类 | 封装 `MoveAdd` 相关的可执行动作或状态机步骤。 |
| `MoveByKeys.cs` | 类 | 封装 `MoveByKeys` 相关的核心数据结构或功能逻辑。 |
| `MoveCardsToTopController.cs` | MonoBehaviour 组件 | 控制 `MoveCardsToTop` 相关的界面交互、表现或流程推进。 |
| `MoveFromAction.cs` | 类 | 封装 `MoveFrom` 相关的可执行动作或状态机步骤。 |
| `MovementAction.cs` | 类 | 封装 `Movement` 相关的可执行动作或状态机步骤。 |
| `MoveThroughWaypointsAction.cs` | 类 | 封装 `MoveThroughWaypoints` 相关的可执行动作或状态机步骤。 |
| `MoveToTransformAction.cs` | 类 | 封装 `MoveToTransform` 相关的可执行动作或状态机步骤。 |
| `MultipeerConnectivityBridge.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `MultipeerConnectivityBridge` 相关的场景逻辑、表现或交互。 |
| `MultipeerEvent.cs` | 委托 | 声明 `Multipeer` 相关事件或回调约定。 |
| `MultipeerGameInfo.cs` | 结构体 | 封装 `MultipeerGame` 相关信息结构。 |
| `MultipeerHostConnectionMonitor.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `MultipeerHostConnectionMonitor` 相关的场景逻辑、表现或交互。 |
| `MultipeerLobbyMessages.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `MultipeerLobbyMessages` 相关的场景逻辑、表现或交互。 |
| `MultipeerMessage.cs` | 类 | 封装 `MultipeerMessage` 相关的核心数据结构或功能逻辑。 |
| `MultipeerMessageClient.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `MultipeerMessageClient` 相关的场景逻辑、表现或交互。 |
| `MultipeerNetwork.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `MultipeerNetwork` 相关的场景逻辑、表现或交互。 |
| `MultipeerPlayerConnectionMonitor.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `MultipeerPlayerConnectionMonitor` 相关的场景逻辑、表现或交互。 |
| `MultipeerPlayerProfileUpdater.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `MultipeerPlayerProfileUpdater` 相关的场景逻辑、表现或交互。 |
| `MultitouchDisabler.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `MultitouchDisabler` 相关的场景逻辑、表现或交互。 |
| `MuteButtonController.cs` | MonoBehaviour 组件 | 控制 `Mute` 按钮的行为与交互反馈。 |
| `MyTurnTimeout.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `MyTurnTimeout` 相关的场景逻辑、表现或交互。 |
| `NagOpponent.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `NagOpponent` 相关的场景逻辑、表现或交互。 |
| `NavigationController.cs` | MonoBehaviour 组件 | 控制 `Navigation` 相关的界面交互、表现或流程推进。 |
| `NavigationMessageBoxDisplayer.cs` | 类 | 封装 `NavigationMessageBoxDisplayer` 相关的核心数据结构或功能逻辑。 |
| `NetworkCullingHandler.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `NetworkCullingHandler` 相关的场景逻辑、表现或交互。 |
| `NetworkErrorDisplayer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `NetworkErrorDisplayer` 相关的场景逻辑、表现或交互。 |
| `NetworkingPeer.cs` | 类 | 封装 `NetworkingPeer` 相关的核心数据结构或功能逻辑。 |
| `NetworkingSystem.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `NetworkingSystem` 相关的场景逻辑、表现或交互。 |
| `NetworkingType.cs` | 枚举 | 定义 `Networking` 的类型枚举或分类。 |
| `NetworkMessage.cs` | 类 | 封装 `NetworkMessage` 相关的核心数据结构或功能逻辑。 |
| `NetworkMessageRouter.cs` | 类 | 封装 `NetworkMessageRouter` 相关的核心数据结构或功能逻辑。 |
| `NewCardAnimation.cs` | MonoBehaviour 组件 | 实现 `NewCard` 的动画逻辑。 |
| `NewFeatureBadgeController.cs` | MonoBehaviour 组件 | 控制 `NewFeatureBadge` 相关的界面交互、表现或流程推进。 |
| `NextDrawnCardProvider.cs` | MonoBehaviour 组件 | 提供 `NextDrawnCard` 所需的数据、引用、选项或运行时上下文。 |
| `NextTutorialStepAction.cs` | 类 | 封装 `NextTutorialStep` 相关的可执行动作或状态机步骤。 |
| `NGUIToolsExtensions.cs` | 类 | 提供 `NGUITools` 相关扩展方法。 |
| `NoisyButton.cs` | MonoBehaviour 组件 | 实现 `Noisy` 按钮的交互或表现逻辑。 |
| `NumberAnimationAction.cs` | 类 | 封装 `NumberAnimation` 相关的可执行动作或状态机步骤。 |
| `ObservableBool.cs` | 类 | 封装 `ObservableBool` 相关的核心数据结构或功能逻辑。 |
| `ObservableBoolEvent.cs` | 委托 | 声明 `ObservableBool` 相关事件或回调约定。 |
| `OnAwakeUsePhotonView.cs` | 类 | 封装 `OnAwakeUsePhotonView` 相关的核心数据结构或功能逻辑。 |
| `OnClickDestroy.cs` | 类 | 封装 `OnClickDestroy` 相关的核心数据结构或功能逻辑。 |
| `OnClickInstantiate.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OnClickInstantiate` 相关的场景逻辑、表现或交互。 |
| `OnClickTrigger.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OnClickTrigger` 相关的场景逻辑、表现或交互。 |
| `OnDisableCallback.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OnDisableCallback` 相关的场景逻辑、表现或交互。 |
| `OnEnableCallback.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OnEnableCallback` 相关的场景逻辑、表现或交互。 |
| `OneShotAudioPlayer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OneShotAudioPlayer` 相关的场景逻辑、表现或交互。 |
| `OnJoinedInstantiate.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OnJoinedInstantiate` 相关的场景逻辑、表现或交互。 |
| `OnOpponentDrawCardPlaySound.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OnOpponentDrawCardPlaySound` 相关的场景逻辑、表现或交互。 |
| `OnOpponentDrawExplodingKittenPlaySound.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OnOpponentDrawExplodingKittenPlaySound` 相关的场景逻辑、表现或交互。 |
| `OnPlayCardAnimation.cs` | MonoBehaviour 组件 | 实现 `OnPlayCard` 的动画逻辑。 |
| `OnPlayerTimeout.cs` | 委托 | 声明 `OnPlayerTimeout` 对应的事件回调签名。 |
| `OnPressAndHoldTimer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OnPressAndHoldTimer` 相关的场景逻辑、表现或交互。 |
| `OnPressAndHoldTrigger.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OnPressAndHoldTrigger` 相关的场景逻辑、表现或交互。 |
| `OnPressAndTriggerOnHold.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OnPressAndTriggerOnHold` 相关的场景逻辑、表现或交互。 |
| `OnReceiveCardFromPlayerPlaySound.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OnReceiveCardFromPlayerPlaySound` 相关的场景逻辑、表现或交互。 |
| `OnSerializeRigidBody.cs` | 枚举 | 定义 `OnSerializeRigidBody` 的枚举选项或状态分类。 |
| `OnSerializeTransform.cs` | 枚举 | 定义 `OnSerializeTransform` 的枚举选项或状态分类。 |
| `OnStartDelete.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OnStartDelete` 相关的场景逻辑、表现或交互。 |
| `OpenGameGridItem.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OpenGameGridItem` 相关的场景逻辑、表现或交互。 |
| `OpenIabAnalyticsRecorder.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OpenIabAnalyticsRecorder` 相关的场景逻辑、表现或交互。 |
| `OpenIabInitializer.cs` | MonoBehaviour 组件 | 执行 `OpenIab` 的初始化与启动准备。 |
| `OpenIabInventoryLoader.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OpenIabInventoryLoader` 相关的场景逻辑、表现或交互。 |
| `OpenIabPurchaseRestorer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OpenIabPurchaseRestorer` 相关的场景逻辑、表现或交互。 |
| `OperationCode.cs` | 类 | 封装 `OperationCode` 相关的核心数据结构或功能逻辑。 |
| `OpJoinRandomRoomParams.cs` | 类 | 封装 `OpJoinRandomRoomParams` 相关的核心数据结构或功能逻辑。 |
| `OpponentAvatarMenuModal.cs` | MonoBehaviour 组件 | 提供 `OpponentAvatarMenu` 相关的弹窗界面与交互逻辑。 |
| `OpponentAvatarPopulator.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OpponentAvatarPopulator` 相关的场景逻辑、表现或交互。 |
| `OpponentAvatarSelector.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OpponentAvatarSelector` 相关的场景逻辑、表现或交互。 |
| `OpponentAvatarsProvider.cs` | 类 | 提供 `OpponentAvatars` 所需的数据、引用、选项或运行时上下文。 |
| `OpponentDefusableKittenController.cs` | MonoBehaviour 组件 | 控制 `OpponentDefusableKitten` 相关的界面交互、表现或流程推进。 |
| `OpponentDiscardController.cs` | MonoBehaviour 组件 | 控制 `OpponentDiscard` 相关的界面交互、表现或流程推进。 |
| `OpponentExplodedEventHandler.cs` | MonoBehaviour 组件 | 监听并处理 `OpponentExploded` 相关事件。 |
| `OpponentExplodedModal.cs` | MonoBehaviour 组件 | 提供 `OpponentExploded` 相关的弹窗界面与交互逻辑。 |
| `OpponentExplodedModalFacts.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OpponentExplodedModalFacts` 相关的场景逻辑、表现或交互。 |
| `OpponentHand.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OpponentHand` 相关的场景逻辑、表现或交互。 |
| `OpponentPlayerAvatar.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OpponentPlayerAvatar` 相关的场景逻辑、表现或交互。 |
| `OpponentPlayerAvatarFactory.cs` | MonoBehaviour 组件 | 负责创建 `OpponentPlayerAvatar` 相关对象、组件或界面实例。 |
| `OpponentSleepHandler.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `OpponentSleepHandler` 相关的场景逻辑、表现或交互。 |
| `OwnershipOption.cs` | 枚举 | 定义 `OwnershipOption` 的枚举选项或状态分类。 |
| `PageWindowAction.cs` | 类 | 封装 `PageWindow` 相关的可执行动作或状态机步骤。 |
| `ParameterCode.cs` | 类 | 封装 `ParameterCode` 相关的核心数据结构或功能逻辑。 |
| `PeerConnectionReadinessEvent.cs` | 委托 | 声明 `PeerConnectionReadiness` 相关事件或回调约定。 |
| `PhotonAnimatorView.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PhotonAnimatorView` 相关的场景逻辑、表现或交互。 |
| `PhotonCcuLimitReachedHandler.cs` | 类 | 封装 `PhotonCcuLimitReachedHandler` 相关的核心数据结构或功能逻辑。 |
| `PhotonClientStatusUpdater.cs` | 类 | 封装 `PhotonClientStatusUpdater` 相关的核心数据结构或功能逻辑。 |
| `PhotonConnectionAdapter.cs` | 类 | 封装 `PhotonConnectionAdapter` 相关的核心数据结构或功能逻辑。 |
| `PhotonConnectionMonitor.cs` | 类 | 封装 `PhotonConnectionMonitor` 相关的核心数据结构或功能逻辑。 |
| `PhotonDeckChangeNotificationAction.cs` | 类 | 封装 `PhotonDeckChangeNotification` 相关的可执行动作或状态机步骤。 |
| `PhotonGameMessages.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PhotonGameMessages` 相关的场景逻辑、表现或交互。 |
| `PhotonHandler.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PhotonHandler` 相关的场景逻辑、表现或交互。 |
| `PhotonLagSimulationGui.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PhotonLagSimulationGui` 相关的场景逻辑、表现或交互。 |
| `PhotonLogLevel.cs` | 枚举 | 定义 `PhotonLogLevel` 的枚举选项或状态分类。 |
| `PhotonMasterClientSwitchedHandler.cs` | 类 | 封装 `PhotonMasterClientSwitchedHandler` 相关的核心数据结构或功能逻辑。 |
| `PhotonMessage.cs` | 类 | 封装 `PhotonMessage` 相关的核心数据结构或功能逻辑。 |
| `PhotonMessageClient.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PhotonMessageClient` 相关的场景逻辑、表现或交互。 |
| `PhotonMessageInfo.cs` | 结构体 | 封装 `PhotonMessage` 相关信息结构。 |
| `PhotonNetwork.cs` | 类 | 封装 `PhotonNetwork` 相关的核心数据结构或功能逻辑。 |
| `PhotonNetworkDownHandler.cs` | 类 | 封装 `PhotonNetworkDownHandler` 相关的核心数据结构或功能逻辑。 |
| `PhotonNetworkingMessage.cs` | 枚举 | 定义 `PhotonNetworkingMessage` 的枚举选项或状态分类。 |
| `PhotonPingManager.cs` | 类 | 统一管理 `PhotonPing` 相关的状态、数据或整体流程。 |
| `PhotonPlayer.cs` | 类 | 封装 `PhotonPlayer` 相关的核心数据结构或功能逻辑。 |
| `PhotonPlayerConnectionHandler.cs` | 类 | 封装 `PhotonPlayerConnectionHandler` 相关的核心数据结构或功能逻辑。 |
| `PhotonPlayerDisconnectionHandler.cs` | 类 | 封装 `PhotonPlayerDisconnectionHandler` 相关的核心数据结构或功能逻辑。 |
| `PhotonPlayerDisconnectionMonitor.cs` | 类 | 封装 `PhotonPlayerDisconnectionMonitor` 相关的核心数据结构或功能逻辑。 |
| `PhotonPlayerProfileUpdateHandler.cs` | 类 | 封装 `PhotonPlayerProfileUpdateHandler` 相关的核心数据结构或功能逻辑。 |
| `PhotonPlayerProfileUpdater.cs` | 类 | 封装 `PhotonPlayerProfileUpdater` 相关的核心数据结构或功能逻辑。 |
| `PhotonRandomRoomJoinHandler.cs` | 类 | 封装 `PhotonRandomRoomJoinHandler` 相关的核心数据结构或功能逻辑。 |
| `PhotonRigidbody2DView.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PhotonRigidbody2DView` 相关的场景逻辑、表现或交互。 |
| `PhotonRigidbodyView.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PhotonRigidbodyView` 相关的场景逻辑、表现或交互。 |
| `PhotonRoomCodeDisplayFormatter.cs` | 类 | 封装 `PhotonRoomCodeDisplayFormatter` 相关的核心数据结构或功能逻辑。 |
| `PhotonRoomCodeGenerator.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PhotonRoomCodeGenerator` 相关的场景逻辑、表现或交互。 |
| `PhotonRoomFactory.cs` | 类 | 负责创建 `PhotonRoom` 相关对象、组件或界面实例。 |
| `PhotonRoomJoinHandler.cs` | 类 | 封装 `PhotonRoomJoinHandler` 相关的核心数据结构或功能逻辑。 |
| `PhotonRoomOptionsFactory.cs` | 类 | 负责创建 `PhotonRoomOptions` 相关对象、组件或界面实例。 |
| `PhotonRoomPropertyChangedHandler.cs` | 类 | 封装 `PhotonRoomPropertyChangedHandler` 相关的核心数据结构或功能逻辑。 |
| `PhotonSettings.cs` | MonoBehaviour 组件 | 保存 `Photon` 相关设置。 |
| `PhotonStatsGui.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PhotonStatsGui` 相关的场景逻辑、表现或交互。 |
| `PhotonStream.cs` | 类 | 维护 `Photon` 数据流、展示流或事件流。 |
| `PhotonStreamQueue.cs` | 类 | 维护 `PhotonStream` 的排队、顺序或待处理集合。 |
| `PhotonTargets.cs` | 枚举 | 定义 `PhotonTargets` 的枚举选项或状态分类。 |
| `PhotonTransformView.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PhotonTransformView` 相关的场景逻辑、表现或交互。 |
| `PhotonTransformViewPositionControl.cs` | 类 | 封装 `PhotonTransformViewPositionControl` 相关的核心数据结构或功能逻辑。 |
| `PhotonTransformViewPositionModel.cs` | 类 | 封装 `PhotonTransformViewPositionModel` 相关的核心数据结构或功能逻辑。 |
| `PhotonTransformViewRotationControl.cs` | 类 | 封装 `PhotonTransformViewRotationControl` 相关的核心数据结构或功能逻辑。 |
| `PhotonTransformViewRotationModel.cs` | 类 | 封装 `PhotonTransformViewRotationModel` 相关的核心数据结构或功能逻辑。 |
| `PhotonTransformViewScaleControl.cs` | 类 | 封装 `PhotonTransformViewScaleControl` 相关的核心数据结构或功能逻辑。 |
| `PhotonTransformViewScaleModel.cs` | 类 | 封装 `PhotonTransformViewScaleModel` 相关的核心数据结构或功能逻辑。 |
| `PhotonView.cs` | 类 | 封装 `PhotonView` 相关的核心数据结构或功能逻辑。 |
| `PickupItem.cs` | 类 | 封装 `PickupItem` 相关的核心数据结构或功能逻辑。 |
| `PickupItemSimple.cs` | 类 | 封装 `PickupItemSimple` 相关的核心数据结构或功能逻辑。 |
| `PickupItemSyncer.cs` | 类 | 封装 `PickupItemSyncer` 相关的核心数据结构或功能逻辑。 |
| `PinEntryModal.cs` | 类 | 提供 `PinEntry` 相关的弹窗界面与交互逻辑。 |
| `PlatformSpecificDisabler.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PlatformSpecificDisabler` 相关的场景逻辑、表现或交互。 |
| `Player.cs` | 类 | 封装 `Player` 相关的核心数据结构或功能逻辑。 |
| `PlayerAttackDelegate.cs` | 委托 | 声明 `PlayerAttack` 相关的委托回调签名。 |
| `PlayerAvatar.cs` | 类 | 封装 `PlayerAvatar` 相关的核心数据结构或功能逻辑。 |
| `PlayerAvatarCycler.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PlayerAvatarCycler` 相关的场景逻辑、表现或交互。 |
| `PlayerAvatarEvent.cs` | 委托 | 声明 `PlayerAvatar` 相关事件或回调约定。 |
| `PlayerAvatarLabelController.cs` | MonoBehaviour 组件 | 控制 `PlayerAvatarLabel` 相关的界面交互、表现或流程推进。 |
| `PlayerAvatarProvider.cs` | MonoBehaviour 组件 | 提供 `PlayerAvatar` 所需的数据、引用、选项或运行时上下文。 |
| `PlayerAvatarRepository.cs` | MonoBehaviour 组件 | 负责 `PlayerAvatar` 相关数据的读取、缓存或查询。 |
| `PlayerCardCardDelegate.cs` | 委托 | 声明 `PlayerCardCard` 相关的委托回调签名。 |
| `PlayerCardDelegate.cs` | 委托 | 声明 `PlayerCard` 相关的委托回调签名。 |
| `PlayerCardsDelegate.cs` | 委托 | 声明 `PlayerCards` 相关的委托回调签名。 |
| `PlayerCountLabelUpdater.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PlayerCountLabelUpdater` 相关的场景逻辑、表现或交互。 |
| `PlayerCountValidator.cs` | 类 | 校验 `PlayerCount` 是否满足版本、规则或输入要求。 |
| `PlayerDefuseDelegate.cs` | 委托 | 声明 `PlayerDefuse` 相关的委托回调签名。 |
| `PlayerDelegate.cs` | 委托 | 声明 `Player` 相关的委托回调签名。 |
| `PlayerEmoteDelegate.cs` | 委托 | 声明 `PlayerEmote` 相关的委托回调签名。 |
| `PlayerEndTurnMonitor.cs` | 类 | 封装 `PlayerEndTurnMonitor` 相关的核心数据结构或功能逻辑。 |
| `PlayerExplodedEventHandler.cs` | MonoBehaviour 组件 | 监听并处理 `PlayerExploded` 相关事件。 |
| `PlayerFactory.cs` | MonoBehaviour 组件 | 负责创建 `Player` 相关对象、组件或界面实例。 |
| `PlayerHand.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PlayerHand` 相关的场景逻辑、表现或交互。 |
| `PlayerHandDropTarget.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PlayerHandDropTarget` 相关的场景逻辑、表现或交互。 |
| `PlayerHealthMonitor.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PlayerHealthMonitor` 相关的场景逻辑、表现或交互。 |
| `PlayerHud.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PlayerHud` 相关的场景逻辑、表现或交互。 |
| `PlayerHudDisabler.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PlayerHudDisabler` 相关的场景逻辑、表现或交互。 |
| `PlayerHudFactory.cs` | MonoBehaviour 组件 | 负责创建 `PlayerHud` 相关对象、组件或界面实例。 |
| `PlayerIdGenerator.cs` | 类 | 封装 `PlayerIdGenerator` 相关的核心数据结构或功能逻辑。 |
| `PlayerIntDelegate.cs` | 委托 | 声明 `PlayerInt` 相关的委托回调签名。 |
| `PlayerInterfaceRepository.cs` | MonoBehaviour 组件 | 负责 `PlayerInterface` 相关数据的读取、缓存或查询。 |
| `PlayerListDelegate.cs` | 委托 | 声明 `PlayerList` 相关的委托回调签名。 |
| `PlayerNameChangeEvent.cs` | 委托 | 声明 `PlayerNameChange` 相关事件或回调约定。 |
| `PlayerNameInputController.cs` | MonoBehaviour 组件 | 控制 `PlayerNameInput` 相关的界面交互、表现或流程推进。 |
| `PlayerNameMissingTransformer.cs` | 类 | 转换 `PlayerNameMissing` 输入、格式或表现形式。 |
| `PlayerPhase.cs` | 枚举 | 定义 `PlayerPhase` 的枚举选项或状态分类。 |
| `PlayerPhaseDelegate.cs` | 委托 | 声明 `PlayerPhase` 相关的委托回调签名。 |
| `PlayerPlayerAvatarDelegate.cs` | 委托 | 声明 `PlayerPlayerAvatar` 相关的委托回调签名。 |
| `PlayerPlayerCardCallbackDelegate.cs` | 委托 | 声明 `PlayerPlayerCardCallback` 相关的委托回调签名。 |
| `PlayerPlayerCardDelegate.cs` | 委托 | 声明 `PlayerPlayerCard` 相关的委托回调签名。 |
| `PlayerPrefsToggle.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PlayerPrefsToggle` 相关的场景逻辑、表现或交互。 |
| `PlayerProfileAvatar.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PlayerProfileAvatar` 相关的场景逻辑、表现或交互。 |
| `PlayerProfileAvatarFactory.cs` | 类 | 负责创建 `PlayerProfileAvatar` 相关对象、组件或界面实例。 |
| `PlayerProfileAvatarLabelController.cs` | MonoBehaviour 组件 | 控制 `PlayerProfileAvatarLabel` 相关的界面交互、表现或流程推进。 |
| `PlayerProfileSettings.cs` | MonoBehaviour 组件 | 保存 `PlayerProfile` 相关设置。 |
| `PlayerProvider.cs` | 类 | 提供 `Player` 所需的数据、引用、选项或运行时上下文。 |
| `PlayerRadioButton.cs` | 类 | 实现 `Player` 单选按钮逻辑。 |
| `PlayerReadinessMonitor.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PlayerReadinessMonitor` 相关的场景逻辑、表现或交互。 |
| `PlayerReadyGateController.cs` | MonoBehaviour 组件 | 控制 `PlayerReadyGate` 相关的界面交互、表现或流程推进。 |
| `PlayerRepository.cs` | MonoBehaviour 组件 | 负责 `Player` 相关数据的读取、缓存或查询。 |
| `PlayersLeftDataProvider.cs` | 类 | 为界面或流程提供 `PlayersLeft` 相关数据。 |
| `PlayersReadyEventDelegate.cs` | 委托 | 声明 `PlayersReadyEvent` 相关的委托回调签名。 |
| `PlayerStats.cs` | 类 | 记录 `Player` 相关统计结果。 |
| `PlayerTimeout.cs` | 类 | 封装 `PlayerTimeout` 相关的核心数据结构或功能逻辑。 |
| `PlayerToPlayerBannerMetadataFactory.cs` | 类 | 构建 `PlayerToPlayerBanner` 相关的元数据对象。 |
| `PlayOneShotAudioAction.cs` | 类 | 封装 `PlayOneShotAudio` 相关的可执行动作或状态机步骤。 |
| `PlayParticlesAction.cs` | 类 | 封装 `PlayParticles` 相关的可执行动作或状态机步骤。 |
| `PlaySinglePlayer.cs` | 类 | 封装 `PlaySinglePlayer` 相关的核心数据结构或功能逻辑。 |
| `PointedAtGameObjectInfo.cs` | MonoBehaviour 组件 | 封装 `PointedAtGameObject` 相关信息结构。 |
| `PopLastWindowAction.cs` | 类 | 封装 `PopLastWindow` 相关的可执行动作或状态机步骤。 |
| `PopToRootWindowAction.cs` | 类 | 封装 `PopToRootWindow` 相关的可执行动作或状态机步骤。 |
| `PopWindowOrQuitApplicationAction.cs` | 类 | 封装 `PopWindowOrQuitApplication` 相关的可执行动作或状态机步骤。 |
| `PotLuckController.cs` | MonoBehaviour 组件 | 控制 `PotLuck` 相关的界面交互、表现或流程推进。 |
| `PotLuckModal.cs` | MonoBehaviour 组件 | 提供 `PotLuck` 相关的弹窗界面与交互逻辑。 |
| `PresentModallyAction.cs` | 类 | 封装 `PresentModally` 相关的可执行动作或状态机步骤。 |
| `PriceFinder.cs` | 类 | 封装 `PriceFinder` 相关的核心数据结构或功能逻辑。 |
| `PrivateInternetGameWindowController.cs` | 类 | 控制 `PrivateInternetGame` 窗口的展示、关闭与内部流程。 |
| `PromotionalPlayOffer.cs` | 类 | 封装 `PromotionalPlayOffer` 相关的核心数据结构或功能逻辑。 |
| `PromotionalPlayOfferController.cs` | MonoBehaviour 组件 | 控制 `PromotionalPlayOffer` 相关的界面交互、表现或流程推进。 |
| `PromotionalPlayOfferProvider.cs` | MonoBehaviour 组件 | 提供 `PromotionalPlayOffer` 所需的数据、引用、选项或运行时上下文。 |
| `PropertyTypeFlag.cs` | 枚举 | 定义 `PropertyTypeFlag` 的枚举选项或状态分类。 |
| `PulsingThing.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PulsingThing` 相关的场景逻辑、表现或交互。 |
| `PunchAction.cs` | 类 | 封装 `Punch` 相关的可执行动作或状态机步骤。 |
| `PunError.cs` | 类 | 封装 `PunError` 相关的核心数据结构或功能逻辑。 |
| `PunErrorEvent.cs` | 委托 | 声明 `PunError` 相关事件或回调约定。 |
| `PunEvent.cs` | 类 | 声明 `Pun` 相关事件或回调约定。 |
| `PunEventBridge.cs` | 类 | 封装 `PunEventBridge` 相关的核心数据结构或功能逻辑。 |
| `PunPlayerEvent.cs` | 委托 | 声明 `PunPlayer` 相关事件或回调约定。 |
| `PunPlayerScores.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PunPlayerScores` 相关的场景逻辑、表现或交互。 |
| `PunRPC.cs` | 类 | 封装 `PunRPC` 相关的核心数据结构或功能逻辑。 |
| `PunTeams.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PunTeams` 相关的场景逻辑、表现或交互。 |
| `PunTurnManager.cs` | 类 | 统一管理 `PunTurn` 相关的状态、数据或整体流程。 |
| `PurchasableDeckButton.cs` | MonoBehaviour 组件 | 实现 `PurchasableDeck` 按钮的交互或表现逻辑。 |
| `PurchasableProduct.cs` | 类 | 封装 `PurchasableProduct` 相关的核心数据结构或功能逻辑。 |
| `PurchasableProductRepository.cs` | MonoBehaviour 组件 | 负责 `PurchasableProduct` 相关数据的读取、缓存或查询。 |
| `PurchaseAvatarModal.cs` | MonoBehaviour 组件 | 提供 `PurchaseAvatar` 相关的弹窗界面与交互逻辑。 |
| `PurchasePopUp.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `PurchasePopUp` 相关的场景逻辑、表现或交互。 |
| `Purchaser.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `Purchaser` 相关的场景逻辑、表现或交互。 |
| `PushPrivateInternetGameLobbyAction.cs` | 类 | 封装 `PushPrivateInternetGameLobby` 相关的可执行动作或状态机步骤。 |
| `PushWindowAction.cs` | 类 | 封装 `PushWindow` 相关的可执行动作或状态机步骤。 |
| `QualitySettingDecreaser.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `QualitySettingDecreaser` 相关的场景逻辑、表现或交互。 |
| `QuitOnEscapeOrBack.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `QuitOnEscapeOrBack` 相关的场景逻辑、表现或交互。 |
| `RadioButton.cs` | MonoBehaviour 组件 | 实现 `RadioButton` 单选按钮逻辑。 |
| `RadioButtonDelegate.cs` | 委托 | 声明 `RadioButton` 相关的委托回调签名。 |
| `RadioOption.cs` | 类 | 封装 `RadioOption` 相关的核心数据结构或功能逻辑。 |
| `RaiseEventOptions.cs` | 类 | 封装 `RaiseEventOptions` 相关的核心数据结构或功能逻辑。 |
| `RandomAction.cs` | 类 | 封装 `Random` 相关的可执行动作或状态机步骤。 |
| `RandomInternetGameCountdownController.cs` | MonoBehaviour 组件 | 控制 `RandomInternetGameCountdown` 相关的界面交互、表现或流程推进。 |
| `RandomKittenInserter.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `RandomKittenInserter` 相关的场景逻辑、表现或交互。 |
| `RandomRotationAction.cs` | 类 | 封装 `RandomRotation` 相关的可执行动作或状态机步骤。 |
| `RatePopupLauncher.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `RatePopupLauncher` 相关的场景逻辑、表现或交互。 |
| `ReceiverGroup.cs` | 枚举 | 定义 `ReceiverGroup` 的枚举选项或状态分类。 |
| `RecenterTwoWidgets.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `RecenterTwoWidgets` 相关的场景逻辑、表现或交互。 |
| `RecolorWidgetAction.cs` | 类 | 封装 `RecolorWidget` 相关的可执行动作或状态机步骤。 |
| `RecordGameStartedAnalyticsAction.cs` | 类 | 封装 `RecordGameStartedAnalytics` 相关的可执行动作或状态机步骤。 |
| `Region.cs` | 类 | 封装 `Region` 相关的核心数据结构或功能逻辑。 |
| `ReloadSinglePlayer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ReloadSinglePlayer` 相关的场景逻辑、表现或交互。 |
| `RematchGameAction.cs` | 类 | 封装 `RematchGame` 相关的可执行动作或状态机步骤。 |
| `RematchGamePlayerState.cs` | 枚举 | 描述 `RematchGamePlayer` 的状态结构或状态枚举。 |
| `RematchHider.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `RematchHider` 相关的场景逻辑、表现或交互。 |
| `RenderQueueChanger.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `RenderQueueChanger` 相关的场景逻辑、表现或交互。 |
| `ResetScroll.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ResetScroll` 相关的场景逻辑、表现或交互。 |
| `ResizeWidgetAction.cs` | 类 | 封装 `ResizeWidget` 相关的可执行动作或状态机步骤。 |
| `RestorePurchaseErrorEvent.cs` | 委托 | 声明 `RestorePurchaseError` 相关事件或回调约定。 |
| `RestorePurchaseEvent.cs` | 委托 | 声明 `RestorePurchase` 相关事件或回调约定。 |
| `RestorePurchasesButtonController.cs` | MonoBehaviour 组件 | 控制 `RestorePurchases` 按钮的行为与交互反馈。 |
| `ReverseController.cs` | MonoBehaviour 组件 | 控制 `Reverse` 相关的界面交互、表现或流程推进。 |
| `Room.cs` | 类 | 封装 `Room` 相关的核心数据结构或功能逻辑。 |
| `RoomInfo.cs` | 类 | 封装 `Room` 相关信息结构。 |
| `RoomOptions.cs` | 类 | 封装 `RoomOptions` 相关的核心数据结构或功能逻辑。 |
| `RotateByAction.cs` | 类 | 封装 `RotateBy` 相关的可执行动作或状态机步骤。 |
| `RotationAction.cs` | 类 | 封装 `Rotation` 相关的可执行动作或状态机步骤。 |
| `SA_Config.cs` | 类 | 保存 `SA_` 相关的配置项。 |
| `SA_DataConverter.cs` | 类 | 封装 `SA_DataConverter` 相关的核心数据结构或功能逻辑。 |
| `SA_EaseType.cs` | 枚举 | 定义 `SA_Ease` 的类型枚举或分类。 |
| `SA_Gameobject.cs` | 类 | 封装 `SA_Gameobject` 相关的核心数据结构或功能逻辑。 |
| `SA_IdFactory.cs` | 类 | 负责创建 `SA_Id` 相关对象、组件或界面实例。 |
| `SA_ModulesInfo.cs` | 类 | 封装 `SA_Modules` 相关信息结构。 |
| `SA_NonMonoSingleton.cs` | 类 | 封装 `SA_NonMonoSingleton` 相关的核心数据结构或功能逻辑。 |
| `SA_PrefabAsyncLoader.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SA_PrefabAsyncLoader` 相关的场景逻辑、表现或交互。 |
| `SA_ScreenShotMaker.cs` | 类 | 封装 `SA_ScreenShotMaker` 相关的核心数据结构或功能逻辑。 |
| `SA_Singleton.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SA_Singleton` 相关的场景逻辑、表现或交互。 |
| `SA_TweenedGameobject.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SA_TweenedGameobject` 相关的场景逻辑、表现或交互。 |
| `SA_TweenExtensions.cs` | 类 | 提供 `SA_Tween` 相关扩展方法。 |
| `SA_ValuesTween.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SA_ValuesTween` 相关的场景逻辑、表现或交互。 |
| `SA_WWWTextureLoader.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SA_WWWTextureLoader` 相关的场景逻辑、表现或交互。 |
| `SaleScript.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SaleScript` 相关的场景逻辑、表现或交互。 |
| `ScaleAction.cs` | 类 | 封装 `Scale` 相关的可执行动作或状态机步骤。 |
| `ScaleFromAction.cs` | 类 | 封装 `ScaleFrom` 相关的可执行动作或状态机步骤。 |
| `SceneManagerHelper.cs` | 类 | 封装 `SceneManagerHelper` 相关的核心数据结构或功能逻辑。 |
| `SceneTransitioner.cs` | MonoBehaviour 组件 | 处理 `Scene` 切换、过渡或转场流程。 |
| `ScoreExtensions.cs` | 类 | 提供 `Score` 相关扩展方法。 |
| `ScrollMaterialOffsetAction.cs` | 类 | 封装 `ScrollMaterialOffset` 相关的可执行动作或状态机步骤。 |
| `SeeTheFutureController.cs` | MonoBehaviour 组件 | 控制 `SeeTheFuture` 相关的界面交互、表现或流程推进。 |
| `SeeTheFutureEventHandler.cs` | MonoBehaviour 组件 | 监听并处理 `SeeTheFuture` 相关事件。 |
| `SeeTheFutureModal.cs` | MonoBehaviour 组件 | 提供 `SeeTheFuture` 相关的弹窗界面与交互逻辑。 |
| `SelectCardAction.cs` | 类 | 封装 `SelectCard` 相关的可执行动作或状态机步骤。 |
| `SelfSlapAnimationController.cs` | MonoBehaviour 组件 | 控制 `SelfSlapAnimation` 相关的界面交互、表现或流程推进。 |
| `SelfSlapController.cs` | MonoBehaviour 组件 | 控制 `SelfSlap` 相关的界面交互、表现或流程推进。 |
| `SendUnityEventAction.cs` | 类 | 封装 `SendUnityEvent` 相关的可执行动作或状态机步骤。 |
| `ServerBroadcaster.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ServerBroadcaster` 相关的场景逻辑、表现或交互。 |
| `ServerConnection.cs` | 枚举 | 定义 `ServerConnection` 的枚举选项或状态分类。 |
| `ServerSettings.cs` | ScriptableObject 资源 | 保存 `Server` 相关设置。 |
| `ServerTime.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ServerTime` 相关的场景逻辑、表现或交互。 |
| `SetAvatarPackVisibilityTypeForPlatform.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SetAvatarPackVisibilityTypeForPlatform` 相关的场景逻辑、表现或交互。 |
| `SetDeckTypeAction.cs` | 类 | 封装 `SetDeckType` 相关的可执行动作或状态机步骤。 |
| `SetNextWindowForChooseDeckWindowAction.cs` | 类 | 封装 `SetNextWindowForChooseDeckWindow` 相关的可执行动作或状态机步骤。 |
| `SetTextForPlatform.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SetTextForPlatform` 相关的场景逻辑、表现或交互。 |
| `SetTransformAction.cs` | 类 | 封装 `SetTransform` 相关的可执行动作或状态机步骤。 |
| `SetUiLabelColor.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SetUiLabelColor` 相关的场景逻辑、表现或交互。 |
| `ShakeAction.cs` | 类 | 封装 `Shake` 相关的可执行动作或状态机步骤。 |
| `ShakeTransformS.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ShakeTransformS` 相关的场景逻辑、表现或交互。 |
| `ShareGameCodeController.cs` | MonoBehaviour 组件 | 控制 `ShareGameCode` 相关的界面交互、表现或流程推进。 |
| `ShareTemplate.cs` | 类 | 封装 `ShareTemplate` 相关的核心数据结构或功能逻辑。 |
| `ShareTheFutureController.cs` | MonoBehaviour 组件 | 控制 `ShareTheFuture` 相关的界面交互、表现或流程推进。 |
| `ShowBarking2Cards.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ShowBarking2Cards` 相关的场景逻辑、表现或交互。 |
| `ShowDeckDetailsModalAction.cs` | 类 | 封装 `ShowDeckDetailsModal` 相关的可执行动作或状态机步骤。 |
| `ShowExitGameModalAction.cs` | 类 | 封装 `ShowExitGameModal` 相关的可执行动作或状态机步骤。 |
| `ShowInfoOfPlayer.cs` | 类 | 封装 `ShowInfoOfPlayer` 相关的核心数据结构或功能逻辑。 |
| `ShowMessageBoxAction.cs` | 类 | 封装 `ShowMessageBox` 相关的可执行动作或状态机步骤。 |
| `ShowPotLuckCard.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ShowPotLuckCard` 相关的场景逻辑、表现或交互。 |
| `ShowStatusWhenConnecting.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ShowStatusWhenConnecting` 相关的场景逻辑、表现或交互。 |
| `ShowTakeThat.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ShowTakeThat` 相关的场景逻辑、表现或交互。 |
| `ShowTakeThatDraw.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `ShowTakeThatDraw` 相关的场景逻辑、表现或交互。 |
| `ShowWindowAction.cs` | 类 | 封装 `ShowWindow` 相关的可执行动作或状态机步骤。 |
| `ShuffleController.cs` | MonoBehaviour 组件 | 控制 `Shuffle` 相关的界面交互、表现或流程推进。 |
| `SimpleCard.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SimpleCard` 相关的场景逻辑、表现或交互。 |
| `SimpleCardFactory.cs` | MonoBehaviour 组件 | 负责创建 `SimpleCard` 相关对象、组件或界面实例。 |
| `SinglePlayerManager.cs` | MonoBehaviour 组件 | 统一管理 `SinglePlayer` 相关的状态、数据或整体流程。 |
| `SkeletonAnimation.cs` | 类 | 实现 `Skeleton` 的动画逻辑。 |
| `SkeletonAnimationPanelBinder.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SkeletonAnimationPanelBinder` 相关的场景逻辑、表现或交互。 |
| `SkeletonAnimator.cs` | 类 | 驱动 `Skeleton` 的动画表现。 |
| `SkeletonDataAsset.cs` | ScriptableObject 资源 | 以资源对象形式保存 `SkeletonDataAsset` 相关配置或静态数据。 |
| `SkeletonExtensions.cs` | 类 | 提供 `Skeleton` 相关扩展方法。 |
| `SkeletonGhost.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SkeletonGhost` 相关的场景逻辑、表现或交互。 |
| `SkeletonGhostRenderer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SkeletonGhostRenderer` 相关的场景逻辑、表现或交互。 |
| `SkeletonRagdoll.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SkeletonRagdoll` 相关的场景逻辑、表现或交互。 |
| `SkeletonRagdoll2D.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SkeletonRagdoll2D` 相关的场景逻辑、表现或交互。 |
| `SkeletonRenderer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SkeletonRenderer` 相关的场景逻辑、表现或交互。 |
| `SkeletonUtility.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SkeletonUtility` 相关的场景逻辑、表现或交互。 |
| `SkeletonUtilityBone.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SkeletonUtilityBone` 相关的场景逻辑、表现或交互。 |
| `SkeletonUtilityConstraint.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SkeletonUtilityConstraint` 相关的场景逻辑、表现或交互。 |
| `SkeletonUtilityEyeConstraint.cs` | 类 | 封装 `SkeletonUtilityEyeConstraint` 相关的核心数据结构或功能逻辑。 |
| `SkeletonUtilityGroundConstraint.cs` | 类 | 封装 `SkeletonUtilityGroundConstraint` 相关的核心数据结构或功能逻辑。 |
| `SkeletonUtilityKinematicShadow.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SkeletonUtilityKinematicShadow` 相关的场景逻辑、表现或交互。 |
| `SkeletonUtilitySubmeshRenderer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SkeletonUtilitySubmeshRenderer` 相关的场景逻辑、表现或交互。 |
| `SkipDrawController.cs` | MonoBehaviour 组件 | 控制 `SkipDraw` 相关的界面交互、表现或流程推进。 |
| `SkuEvent.cs` | 委托 | 声明 `Sku` 相关事件或回调约定。 |
| `SlapAnimationController.cs` | MonoBehaviour 组件 | 控制 `SlapAnimation` 相关的界面交互、表现或流程推进。 |
| `SlapBannerGenerator.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SlapBannerGenerator` 相关的场景逻辑、表现或交互。 |
| `SlapController.cs` | MonoBehaviour 组件 | 控制 `Slap` 相关的界面交互、表现或流程推进。 |
| `SmoothSyncMovement.cs` | 类 | 封装 `SmoothSyncMovement` 相关的核心数据结构或功能逻辑。 |
| `SpineAnimation.cs` | 类 | 实现 `Spine` 的动画逻辑。 |
| `SpineAtlasRegion.cs` | 类 | 封装 `SpineAtlasRegion` 相关的核心数据结构或功能逻辑。 |
| `SpineAttachment.cs` | 类 | 封装 `SpineAttachment` 相关的核心数据结构或功能逻辑。 |
| `SpineBone.cs` | 类 | 封装 `SpineBone` 相关的核心数据结构或功能逻辑。 |
| `SpineSkin.cs` | 类 | 封装 `SpineSkin` 相关的核心数据结构或功能逻辑。 |
| `SpineSlot.cs` | 类 | 封装 `SpineSlot` 相关的核心数据结构或功能逻辑。 |
| `Spinner.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `Spinner` 相关的场景逻辑、表现或交互。 |
| `SpinnerAnimator.cs` | MonoBehaviour 组件 | 驱动 `Spinner` 的动画表现。 |
| `SpinnerFactory.cs` | MonoBehaviour 组件 | 负责创建 `Spinner` 相关对象、组件或界面实例。 |
| `SpinnyButton.cs` | MonoBehaviour 组件 | 实现 `Spinny` 按钮的交互或表现逻辑。 |
| `SpringyButton.cs` | MonoBehaviour 组件 | 实现 `Springy` 按钮的交互或表现逻辑。 |
| `SpriteAttacher.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `SpriteAttacher` 相关的场景逻辑、表现或交互。 |
| `SpriteAttachmentLoader.cs` | 类 | 封装 `SpriteAttachmentLoader` 相关的核心数据结构或功能逻辑。 |
| `StartGameButtonController.cs` | MonoBehaviour 组件 | 控制 `StartGame` 按钮的行为与交互反馈。 |
| `StartingHandDistributor.cs` | MonoBehaviour 组件 | 负责 `StartingHand` 的分发、分配或派发逻辑。 |
| `StartTurnBannerGenerator.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `StartTurnBannerGenerator` 相关的场景逻辑、表现或交互。 |
| `StartTurnController.cs` | MonoBehaviour 组件 | 控制 `StartTurn` 相关的界面交互、表现或流程推进。 |
| `StartupSoundPlayer.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `StartupSoundPlayer` 相关的场景逻辑、表现或交互。 |
| `StatusBadge.cs` | MonoBehaviour 组件 | 展示 `Status` 徽章或状态标识。 |
| `StatusBadgeFactory.cs` | MonoBehaviour 组件 | 负责创建 `StatusBadge` 相关对象、组件或界面实例。 |
| `StatusBadgeProvider.cs` | MonoBehaviour 组件 | 提供 `StatusBadge` 所需的数据、引用、选项或运行时上下文。 |
| `StealCardModal.cs` | MonoBehaviour 组件 | 提供 `StealCard` 相关的弹窗界面与交互逻辑。 |
| `StealController.cs` | MonoBehaviour 组件 | 控制 `Steal` 相关的界面交互、表现或流程推进。 |
| `StealDropTarget.cs` | 类 | 封装 `StealDropTarget` 相关的核心数据结构或功能逻辑。 |
| `StopAnimationAction.cs` | 类 | 封装 `StopAnimation` 相关的可执行动作或状态机步骤。 |
| `StopParticlesAction.cs` | 类 | 封装 `StopParticles` 相关的可执行动作或状态机步骤。 |
| `StreakingKittenController.cs` | MonoBehaviour 组件 | 控制 `StreakingKitten` 相关的界面交互、表现或流程推进。 |
| `StreakingKittenModal.cs` | MonoBehaviour 组件 | 提供 `StreakingKitten` 相关的弹窗界面与交互逻辑。 |
| `Submesh.cs` | 类 | 封装 `Submesh` 相关的核心数据结构或功能逻辑。 |
| `SupportLogger.cs` | MonoBehaviour 组件 | 记录 `Support` 相关日志或排查信息。 |
| `SupportLogging.cs` | MonoBehaviour 组件 | 提供 `Support` 相关日志配置或记录入口。 |
| `SwapTopBottomController.cs` | MonoBehaviour 组件 | 控制 `SwapTopBottom` 相关的界面交互、表现或流程推进。 |
| `SwitchNetworkingSystemAction.cs` | 类 | 封装 `SwitchNetworkingSystem` 相关的可执行动作或状态机步骤。 |
| `TakeThatController.cs` | MonoBehaviour 组件 | 控制 `TakeThat` 相关的界面交互、表现或流程推进。 |
| `TapCodeScript.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `TapCodeScript` 相关的场景逻辑、表现或交互。 |
| `TapTextScript.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `TapTextScript` 相关的场景逻辑、表现或交互。 |
| `TargetSelectionNotifier.cs` | MonoBehaviour 组件 | 对外通知 `TargetSelection` 状态变化或选中结果。 |
| `TeamExtensions.cs` | 类 | 提供 `Team` 相关扩展方法。 |
| `TextAssetBackedRepository.cs` | MonoBehaviour 组件 | 负责 `TextAssetBacked` 相关数据的读取、缓存或查询。 |
| `TextAssetReader.cs` | 类 | 负责读取 `TextAsset` 相关资源、文本或配置数据。 |
| `TextClickController.cs` | MonoBehaviour 组件 | 控制 `TextClick` 相关的界面交互、表现或流程推进。 |
| `TextFileReader.cs` | 类 | 负责读取 `TextFile` 相关资源、文本或配置数据。 |
| `TextPic.cs` | 类 | 封装 `TextPic` 相关的核心数据结构或功能逻辑。 |
| `TimeNewScript.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `TimeNewScript` 相关的场景逻辑、表现或交互。 |
| `TimeoutAction.cs` | MonoBehaviour 组件 | 封装 `Timeout` 相关的可执行动作或状态机步骤。 |
| `TintyButton.cs` | MonoBehaviour 组件 | 实现 `Tinty` 按钮的交互或表现逻辑。 |
| `ToggleAudioButtonController.cs` | MonoBehaviour 组件 | 控制 `ToggleAudio` 按钮的行为与交互反馈。 |
| `ToggleFramerateController.cs` | MonoBehaviour 组件 | 控制 `ToggleFramerate` 相关的界面交互、表现或流程推进。 |
| `ToggleVibrationController.cs` | MonoBehaviour 组件 | 控制 `ToggleVibration` 相关的界面交互、表现或流程推进。 |
| `TogglyButton.cs` | MonoBehaviour 组件 | 实现 `Toggly` 按钮的交互或表现逻辑。 |
| `ToolTipActivate.cs` | 类 | 封装 `ToolTipActivate` 相关的核心数据结构或功能逻辑。 |
| `TooltipCaption.cs` | MonoBehaviour 组件 | 显示 `Tooltip` 说明文字、气泡或文案。 |
| `TooltipCaptionDefinition.cs` | 类 | 定义 `TooltipCaption` 的静态描述或规则数据。 |
| `TooltipCaptionFactory.cs` | MonoBehaviour 组件 | 创建 `Tooltip` 说明文字或气泡文案。 |
| `TowerOfPowerController.cs` | MonoBehaviour 组件 | 控制 `TowerOfPower` 相关的界面交互、表现或流程推进。 |
| `TowerOfPowerIcon.cs` | MonoBehaviour 组件 | 展示 `TowerOfPower` 图标或图标状态。 |
| `TroubleJoiningDialog.cs` | 类 | 提供 `TroubleJoining` 相关的对话框逻辑。 |
| `TurnDirectionIndicator.cs` | MonoBehaviour 组件 | 展示 `TurnDirection` 指示状态或方向。 |
| `TurnExtensions.cs` | 类 | 提供 `Turn` 相关扩展方法。 |
| `TurnQueue.cs` | MonoBehaviour 组件 | 维护 `Turn` 的排队、顺序或待处理集合。 |
| `TurnQueueAuthority.cs` | MonoBehaviour 组件 | 维护 `TurnQueue` 的权威状态、主控规则或同步裁决。 |
| `TurnQueueDirection.cs` | 枚举 | 定义 `TurnQueue` 的方向或流转枚举。 |
| `TurnsLeftBannerMetadataFactory.cs` | 类 | 构建 `TurnsLeftBanner` 相关的元数据对象。 |
| `TurnsRemainingTextUpdate.cs` | MonoBehaviour 组件 | 更新 `TurnsRemaining` 相关文本显示。 |
| `TutorialChecklist.cs` | MonoBehaviour 组件 | 维护 `Tutorial` 的检查列表与完成状态。 |
| `TutorialChecklistItem.cs` | MonoBehaviour 组件 | 表示 `Tutorial` 的单个检查项。 |
| `TutorialChecklistItemDefinition.cs` | 类 | 定义 `Tutorial` 检查项的静态描述。 |
| `TutorialChecklistItemFactory.cs` | MonoBehaviour 组件 | 创建 `Tutorial` 检查项界面或对象。 |
| `TutorialChecklistStep.cs` | 枚举 | 定义 `TutorialChecklist` 的单个步骤数据。 |
| `TutorialDraggableCard.cs` | 类 | 封装 `TutorialDraggableCard` 相关的核心数据结构或功能逻辑。 |
| `TutorialDragWindow.cs` | MonoBehaviour 组件 | 承载 `TutorialDrag` 相关的窗口逻辑。 |
| `TutorialDrawPileCard.cs` | 类 | 封装 `TutorialDrawPileCard` 相关的核心数据结构或功能逻辑。 |
| `TutorialDrawWindow.cs` | MonoBehaviour 组件 | 承载 `TutorialDraw` 相关的窗口逻辑。 |
| `TutorialSequence.cs` | MonoBehaviour 组件 | 组织 `Tutorial` 的顺序流程。 |
| `TutorialSequenceStep.cs` | 类 | 定义 `TutorialSequence` 的单个步骤数据。 |
| `TutorialTapCard.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `TutorialTapCard` 相关的场景逻辑、表现或交互。 |
| `TutorialTapWindow.cs` | MonoBehaviour 组件 | 承载 `TutorialTap` 相关的窗口逻辑。 |
| `TwoButtonModal.cs` | MonoBehaviour 组件 | 提供 `TwoButton` 相关的弹窗界面与交互逻辑。 |
| `TypedLobby.cs` | 类 | 封装 `TypedLobby` 相关的核心数据结构或功能逻辑。 |
| `TypedLobbyInfo.cs` | 类 | 封装 `TypedLobby` 相关信息结构。 |
| `UIScrollViewExtensions.cs` | 类 | 提供 `UIScrollView` 相关扩展方法。 |
| `UITextUtilities.cs` | MonoBehaviour 组件 | 提供 `UIText` 相关的通用工具方法。 |
| `UnitySourceGeneratedAssemblyMonoScriptTypes_v1.cs` | 类 | Unity 自动生成的 MonoScript 类型注册与反射辅助文件。 |
| `UpdateBonesDelegate.cs` | 委托 | 声明 `UpdateBones` 相关的委托回调签名。 |
| `UpdateWinLossText.cs` | MonoBehaviour 组件 | 处理 `UpdateWinLoss` 相关文本显示或内容逻辑。 |
| `UserInputTransformer.cs` | MonoBehaviour 组件 | 转换 `UserInput` 输入、格式或表现形式。 |
| `VictoryEventHandler.cs` | MonoBehaviour 组件 | 监听并处理 `Victory` 相关事件。 |
| `VictoryModal.cs` | MonoBehaviour 组件 | 提供 `Victory` 相关的弹窗界面与交互逻辑。 |
| `VictoryStats.cs` | MonoBehaviour 组件 | 记录 `Victory` 相关统计结果。 |
| `ViewSynchronization.cs` | 枚举 | 定义 `ViewSynchronization` 的枚举选项或状态分类。 |
| `VisibleKittenDetector.cs` | MonoBehaviour 组件 | 检测 `VisibleKitten` 是否出现、可见或满足条件。 |
| `VisibleKittenEvent.cs` | 委托 | 声明 `VisibleKitten` 相关事件或回调约定。 |
| `WebRpcResponse.cs` | 类 | 封装 `WebRpcResponse` 相关的核心数据结构或功能逻辑。 |
| `WindowController.cs` | MonoBehaviour 组件 | 控制 `WindowController` 窗口的展示、关闭与内部流程。 |
| `WindowPaginator.cs` | MonoBehaviour 组件 | 处理 `Window` 的分页与翻页逻辑。 |
| `WindowTransitioner.cs` | MonoBehaviour 组件 | 处理 `Window` 切换、过渡或转场流程。 |
| `WindowTransitioner2.cs` | MonoBehaviour 组件 | 作为 Unity 组件承载 `WindowTransitioner2` 相关的场景逻辑、表现或交互。 |
| `WindowTransitioningMessageBoxDisplayer.cs` | 类 | 封装 `WindowTransitioningMessageBoxDisplayer` 相关的核心数据结构或功能逻辑。 |
| `YouExplodedModal.cs` | MonoBehaviour 组件 | 提供 `YouExploded` 相关的弹窗界面与交互逻辑。 |
| `YourTurnEventHandler.cs` | MonoBehaviour 组件 | 监听并处理 `YourTurn` 相关事件。 |
| `YourTurnModal.cs` | MonoBehaviour 组件 | 提供 `YourTurn` 相关的弹窗界面与交互逻辑。 |
