using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	[Serializable]
	[UsedByNativeCode]
	internal struct MarkToMarkAdjustmentRecord
	{
		[SerializeField]
		[NativeName("baseMarkGlyphID")]
		private uint m_BaseMarkGlyphID;

		[NativeName("baseMarkAnchor")]
		[SerializeField]
		private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint;

		[NativeName("combiningMarkGlyphID")]
		[SerializeField]
		private uint m_CombiningMarkGlyphID;

		[NativeName("combiningMarkPositionAdjustment")]
		[SerializeField]
		private MarkPositionAdjustment m_CombiningMarkPositionAdjustment;

		public uint baseMarkGlyphID => 0u;

		public GlyphAnchorPoint baseMarkGlyphAnchorPoint => default(GlyphAnchorPoint);

		public uint combiningMarkGlyphID => 0u;

		public MarkPositionAdjustment combiningMarkPositionAdjustment => default(MarkPositionAdjustment);
	}
}
