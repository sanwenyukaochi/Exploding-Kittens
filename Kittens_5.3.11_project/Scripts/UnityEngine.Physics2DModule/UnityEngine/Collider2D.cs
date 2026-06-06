using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode(Optional = true)]
	[NativeHeader("Modules/Physics2D/Public/Collider2D.h")]
	[RequireComponent(typeof(Transform))]
	public class Collider2D : Behaviour
	{
		public bool isTrigger
		{
			set
			{
			}
		}

		public Vector2 offset
		{
			set
			{
			}
		}

		public Rigidbody2D attachedRigidbody
		{
			[NativeMethod("GetAttachedRigidbody_Binding")]
			get
			{
				return null;
			}
		}

		public int shapeCount => 0;

		public PhysicsMaterial2D sharedMaterial
		{
			[NativeMethod("GetMaterial")]
			get
			{
				return null;
			}
		}

		[SpecialName]
		private void set_offset_Injected(ref Vector2 value)
		{
		}
	}
}
