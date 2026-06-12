using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[StaticAccessor("GizmoBindings", StaticAccessorType.DoubleColon)]
	[NativeHeader("Runtime/Export/Gizmos/Gizmos.bindings.h")]
	public sealed class Gizmos
	{
		public static Color color
		{
			set
			{
			}
		}

		[NativeThrows]
		public static void DrawLine(Vector3 from, Vector3 to)
		{
		}

		[NativeThrows]
		public static void DrawWireSphere(Vector3 center, float radius)
		{
		}

		[NativeThrows]
		public static void DrawSphere(Vector3 center, float radius)
		{
		}

		[NativeThrows]
		public static void DrawWireCube(Vector3 center, Vector3 size)
		{
		}

		[NativeThrows]
		public static void DrawCube(Vector3 center, Vector3 size)
		{
		}

		[NativeThrows]
		public static void DrawIcon(Vector3 center, string name, [DefaultValue("true")] bool allowScaling)
		{
		}

		[NativeThrows]
		public static void DrawIcon(Vector3 center, string name, [DefaultValue("true")] bool allowScaling, [DefaultValue("Color(255,255,255,255)")] Color tint)
		{
		}

		[ExcludeFromDocs]
		public static void DrawIcon(Vector3 center, string name)
		{
		}

		private static void DrawLine_Injected(ref Vector3 from, ref Vector3 to)
		{
		}

		private static void DrawWireSphere_Injected(ref Vector3 center, float radius)
		{
		}

		private static void DrawSphere_Injected(ref Vector3 center, float radius)
		{
		}

		private static void DrawWireCube_Injected(ref Vector3 center, ref Vector3 size)
		{
		}

		private static void DrawCube_Injected(ref Vector3 center, ref Vector3 size)
		{
		}

		private static void DrawIcon_Injected(ref Vector3 center, string name, [DefaultValue("true")] bool allowScaling, [DefaultValue("Color(255,255,255,255)")] ref Color tint)
		{
		}

		[SpecialName]
		private static void set_color_Injected(ref Color value)
		{
		}
	}
}
