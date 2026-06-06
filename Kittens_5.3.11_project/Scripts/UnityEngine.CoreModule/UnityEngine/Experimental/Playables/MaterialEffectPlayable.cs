using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	[NativeHeader("Runtime/Shaders/Director/MaterialEffectPlayable.h")]
	[NativeHeader("Runtime/Export/Director/MaterialEffectPlayable.bindings.h")]
	[RequiredByNativeCode]
	[StaticAccessor("MaterialEffectPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	public struct MaterialEffectPlayable : IEquatable<MaterialEffectPlayable>
	{
		private PlayableHandle m_Handle;

		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		public bool Equals(MaterialEffectPlayable other)
		{
			return false;
		}
	}
}
