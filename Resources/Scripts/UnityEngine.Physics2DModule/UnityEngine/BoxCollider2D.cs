using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/Public/BoxCollider2D.h")]
	public sealed class BoxCollider2D : Collider2D
	{
		public Vector2 size
		{
			set
			{
			}
		}

		[SpecialName]
		private void set_size_Injected(ref Vector2 value)
		{
		}
	}
}
