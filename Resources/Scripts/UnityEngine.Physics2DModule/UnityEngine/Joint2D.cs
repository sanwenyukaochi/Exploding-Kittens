using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform), typeof(Rigidbody2D))]
	[NativeHeader("Modules/Physics2D/Joint2D.h")]
	public class Joint2D : Behaviour
	{
		public Rigidbody2D connectedBody
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2 reactionForce
		{
			[NativeMethod("GetReactionForceFixedTime")]
			get
			{
				return default(Vector2);
			}
		}

		public float reactionTorque
		{
			[NativeMethod("GetReactionTorqueFixedTime")]
			get
			{
				return 0f;
			}
		}

		[SpecialName]
		private void get_reactionForce_Injected(out Vector2 ret)
		{
			ret = default(Vector2);
		}
	}
}
