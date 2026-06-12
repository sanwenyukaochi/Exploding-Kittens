using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[StaticAccessor("GeometryUtilityScripting", StaticAccessorType.DoubleColon)]
	public sealed class GeometryUtility
	{
		public static Plane[] CalculateFrustumPlanes(Camera camera)
		{
			return null;
		}

		public static void CalculateFrustumPlanes(Camera camera, Plane[] planes)
		{
		}

		public static void CalculateFrustumPlanes(Matrix4x4 worldToProjectionMatrix, Plane[] planes)
		{
		}

		public static bool TestPlanesAABB(Plane[] planes, Bounds bounds)
		{
			return false;
		}

		[NativeName("ExtractPlanes")]
		private static void Internal_ExtractPlanes([Out] Plane[] planes, Matrix4x4 worldToProjectionMatrix)
		{
		}

		private static bool TestPlanesAABB_Injected(Plane[] planes, ref Bounds bounds)
		{
			return false;
		}

		private static void Internal_ExtractPlanes_Injected([Out] Plane[] planes, ref Matrix4x4 worldToProjectionMatrix)
		{
		}
	}
}
