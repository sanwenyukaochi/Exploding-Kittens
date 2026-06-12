using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[RequiredByNativeCode]
	[StaticAccessor("AnimationLayerMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Animation/Director/AnimationLayerMixerPlayable.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationLayerMixerPlayable.bindings.h")]
	public struct AnimationLayerMixerPlayable : IEquatable<AnimationLayerMixerPlayable>
	{
		private PlayableHandle m_Handle;

		private static readonly AnimationLayerMixerPlayable m_NullPlayable;

		internal AnimationLayerMixerPlayable(PlayableHandle handle, bool singleLayerOptimization = true)
		{
			m_Handle = default(PlayableHandle);
		}

		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		public bool Equals(AnimationLayerMixerPlayable other)
		{
			return false;
		}

		[NativeThrows]
		private static void SetSingleLayerOptimizationInternal(ref PlayableHandle handle, bool value)
		{
		}
	}
}
