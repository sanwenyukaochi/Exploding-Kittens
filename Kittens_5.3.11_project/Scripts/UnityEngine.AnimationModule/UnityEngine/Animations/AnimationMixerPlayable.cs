using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	[StaticAccessor("AnimationMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationMixerPlayable.bindings.h")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Modules/Animation/Director/AnimationMixerPlayable.h")]
	public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable>
	{
		private PlayableHandle m_Handle;

		private static readonly AnimationMixerPlayable m_NullPlayable;

		internal AnimationMixerPlayable(PlayableHandle handle)
		{
			m_Handle = default(PlayableHandle);
		}

		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		public bool Equals(AnimationMixerPlayable other)
		{
			return false;
		}
	}
}
