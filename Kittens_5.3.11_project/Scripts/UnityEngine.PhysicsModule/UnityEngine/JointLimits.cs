using System;
using System.ComponentModel;

namespace UnityEngine
{
	public struct JointLimits
	{
		private float m_Min;

		private float m_Max;

		private float m_Bounciness;

		private float m_BounceMinVelocity;

		private float m_ContactDistance;

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("minBounce and maxBounce are replaced by a single JointLimits.bounciness for both limit ends.", true)]
		public float minBounce;

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("minBounce and maxBounce are replaced by a single JointLimits.bounciness for both limit ends.", true)]
		public float maxBounce;

		public float min
		{
			set
			{
			}
		}

		public float max
		{
			set
			{
			}
		}
	}
}
