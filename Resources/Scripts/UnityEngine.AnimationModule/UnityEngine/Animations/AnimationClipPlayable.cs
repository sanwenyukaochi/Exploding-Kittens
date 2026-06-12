using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Animations
{
	[NativeHeader("Modules/Animation/Director/AnimationClipPlayable.h")]
	[StaticAccessor("AnimationClipPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimationClipPlayable.bindings.h")]
	[RequiredByNativeCode]
	public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable>
	{
		private PlayableHandle m_Handle;

		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		public bool Equals(AnimationClipPlayable other)
		{
			return false;
		}
	}
}
