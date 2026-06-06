# Scripts 一级目录职责说明

本文档用于说明 `D:\Users\sanwe\Desktop\Spring\Exploding-Kittens\Kittens_5.3.11_project\Scripts` 下各一级文件夹的大致职责。

说明：
- 只描述一级文件夹负责的内容。
- 不展开子文件夹和子文件的具体细节。
- 部分说明基于目录命名空间和抽样文件名判断，适合做快速导航。

## 项目业务与第三方功能

| 文件夹 | 负责内容 |
| --- | --- |
| `Assembly-CSharp` | 游戏主业务代码，通常包含玩法逻辑、界面行为、活动系统、成就、交互流程等项目核心脚本。 |
| `Assembly-CSharp-firstpass` | 较早编译的项目脚本与公共基础逻辑，通常承载需要先于主业务程序集编译的共享代码或老式插件代码。 |
| `ConditionalExpression` | 条件表达式解析与求值功能，主要用于支持可配置规则或 PlayMaker 条件判断。 |
| `MGS.Debugging` | 项目自定义调试系统，包括调试开关、调试 UI、调试函数入口、问题排查辅助能力。 |
| `MGS.PersistentStorage` | 持久化存储抽象层，负责本地数据保存、读取以及序列化适配。 |
| `MGSLogger` | 项目自定义日志封装，负责统一输出调试日志或运行日志。 |
| `Newtonsoft.Json` | JSON 序列化与反序列化库，用于配置、存档、网络数据等 JSON 数据处理。 |
| `Photon3Unity3D` | Photon 联机通信库，负责多人联网、消息传输、房间连接等网络通信能力。 |
| `PlayMaker` | PlayMaker 可视化状态机系统运行时，负责状态机逻辑、事件驱动和无代码流程控制。 |
| `Purchasing.Common` | Unity IAP 的公共桥接层与通用工具，负责购买系统的基础接口和跨平台公共逻辑。 |

## .NET / Mono 基础库

| 文件夹 | 负责内容 |
| --- | --- |
| `Mono.Security` | Mono 安全库，负责证书、加密、签名校验等安全相关基础能力。 |
| `mscorlib` | .NET/Mono 最基础的核心类库，提供基本类型、异常、集合、反射等底层能力。 |
| `System` | 通用基础类库，负责集合、IO、线程、网络、基础工具类等常用运行时能力。 |
| `System.Configuration` | 配置系统相关库，负责读取和处理应用配置数据。 |
| `System.Core` | 扩展核心类库，主要承载 LINQ、表达式树、部分高级集合与查询能力。 |
| `System.Data` | 数据访问相关类库，提供表结构、数据集、数据库访问等能力。 |
| `System.Numerics` | 数值运算扩展库，负责向量、矩阵或大整数等数值类型支持。 |
| `System.Runtime.CompilerServices.Unsafe` | 底层内存访问辅助库，负责高性能或低层级的非安全内存操作支持。 |
| `System.Runtime.InteropServices` | 托管与原生代码互操作支持库，负责 P/Invoke、COM 等互操作能力。 |
| `System.Runtime.Serialization` | 运行时序列化库，负责对象序列化、反序列化和数据契约处理。 |
| `System.Xml` | XML 处理基础库，负责 XML 读取、写入、解析与文档操作。 |
| `System.Xml.Linq` | 基于 LINQ 的 XML 操作库，负责更方便地查询和构造 XML。 |

## Unity Services

| 文件夹 | 负责内容 |
| --- | --- |
| `Unity.Services.Analytics` | Unity Analytics 服务实现，负责埋点、行为统计和分析事件上报。 |
| `Unity.Services.Core` | Unity Services 基础入口，负责服务初始化、通用接口和全局配置选项。 |
| `Unity.Services.Core.Configuration` | Unity Services 配置模块，负责云项目 ID、配置项和服务配置读取。 |
| `Unity.Services.Core.Device` | 设备与安装标识模块，负责设备信息、安装 ID、用户标识等能力。 |
| `Unity.Services.Core.Environments` | 环境配置模块，负责切换和声明不同服务环境。 |
| `Unity.Services.Core.Environments.Internal` | 环境系统的内部实现，负责环境对象和运行时内部处理逻辑。 |
| `Unity.Services.Core.Internal` | Unity Services 内部通用接口层，负责若干内部标准接口和共享约定。 |
| `Unity.Services.Core.Registration` | 服务注册与启动装配模块，负责核心包初始化和依赖注册。 |
| `Unity.Services.Core.Scheduler` | 调度模块，负责延迟执行、任务调度和时间驱动逻辑。 |
| `Unity.Services.Core.Telemetry` | 诊断与遥测模块，负责指标、诊断事件和运行状态上报。 |
| `Unity.Services.Core.Threading` | 线程辅助模块，负责 Unity 主线程切换和线程工具支持。 |

## Unity 引擎与官方模块

| 文件夹 | 负责内容 |
| --- | --- |
| `Unity.TextMeshPro` | TextMesh Pro 文本系统，负责高质量文本渲染、富文本和字体资源支持。 |
| `UnityEngine` | Unity 引擎基础 API 总入口，提供最常用的核心对象和引擎基础类型。 |
| `UnityEngine.AIModule` | Unity AI 模块，主要负责导航、寻路和 AI 相关基础功能。 |
| `UnityEngine.AndroidJNIModule` | Android JNI 模块，负责 Unity 与 Android Java 层交互。 |
| `UnityEngine.AnimationModule` | 动画系统模块，负责 Animator、Animation 等动画运行能力。 |
| `UnityEngine.AudioModule` | 音频系统模块，负责声音播放、AudioSource、AudioClip 等音频能力。 |
| `UnityEngine.CoreModule` | Unity 核心运行模块，负责对象生命周期、组件体系、场景基础能力等核心内容。 |
| `UnityEngine.GridModule` | 网格与栅格布局模块，负责 2D/Tilemap 相关的网格基础能力。 |
| `UnityEngine.ImageConversionModule` | 图像转换模块，负责纹理编码、解码和图片格式转换。 |
| `UnityEngine.IMGUIModule` | 旧版即时模式 GUI 模块，负责 OnGUI 一类的传统界面绘制能力。 |
| `UnityEngine.InputLegacyModule` | 旧输入系统模块，负责传统键盘、鼠标、触摸等输入接口。 |
| `UnityEngine.JSONSerializeModule` | Unity 自带 JSON 序列化模块，负责 `JsonUtility` 一类的 JSON 处理能力。 |
| `UnityEngine.ParticleSystemModule` | 粒子系统模块，负责特效粒子播放、控制和渲染。 |
| `UnityEngine.Physics2DModule` | 2D 物理模块，负责 2D 碰撞、刚体和物理计算。 |
| `UnityEngine.PhysicsModule` | 3D 物理模块，负责 3D 碰撞、刚体和物理计算。 |
| `UnityEngine.PropertiesModule` | Unity 引擎属性与基础定义补充模块，负责部分引擎属性支持和程序集元数据配套内容。 |
| `UnityEngine.Purchasing` | Unity IAP 主运行库，负责应用内购买主流程和购买系统入口。 |
| `UnityEngine.Purchasing.AppleCore` | Apple 平台内购核心实现，负责 Apple 侧购买流程的核心支持。 |
| `UnityEngine.Purchasing.AppleMacosStub` | Apple macOS 内购占位实现，通常用于特定平台未启用时的占位或兼容处理。 |
| `UnityEngine.Purchasing.AppleStub` | Apple 内购占位实现，负责未接入或不启用平台时的兼容桥接。 |
| `UnityEngine.Purchasing.Security` | Unity IAP 安全模块，负责票据、收据、安全验证等相关功能。 |
| `UnityEngine.Purchasing.SecurityCore` | Unity IAP 安全核心库，负责安全验证体系的基础类型和底层逻辑。 |
| `UnityEngine.Purchasing.Stores` | 商店适配模块，负责对接不同应用商店的购买实现。 |
| `UnityEngine.Purchasing.WinRTCore` | WinRT 平台内购核心实现，负责 Windows Runtime 平台购买能力。 |
| `UnityEngine.Purchasing.WinRTStub` | WinRT 内购占位实现，负责未启用 WinRT 时的兼容支持。 |
| `UnityEngine.ScreenCaptureModule` | 截屏模块，负责屏幕截图与图像捕获能力。 |
| `UnityEngine.SharedInternalsModule` | Unity 内部共享实现模块，负责多个引擎模块之间复用的内部支持代码。 |
| `UnityEngine.SpriteShapeModule` | Sprite Shape 模块，负责样条精灵形状与 2D 曲线造型功能。 |
| `UnityEngine.TextCoreFontEngineModule` | TextCore 字体引擎模块，负责字体解析、字形处理和字体底层能力。 |
| `UnityEngine.TextCoreTextEngineModule` | TextCore 文本引擎模块，负责现代文本布局、字符处理和文本底层逻辑。 |
| `UnityEngine.TextRenderingModule` | 文本渲染模块，负责文本绘制与相关底层渲染支持。 |
| `UnityEngine.TilemapModule` | Tilemap 模块，负责 2D 瓦片地图系统。 |
| `UnityEngine.UI` | Unity UI 组件库，负责按钮、图片、文本、布局等 uGUI 组件。 |
| `UnityEngine.UIElementsModule` | UIElements 模块，负责较新的声明式 UI 系统运行支持。 |
| `UnityEngine.UIModule` | Unity 底层 UI 支撑模块，负责事件系统和部分 UI 基础能力。 |
| `UnityEngine.UnityAnalyticsCommonModule` | Unity Analytics 通用模块，负责分析系统共用的数据结构和基础逻辑。 |
| `UnityEngine.UnityAnalyticsModule` | Unity Analytics 引擎模块，负责分析事件与引擎侧集成。 |
| `UnityEngine.UnityWebRequestModule` | Unity 网络请求模块，负责 HTTP/HTTPS 请求、下载和上传能力。 |
| `UnityEngine.UnityWebRequestWWWModule` | Unity 旧式 WWW 兼容模块，负责与较早网络接口的兼容支持。 |
| `UnityEngine.VideoModule` | 视频模块，负责视频播放、渲染和控制。 |

## 自动生成代码

| 文件夹 | 负责内容 |
| --- | --- |
| `__Generated` | 自动生成的桥接与底层兼容代码，主要服务于 IL2CPP、COM 互操作或运行时元数据适配。 |

