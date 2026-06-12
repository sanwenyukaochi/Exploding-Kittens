using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/Public/PolygonCollider2D.h")]
	public sealed class PolygonCollider2D : Collider2D
	{
		public Vector2[] points
		{
			[NativeMethod("GetPoints_Binding")]
			get
			{
				return null;
			}
			[NativeMethod("SetPoints_Binding")]
			set
			{
			}
		}

		public void SetPath(int index, Vector2[] points)
		{
		}

		[NativeMethod("SetPath_Binding")]
		private void SetPath_Internal(int index, [NotNull("ArgumentNullException")] Vector2[] points)
		{
		}
	}
}
