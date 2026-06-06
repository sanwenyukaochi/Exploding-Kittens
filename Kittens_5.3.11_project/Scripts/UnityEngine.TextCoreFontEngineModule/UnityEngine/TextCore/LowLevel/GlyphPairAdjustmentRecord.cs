using System;
using System.Diagnostics;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	[Serializable]
	[UsedByNativeCode]
	[DebuggerDisplay("First glyphIndex = {m_FirstAdjustmentRecord.m_GlyphIndex},  Second glyphIndex = {m_SecondAdjustmentRecord.m_GlyphIndex}")]
	public struct GlyphPairAdjustmentRecord : IEquatable<GlyphPairAdjustmentRecord>
	{
		[SerializeField]
		[NativeName("firstAdjustmentRecord")]
		private GlyphAdjustmentRecord m_FirstAdjustmentRecord;

		[SerializeField]
		[NativeName("secondAdjustmentRecord")]
		private GlyphAdjustmentRecord m_SecondAdjustmentRecord;

		[SerializeField]
		private FontFeatureLookupFlags m_FeatureLookupFlags;

		public GlyphAdjustmentRecord firstAdjustmentRecord => default(GlyphAdjustmentRecord);

		public GlyphAdjustmentRecord secondAdjustmentRecord => default(GlyphAdjustmentRecord);

		public FontFeatureLookupFlags featureLookupFlags => default(FontFeatureLookupFlags);

		[ExcludeFromDocs]
		public override int GetHashCode()
		{
			return 0;
		}

		[ExcludeFromDocs]
		public override bool Equals(object obj)
		{
			return false;
		}

		[ExcludeFromDocs]
		public bool Equals(GlyphPairAdjustmentRecord other)
		{
			return false;
		}
	}
}
