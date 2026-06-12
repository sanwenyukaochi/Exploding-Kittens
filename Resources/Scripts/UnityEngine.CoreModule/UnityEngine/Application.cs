using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Utilities/URLUtility.h")]
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	[NativeHeader("Runtime/Export/Application/Application.bindings.h")]
	[NativeHeader("Runtime/Network/NetworkUtility.h")]
	[NativeHeader("Runtime/Utilities/Argv.h")]
	[NativeHeader("Runtime/PreloadManager/LoadSceneOperation.h")]
	[NativeHeader("Runtime/Application/AdsIdHandler.h")]
	[NativeHeader("Runtime/Logging/LogSystem.h")]
	[NativeHeader("Runtime/PreloadManager/PreloadManager.h")]
	[NativeHeader("Runtime/BaseClasses/IsPlaying.h")]
	[NativeHeader("Runtime/File/ApplicationSpecificPersistentDataPath.h")]
	[NativeHeader("Runtime/Misc/SystemInfo.h")]
	[NativeHeader("Runtime/Application/ApplicationInfo.h")]
	[NativeHeader("Runtime/Input/GetInput.h")]
	[NativeHeader("Runtime/Misc/BuildSettings.h")]
	[NativeHeader("Runtime/Misc/Player.h")]
	[NativeHeader("Runtime/Input/TargetFrameRate.h")]
	[NativeHeader("Runtime/Input/InputManager.h")]
	public class Application
	{
		public delegate void LowMemoryCallback();

		public delegate void MemoryUsageChangedCallback(in ApplicationMemoryUsageChange usage);

		public delegate void LogCallback(string condition, string stackTrace, LogType type);

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static LowMemoryCallback lowMemory;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static MemoryUsageChangedCallback memoryUsageChanged;

		private static LogCallback s_LogCallbackHandler;

		private static LogCallback s_LogCallbackHandlerThreaded;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<bool> focusChanged;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action<string> deepLinkActivated;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Func<bool> wantsToQuit;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action quitting;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action unloading;

		private static CancellationTokenSource s_currentCancellationTokenSource;

		public static bool isPlaying
		{
			[FreeFunction("IsWorldPlaying")]
			get
			{
				return false;
			}
		}

		public static bool isFocused
		{
			[FreeFunction("IsPlayerFocused")]
			get
			{
				return false;
			}
		}

		public static string buildGUID
		{
			[FreeFunction("Application_Bindings::GetBuildGUID")]
			get
			{
				return null;
			}
		}

		public static bool runInBackground
		{
			[FreeFunction("SetPlayerSettingsRunInBackground")]
			set
			{
			}
		}

		public static bool isBatchMode
		{
			[FreeFunction("::IsBatchmode")]
			get
			{
				return false;
			}
		}

		public static string dataPath
		{
			[FreeFunction("GetAppDataPath", IsThreadSafe = true)]
			get
			{
				return null;
			}
		}

		public static string streamingAssetsPath
		{
			[FreeFunction("GetStreamingAssetsPath", IsThreadSafe = true)]
			get
			{
				return null;
			}
		}

		public static string persistentDataPath
		{
			[FreeFunction("GetPersistentDataPathApplicationSpecific")]
			get
			{
				return null;
			}
		}

		public static string unityVersion
		{
			[FreeFunction("Application_Bindings::GetUnityVersion", IsThreadSafe = true)]
			get
			{
				return null;
			}
		}

		public static string version
		{
			[FreeFunction("GetApplicationInfo().GetVersion")]
			get
			{
				return null;
			}
		}

		public static string identifier
		{
			[FreeFunction("GetApplicationInfo().GetApplicationIdentifier")]
			get
			{
				return null;
			}
		}

		public static string productName
		{
			[FreeFunction("GetPlayerSettings().GetProductName")]
			get
			{
				return null;
			}
		}

		public static string cloudProjectId
		{
			[FreeFunction("GetPlayerSettings().GetCloudProjectId")]
			get
			{
				return null;
			}
		}

		public static int targetFrameRate
		{
			[FreeFunction("SetTargetFrameRate")]
			set
			{
			}
		}

		public static bool genuine
		{
			[FreeFunction("IsApplicationGenuine")]
			get
			{
				return false;
			}
		}

		public static bool genuineCheckAvailable
		{
			[FreeFunction("IsApplicationGenuineAvailable")]
			get
			{
				return false;
			}
		}

		public static RuntimePlatform platform
		{
			[FreeFunction("systeminfo::GetRuntimePlatform", IsThreadSafe = true)]
			get
			{
				return default(RuntimePlatform);
			}
		}

		public static bool isEditor => false;

		public static event LogCallback logMessageReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		[FreeFunction("GetInputManager().QuitApplication")]
		public static void Quit(int exitCode)
		{
		}

		public static void Quit()
		{
		}

		public static bool CanStreamedLevelBeLoaded(int levelIndex)
		{
			return false;
		}

		[FreeFunction("Application_Bindings::CanStreamedLevelBeLoaded")]
		public static bool CanStreamedLevelBeLoaded(string levelName)
		{
			return false;
		}

		[FreeFunction("OpenURL")]
		public static void OpenURL(string url)
		{
		}

		[FreeFunction("Application_Bindings::SetLogCallbackDefined")]
		private static void SetLogCallbackDefined(bool defined)
		{
		}

		[RequiredByNativeCode]
		internal static void CallLowMemory(ApplicationMemoryUsage usage)
		{
		}

		[RequiredByNativeCode]
		internal static bool HasLogCallback()
		{
			return false;
		}

		[RequiredByNativeCode]
		private static void CallLogCallback(string logString, string stackTrace, LogType type, bool invokedOnMainThread)
		{
		}

		[RequiredByNativeCode]
		private static bool Internal_ApplicationWantsToQuit()
		{
			return false;
		}

		[RequiredByNativeCode]
		private static void Internal_ApplicationQuit()
		{
		}

		[RequiredByNativeCode]
		private static void Internal_ApplicationUnload()
		{
		}

		[RequiredByNativeCode]
		internal static void InvokeOnBeforeRender()
		{
		}

		[RequiredByNativeCode]
		internal static void InvokeFocusChanged(bool focus)
		{
		}

		[RequiredByNativeCode]
		internal static void InvokeDeepLinkActivated(string url)
		{
		}

		[Obsolete("Use SceneManager.LoadScene")]
		public static void LoadLevel(string name)
		{
		}
	}
}
