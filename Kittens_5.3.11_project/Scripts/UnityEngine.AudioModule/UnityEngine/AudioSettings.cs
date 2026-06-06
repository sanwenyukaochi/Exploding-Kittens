using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Modules/Audio/Public/ScriptBindings/Audio.bindings.h")]
	[StaticAccessor("GetAudioManager()", StaticAccessorType.Dot)]
	public sealed class AudioSettings
	{
		public delegate void AudioConfigurationChangeHandler(bool deviceWasChanged);

		public static class Mobile
		{
			private static bool _stopAudioOutputOnMute;

			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			[CompilerGenerated]
			private static Action<bool> OnMuteStateChanged;

			public static bool muteState { get; private set; }

			public static bool stopAudioOutputOnMute => false;

			[RequiredByNativeCode]
			internal static void InvokeOnMuteStateChanged(bool mute)
			{
			}

			[RequiredByNativeCode]
			internal static bool InvokeIsStopAudioOutputOnMuteEnabled()
			{
				return false;
			}

			public static void StartAudioOutput()
			{
			}

			public static void StopAudioOutput()
			{
			}
		}

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static AudioConfigurationChangeHandler OnAudioConfigurationChanged;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnAudioSystemShuttingDown;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action OnAudioSystemStartedUp;

		[RequiredByNativeCode]
		internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged)
		{
		}

		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemShuttingDown()
		{
		}

		[RequiredByNativeCode]
		internal static void InvokeOnAudioSystemStartedUp()
		{
		}

		internal static bool StartAudioOutput()
		{
			return false;
		}

		internal static bool StopAudioOutput()
		{
			return false;
		}
	}
}
