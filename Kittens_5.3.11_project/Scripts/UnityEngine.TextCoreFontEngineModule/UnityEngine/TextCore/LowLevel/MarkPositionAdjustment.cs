using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	[Serializable]
	[UsedByNativeCode]
	internal struct MarkPositionAdjustment
	{
		[SerializeField]
		[NativeName("xCoordinate")]
		private float m_XPositionAdjustment;

		[SerializeField]
		[NativeName("yCoordinate")]
		private float m_YPositionAdjustment;

		public float xPositionAdjustment => 0f;

		public float yPositionAdjustment => 0f;
	}
}
