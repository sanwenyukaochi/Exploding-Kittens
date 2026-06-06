using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform))]
	[StaticAccessor("AudioSourceBindings", StaticAccessorType.DoubleColon)]
	public sealed class AudioSource : AudioBehaviour
	{
		public float volume
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pitch
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("AudioClip")]
		public AudioClip clip
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isPlaying
		{
			[NativeName("IsPlayingScripting")]
			get
			{
				return false;
			}
		}

		public bool loop
		{
			set
			{
			}
		}

		public bool playOnAwake
		{
			set
			{
			}
		}

		[NativeProperty("SpatialBlendMix")]
		public float spatialBlend
		{
			set
			{
			}
		}

		public int priority
		{
			set
			{
			}
		}

		public bool mute
		{
			set
			{
			}
		}

		private static float GetPitch([NotNull("ArgumentNullException")] AudioSource source)
		{
			return 0f;
		}

		private static void SetPitch([NotNull("ArgumentNullException")] AudioSource source, float pitch)
		{
		}

		private static void PlayHelper([NotNull("ArgumentNullException")] AudioSource source, ulong delay)
		{
		}

		private static void PlayOneShotHelper([NotNull("ArgumentNullException")] AudioSource source, [NotNull("NullExceptionObject")] AudioClip clip, float volumeScale)
		{
		}

		private void Stop(bool stopOneShots)
		{
		}

		[ExcludeFromDocs]
		public void Play()
		{
		}

		[ExcludeFromDocs]
		public void PlayOneShot(AudioClip clip)
		{
		}

		public void PlayOneShot(AudioClip clip, [DefaultValue("1.0F")] float volumeScale)
		{
		}

		public void Stop()
		{
		}

		public void Pause()
		{
		}

		public static void PlayClipAtPoint(AudioClip clip, Vector3 position, [DefaultValue("1.0F")] float volume)
		{
		}
	}
}
