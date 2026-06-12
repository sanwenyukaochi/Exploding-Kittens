using System;
using UnityEngine.Bindings;
using UnityEngine.Playables;
using UnityEngine.Scripting;

namespace UnityEngine.Experimental.Playables
{
	[NativeHeader("Runtime/Graphics/Director/TextureMixerPlayable.h")]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Export/Director/TextureMixerPlayable.bindings.h")]
	[StaticAccessor("TextureMixerPlayableBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	public struct TextureMixerPlayable : IEquatable<TextureMixerPlayable>
	{
		private PlayableHandle m_Handle;

		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		public bool Equals(TextureMixerPlayable other)
		{
			return false;
		}
	}
}
