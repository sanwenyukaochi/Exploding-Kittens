using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Modules/Physics/Rigidbody.h")]
	public class Rigidbody : Component
	{
		public Vector3 velocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 angularVelocity
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float drag
		{
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

		public bool useGravity
		{
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

		public bool freezeRotation
		{
			set
			{
			}
		}

		public RigidbodyConstraints constraints
		{
			set
			{
			}
		}

		public Vector3 position => default(Vector3);

		public void MovePosition(Vector3 position)
		{
		}

		public void MoveRotation(Quaternion rot)
		{
		}

		public void Sleep()
		{
		}

		public bool IsSleeping()
		{
			return false;
		}

		public void WakeUp()
		{
		}

		public void AddForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		[ExcludeFromDocs]
		public void AddForce(Vector3 force)
		{
		}

		public void AddRelativeForce(Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		public void AddTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		public void AddRelativeTorque(Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		public void AddForceAtPosition(Vector3 force, Vector3 position, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		public void AddExplosionForce(float explosionForce, Vector3 explosionPosition, float explosionRadius, [DefaultValue("0.0f")] float upwardsModifier, [DefaultValue("ForceMode.Force)")] ForceMode mode)
		{
		}

		[SpecialName]
		private void get_velocity_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		[SpecialName]
		private void set_velocity_Injected(ref Vector3 value)
		{
		}

		[SpecialName]
		private void get_angularVelocity_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		[SpecialName]
		private void set_angularVelocity_Injected(ref Vector3 value)
		{
		}

		[SpecialName]
		private void get_position_Injected(out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private void MovePosition_Injected(ref Vector3 position)
		{
		}

		private void MoveRotation_Injected(ref Quaternion rot)
		{
		}

		private void AddForce_Injected(ref Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		private void AddRelativeForce_Injected(ref Vector3 force, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		private void AddTorque_Injected(ref Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		private void AddRelativeTorque_Injected(ref Vector3 torque, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, [DefaultValue("ForceMode.Force")] ForceMode mode)
		{
		}

		private void AddExplosionForce_Injected(float explosionForce, ref Vector3 explosionPosition, float explosionRadius, [DefaultValue("0.0f")] float upwardsModifier, [DefaultValue("ForceMode.Force)")] ForceMode mode)
		{
		}
	}
}
