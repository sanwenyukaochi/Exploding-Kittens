using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore
{
	[Serializable]
	[UsedByNativeCode]
	public struct FaceInfo
	{
		[SerializeField]
		[NativeName("faceIndex")]
		private int m_FaceIndex;

		[SerializeField]
		[NativeName("familyName")]
		private string m_FamilyName;

		[NativeName("styleName")]
		[SerializeField]
		private string m_StyleName;

		[SerializeField]
		[NativeName("pointSize")]
		private int m_PointSize;

		[SerializeField]
		[NativeName("scale")]
		private float m_Scale;

		[NativeName("unitsPerEM")]
		[SerializeField]
		private int m_UnitsPerEM;

		[NativeName("lineHeight")]
		[SerializeField]
		private float m_LineHeight;

		[SerializeField]
		[NativeName("ascentLine")]
		private float m_AscentLine;

		[SerializeField]
		[NativeName("capLine")]
		private float m_CapLine;

		[NativeName("meanLine")]
		[SerializeField]
		private float m_MeanLine;

		[SerializeField]
		[NativeName("baseline")]
		private float m_Baseline;

		[NativeName("descentLine")]
		[SerializeField]
		private float m_DescentLine;

		[SerializeField]
		[NativeName("superscriptOffset")]
		private float m_SuperscriptOffset;

		[NativeName("superscriptSize")]
		[SerializeField]
		private float m_SuperscriptSize;

		[SerializeField]
		[NativeName("subscriptOffset")]
		private float m_SubscriptOffset;

		[SerializeField]
		[NativeName("subscriptSize")]
		private float m_SubscriptSize;

		[NativeName("underlineOffset")]
		[SerializeField]
		private float m_UnderlineOffset;

		[NativeName("underlineThickness")]
		[SerializeField]
		private float m_UnderlineThickness;

		[NativeName("strikethroughOffset")]
		[SerializeField]
		private float m_StrikethroughOffset;

		[SerializeField]
		[NativeName("strikethroughThickness")]
		private float m_StrikethroughThickness;

		[NativeName("tabWidth")]
		[SerializeField]
		private float m_TabWidth;

		internal int faceIndex => 0;

		public string familyName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string styleName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int pointSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float scale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float lineHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float ascentLine
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float capLine
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float meanLine
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float baseline
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float descentLine
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float superscriptOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float superscriptSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float subscriptOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float subscriptSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float underlineOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float underlineThickness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float strikethroughOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float strikethroughThickness
		{
			set
			{
			}
		}

		public float tabWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
