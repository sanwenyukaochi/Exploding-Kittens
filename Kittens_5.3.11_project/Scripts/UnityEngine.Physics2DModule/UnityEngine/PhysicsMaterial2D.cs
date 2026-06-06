using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/Public/PhysicsMaterial2D.h")]
	public sealed class PhysicsMaterial2D : Object
	{
		[NativeMethod("Create_Binding")]
		private static void Create_Internal([Writable] PhysicsMaterial2D scriptMaterial, string name)
		{
		}
	}
}
