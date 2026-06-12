using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Video
{
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/Video/Public/VideoPlayer.h")]
	[RequiredByNativeCode]
	public sealed class VideoPlayer : Behaviour
	{
		public delegate void EventHandler(VideoPlayer source);

		public delegate void ErrorEventHandler(VideoPlayer source, string message);

		public delegate void FrameReadyEventHandler(VideoPlayer source, long frameIdx);

		public delegate void TimeEventHandler(VideoPlayer source, double seconds);

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private TimeEventHandler clockResyncOccurred;

		public VideoSource source
		{
			get
			{
				return default(VideoSource);
			}
			set
			{
			}
		}

		public VideoTimeUpdateMode timeUpdateMode
		{
			get
			{
				return default(VideoTimeUpdateMode);
			}
			set
			{
			}
		}

		[NativeName("VideoUrl")]
		public string url
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[NativeName("VideoClip")]
		public VideoClip clip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public VideoRenderMode renderMode
		{
			get
			{
				return default(VideoRenderMode);
			}
			set
			{
			}
		}

		public bool canSetTimeUpdateMode
		{
			[NativeName("CanSetTimeUpdateMode")]
			get
			{
				return false;
			}
		}

		[NativeHeader("Runtime/Camera/Camera.h")]
		public Camera targetCamera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[NativeHeader("Runtime/Graphics/RenderTexture.h")]
		public RenderTexture targetTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string targetMaterialProperty
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public VideoAspectRatio aspectRatio
		{
			get
			{
				return default(VideoAspectRatio);
			}
			set
			{
			}
		}

		public float targetCameraAlpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeHeader("Runtime/Graphics/Texture.h")]
		public Texture texture => null;

		public bool isPrepared
		{
			[NativeName("IsPrepared")]
			get
			{
				return false;
			}
		}

		public bool waitForFirstFrame
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool playOnAwake
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isPlaying
		{
			[NativeName("IsPlaying")]
			get
			{
				return false;
			}
		}

		public bool canSetTime
		{
			[NativeName("CanSetTime")]
			get
			{
				return false;
			}
		}

		[NativeName("SecPosition")]
		public double time
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		[NativeName("FramePosition")]
		public long frame => 0L;

		public bool canStep
		{
			[NativeName("CanStep")]
			get
			{
				return false;
			}
		}

		public bool canSetPlaybackSpeed
		{
			[NativeName("CanSetPlaybackSpeed")]
			get
			{
				return false;
			}
		}

		public float playbackSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeName("Loop")]
		public bool isLooping => false;

		public bool canSetSkipOnDrop
		{
			[NativeName("CanSetSkipOnDrop")]
			get
			{
				return false;
			}
		}

		public bool skipOnDrop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ulong frameCount => 0uL;

		public float frameRate => 0f;

		public ushort audioTrackCount => 0;

		public static ushort controlledAudioTrackMaxCount => 0;

		public VideoAudioOutputMode audioOutputMode
		{
			get
			{
				return default(VideoAudioOutputMode);
			}
			set
			{
			}
		}

		public bool canSetDirectAudioVolume
		{
			[NativeName("CanSetDirectAudioVolume")]
			get
			{
				return false;
			}
		}

		public bool sendFrameReadyEvents
		{
			[NativeName("AreFrameReadyEventsEnabled")]
			get
			{
				return false;
			}
			[NativeName("EnableFrameReadyEvents")]
			set
			{
			}
		}

		public event EventHandler prepareCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler loopPointReached
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler started
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler frameDropped
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event ErrorEventHandler errorReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event EventHandler seekCompleted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event FrameReadyEventHandler frameReady
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Prepare()
		{
		}

		public void Play()
		{
		}

		public void Pause()
		{
		}

		public void Stop()
		{
		}

		public void StepForward()
		{
		}

		[RequiredByNativeCode]
		private static void InvokePrepareCompletedCallback_Internal(VideoPlayer source)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeFrameReadyCallback_Internal(VideoPlayer source, long frameIdx)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeLoopPointReachedCallback_Internal(VideoPlayer source)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeStartedCallback_Internal(VideoPlayer source)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeFrameDroppedCallback_Internal(VideoPlayer source)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeErrorReceivedCallback_Internal(VideoPlayer source, string errorStr)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeSeekCompletedCallback_Internal(VideoPlayer source)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeClockResyncOccurredCallback_Internal(VideoPlayer source, double seconds)
		{
		}
	}
}
