using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	[RequiredByNativeCode]
	public struct Playable : IEquatable<Playable>
	{
		private PlayableHandle m_Handle;

		private static readonly Playable m_NullPlayable;

		public static Playable Null => default(Playable);

		[VisibleToOtherModules]
		internal Playable(PlayableHandle handle)
		{
			m_Handle = default(PlayableHandle);
		}

		public PlayableHandle GetHandle()
		{
			return default(PlayableHandle);
		}

		public bool Equals(Playable other)
		{
			return false;
		}
	}
}
