using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics/CharacterController.h")]
	public class CharacterController : Collider
	{
		public bool isGrounded
		{
			[NativeName("IsGrounded")]
			get
			{
				return false;
			}
		}

		public CollisionFlags collisionFlags => default(CollisionFlags);

		public float radius
		{
			set
			{
			}
		}

		public float height
		{
			set
			{
			}
		}

		public Vector3 center
		{
			set
			{
			}
		}

		public float slopeLimit
		{
			set
			{
			}
		}

		public float stepOffset
		{
			set
			{
			}
		}

		public bool detectCollisions
		{
			set
			{
			}
		}

		public bool SimpleMove(Vector3 speed)
		{
			return false;
		}

		public CollisionFlags Move(Vector3 motion)
		{
			return default(CollisionFlags);
		}

		private bool SimpleMove_Injected(ref Vector3 speed)
		{
			return false;
		}

		private CollisionFlags Move_Injected(ref Vector3 motion)
		{
			return default(CollisionFlags);
		}

		[SpecialName]
		private void set_center_Injected(ref Vector3 value)
		{
		}
	}
}
