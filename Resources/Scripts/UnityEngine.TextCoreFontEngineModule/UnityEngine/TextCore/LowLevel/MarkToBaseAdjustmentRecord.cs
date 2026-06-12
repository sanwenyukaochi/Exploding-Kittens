using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	[Serializable]
	[UsedByNativeCode]
	internal struct MarkToBaseAdjustmentRecord
	{
		[SerializeField]
		[NativeName("baseGlyphID")]
		private uint m_BaseGlyphID;

		[SerializeField]
		[NativeName("baseAnchor")]
		private GlyphAnchorPoint m_BaseGlyphAnchorPoint;

		[SerializeField]
		[NativeName("markGlyphID")]
		private uint m_MarkGlyphID;

		[SerializeField]
		[NativeName("markPositionAdjustment")]
		private MarkPositionAdjustment m_MarkPositionAdjustment;

		public uint baseGlyphID => 0u;

		public GlyphAnchorPoint baseGlyphAnchorPoint => default(GlyphAnchorPoint);

		public uint markGlyphID => 0u;

		public MarkPositionAdjustment markPositionAdjustment => default(MarkPositionAdjustment);
	}
}
