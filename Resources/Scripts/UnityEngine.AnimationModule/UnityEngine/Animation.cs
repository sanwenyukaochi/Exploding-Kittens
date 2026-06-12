using System.Collections;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/Animation.h")]
	public sealed class Animation : Behaviour, IEnumerable
	{
		private sealed class Enumerator : IEnumerator
		{
			private Animation m_Outer;

			private int m_CurrentIndex;

			public object Current => null;

			internal Enumerator(Animation outer)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
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

		public AnimationState this[string name] => null;

		public void Stop()
		{
		}

		public void Stop(string name)
		{
		}

		[NativeName("Stop")]
		private void StopNamed(string name)
		{
		}

		public void Rewind(string name)
		{
		}

		[NativeName("Rewind")]
		private void RewindNamed(string name)
		{
		}

		public void Sample()
		{
		}

		public bool IsPlaying(string name)
		{
			return false;
		}

		[ExcludeFromDocs]
		public bool Play()
		{
			return false;
		}

		public bool Play([DefaultValue("PlayMode.StopSameLayer")] PlayMode mode)
		{
			return false;
		}

		[NativeName("Play")]
		private bool PlayDefaultAnimation(PlayMode mode)
		{
			return false;
		}

		[ExcludeFromDocs]
		public bool Play(string animation)
		{
			return false;
		}

		public bool Play(string animation, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode)
		{
			return false;
		}

		public void CrossFade(string animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode)
		{
		}

		public void Blend(string animation, [DefaultValue("1.0F")] float targetWeight, [DefaultValue("0.3F")] float fadeLength)
		{
		}

		[ExcludeFromDocs]
		public AnimationState CrossFadeQueued(string animation)
		{
			return null;
		}

		[ExcludeFromDocs]
		public AnimationState CrossFadeQueued(string animation, float fadeLength)
		{
			return null;
		}

		[ExcludeFromDocs]
		public AnimationState CrossFadeQueued(string animation, float fadeLength, QueueMode queue)
		{
			return null;
		}

		[FreeFunction("AnimationBindings::CrossFadeQueuedImpl", HasExplicitThis = true)]
		public AnimationState CrossFadeQueued(string animation, [DefaultValue("0.3F")] float fadeLength, [DefaultValue("QueueMode.CompleteOthers")] QueueMode queue, [DefaultValue("PlayMode.StopSameLayer")] PlayMode mode)
		{
			return null;
		}

		public void AddClip(AnimationClip clip, string newName)
		{
		}

		[ExcludeFromDocs]
		public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame)
		{
		}

		public void AddClip([NotNull("NullExceptionObject")] AnimationClip clip, string newName, int firstFrame, int lastFrame, [DefaultValue("false")] bool addLoopFrame)
		{
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[FreeFunction("AnimationBindings::GetState", HasExplicitThis = true)]
		internal AnimationState GetState(string name)
		{
			return null;
		}

		[FreeFunction("AnimationBindings::GetStateAtIndex", HasExplicitThis = true, ThrowsException = true)]
		internal AnimationState GetStateAtIndex(int index)
		{
			return null;
		}

		[NativeName("GetAnimationStateCount")]
		internal int GetStateCount()
		{
			return 0;
		}
	}
}
