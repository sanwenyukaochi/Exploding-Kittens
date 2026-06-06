using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace TMPro
{
	[Serializable]
	public class KerningPair
	{
		[SerializeField]
		[FormerlySerializedAs("AscII_Left")]
		private uint m_FirstGlyph;

		[SerializeField]
		private GlyphValueRecord_Legacy m_FirstGlyphAdjustments;

		[FormerlySerializedAs("AscII_Right")]
		[SerializeField]
		private uint m_SecondGlyph;

		[SerializeField]
		private GlyphValueRecord_Legacy m_SecondGlyphAdjustments;

		[FormerlySerializedAs("XadvanceOffset")]
		public float xOffset;

		internal static KerningPair empty;

		[SerializeField]
		private bool m_IgnoreSpacingAdjustments;

		public uint firstGlyph => 0u;

		public GlyphValueRecord_Legacy firstGlyphAdjustments => default(GlyphValueRecord_Legacy);

		public uint secondGlyph => 0u;

		public GlyphValueRecord_Legacy secondGlyphAdjustments => default(GlyphValueRecord_Legacy);

		public KerningPair()
		{
		}

		public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments)
		{
		}
	}
}
