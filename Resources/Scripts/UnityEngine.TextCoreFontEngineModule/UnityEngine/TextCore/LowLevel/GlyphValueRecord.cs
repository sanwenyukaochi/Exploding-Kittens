using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	[Serializable]
	[UsedByNativeCode]
	public struct GlyphValueRecord : IEquatable<GlyphValueRecord>
	{
		[NativeName("xPlacement")]
		[SerializeField]
		private float m_XPlacement;

		[NativeName("yPlacement")]
		[SerializeField]
		private float m_YPlacement;

		[SerializeField]
		[NativeName("xAdvance")]
		private float m_XAdvance;

		[SerializeField]
		[NativeName("yAdvance")]
		private float m_YAdvance;

		public float xPlacement
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float yPlacement
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float xAdvance => 0f;

		public float yAdvance => 0f;

		public static GlyphValueRecord operator +(GlyphValueRecord a, GlyphValueRecord b)
		{
			return default(GlyphValueRecord);
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(GlyphValueRecord other)
		{
			return false;
		}
	}
}
