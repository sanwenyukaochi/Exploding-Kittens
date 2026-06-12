using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/Physics2D/Public/Rigidbody2D.h")]
	public sealed class Rigidbody2D : Component
	{
		public Vector2 position => default(Vector2);

		public Vector2 velocity
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float angularVelocity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float mass
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float gravityScale
		{
			set
			{
			}
		}

		public RigidbodyType2D bodyType
		{
			get
			{
				return default(RigidbodyType2D);
			}
			[NativeMethod("SetBodyType_Binding")]
			set
			{
			}
		}

		public bool isKinematic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public RigidbodyConstraints2D constraints
		{
			get
			{
				return default(RigidbodyConstraints2D);
			}
			set
			{
			}
		}

		public void MovePosition(Vector2 position)
		{
		}

		public bool IsSleeping()
		{
			return false;
		}

		public void Sleep()
		{
		}

		[NativeMethod("Wake")]
		public void WakeUp()
		{
		}

		[ExcludeFromDocs]
		public void AddForce(Vector2 force)
		{
		}

		public void AddForce(Vector2 force, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
		}

		public void AddRelativeForce(Vector2 relativeForce, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
		}

		public void AddForceAtPosition(Vector2 force, Vector2 position, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
		}

		public void AddTorque(float torque, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
		}

		[SpecialName]
		private void get_position_Injected(out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private void MovePosition_Injected(ref Vector2 position)
		{
		}

		[SpecialName]
		private void get_velocity_Injected(out Vector2 ret)
		{
			ret = default(Vector2);
		}

		[SpecialName]
		private void set_velocity_Injected(ref Vector2 value)
		{
		}

		private void AddForce_Injected(ref Vector2 force, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
		}

		private void AddRelativeForce_Injected(ref Vector2 relativeForce, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
		}

		private void AddForceAtPosition_Injected(ref Vector2 force, ref Vector2 position, [DefaultValue("ForceMode2D.Force")] ForceMode2D mode)
		{
		}
	}
}
