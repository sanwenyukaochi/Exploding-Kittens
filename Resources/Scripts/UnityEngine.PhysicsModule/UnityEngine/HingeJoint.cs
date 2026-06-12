using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeClass("Unity::HingeJoint")]
	[NativeHeader("Modules/Physics/HingeJoint.h")]
	public class HingeJoint : Joint
	{
		public JointLimits limits
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

		[SpecialName]
		private void set_limits_Injected(ref JointLimits value)
		{
		}
	}
}
