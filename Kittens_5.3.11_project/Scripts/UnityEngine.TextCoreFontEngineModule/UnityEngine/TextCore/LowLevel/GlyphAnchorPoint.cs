using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	[Serializable]
	[UsedByNativeCode]
	internal struct GlyphAnchorPoint
	{
		[SerializeField]
		[NativeName("xPositionAdjustment")]
		private float m_XCoordinate;

		[SerializeField]
		[NativeName("yPositionAdjustment")]
		private float m_YCoordinate;

		public float xCoordinate => 0f;

		public float yCoordinate => 0f;
	}
}
