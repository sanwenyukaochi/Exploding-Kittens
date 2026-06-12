using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Physics2D/HingeJoint2D.h")]
	public sealed class HingeJoint2D : AnchoredJoint2D
	{
		public bool useMotor
		{
			set
			{
			}
		}

		public bool useLimits
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

		public JointAngleLimits2D limits
		{
			get
			{
				return default(JointAngleLimits2D);
			}
			set
			{
			}
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

		[SpecialName]
		private void get_limits_Injected(out JointAngleLimits2D ret)
		{
			ret = default(JointAngleLimits2D);
		}

		[SpecialName]
		private void set_limits_Injected(ref JointAngleLimits2D value)
		{
		}
	}
}
