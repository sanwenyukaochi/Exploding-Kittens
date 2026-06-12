using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/WheelJoint2D.h")]
	public sealed class WheelJoint2D : AnchoredJoint2D
	{
		public JointSuspension2D suspension
		{
			get
			{
				return default(JointSuspension2D);
			}
			set
			{
			}
		}

		public bool useMotor
		{
			set
			{
			}
		}

		public JointMotor2D motor
		{
			get
			{
				return default(JointMotor2D);
			}
			set
			{
			}
		}

		[SpecialName]
		private void get_suspension_Injected(out JointSuspension2D ret)
		{
			ret = default(JointSuspension2D);
		}

		[SpecialName]
		private void set_suspension_Injected(ref JointSuspension2D value)
		{
		}

		[SpecialName]
		private void get_motor_Injected(out JointMotor2D ret)
		{
			ret = default(JointMotor2D);
		}

		[SpecialName]
		private void set_motor_Injected(ref JointMotor2D value)
		{
		}
	}
}
