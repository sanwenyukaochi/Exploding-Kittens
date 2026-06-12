using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.AI
{
	[NativeHeader("Modules/AI/NavMesh/NavMesh.bindings.h")]
	[StaticAccessor("NavMeshBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/AI/NavMeshManager.h")]
	[MovedFrom("UnityEngine")]
	public static class NavMesh
	{
		public delegate void OnNavMeshPreUpdate();

		public static OnNavMeshPreUpdate onPreUpdate;

		[RequiredByNativeCode]
		private static void Internal_CallOnNavMeshPreUpdate()
		{
		}
	}
}
