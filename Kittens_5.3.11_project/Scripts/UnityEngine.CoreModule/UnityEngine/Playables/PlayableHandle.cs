using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Playables
{
	[NativeHeader("Runtime/Export/Director/PlayableHandle.bindings.h")]
	[NativeHeader("Runtime/Director/Core/HPlayable.h")]
	[NativeHeader("Runtime/Director/Core/HPlayableGraph.h")]
	[UsedByNativeCode]
	public struct PlayableHandle : IEquatable<PlayableHandle>
	{
		internal IntPtr m_Handle;

		internal uint m_Version;

		private static readonly PlayableHandle m_Null;

		public static PlayableHandle Null => default(PlayableHandle);

		[VisibleToOtherModules]
		internal bool IsPlayableOfType<T>()
		{
			return false;
		}

		public static bool operator ==(PlayableHandle x, PlayableHandle y)
		{
			return false;
		}

		public override bool Equals(object p)
		{
			return false;
		}

		public bool Equals(PlayableHandle other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs)
		{
			return false;
		}

		[VisibleToOtherModules]
		internal bool IsValid()
		{
			return false;
		}

		[FreeFunction("PlayableHandleBindings::GetPlayableType", HasExplicitThis = true, ThrowsException = true)]
		[VisibleToOtherModules]
		internal Type GetPlayableType()
		{
			return null;
		}

		private static bool IsValid_Injected(ref PlayableHandle _unity_self)
		{
			return false;
		}

		private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self)
		{
			return null;
		}
	}
}
