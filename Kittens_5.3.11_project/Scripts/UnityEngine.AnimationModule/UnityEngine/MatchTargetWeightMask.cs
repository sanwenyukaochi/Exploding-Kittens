using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/Animation/Animator.h")]
	public struct MatchTargetWeightMask
	{
		private Vector3 m_PositionXYZWeight;

		private float m_RotationWeight;

		public Vector3 positionXYZWeight
		{
			set
			{
			}
		}

		public float rotationWeight
		{
			set
			{
			}
		}
	}
}
