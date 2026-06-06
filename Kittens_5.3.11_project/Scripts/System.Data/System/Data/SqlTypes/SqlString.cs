using System.Globalization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlString : INullable, IComparable, IXmlSerializable
	{
		private string m_value;

		private CompareInfo m_cmpInfo;

		private int m_lcid;

		private SqlCompareOptions m_flag;

		private bool m_fNotNull;

		public static readonly SqlString Null;

		internal static readonly UnicodeEncoding s_unicodeEncoding;

		public static readonly int IgnoreCase;

		public static readonly int IgnoreWidth;

		public static readonly int IgnoreNonSpace;

		public static readonly int IgnoreKanaType;

		public static readonly int BinarySort;

		public static readonly int BinarySort2;

		private static readonly SqlCompareOptions s_iDefaultFlag;

		private static readonly CompareOptions s_iValidCompareOptionMask;

		internal static readonly SqlCompareOptions s_iValidSqlCompareOptionMask;

		internal static readonly int s_lcidUSEnglish;

		private static readonly int s_lcidBinary;

		public bool IsNull => false;

		public string Value => null;

		private SqlString(bool fNull)
		{
			m_value = null;
			m_cmpInfo = null;
			m_lcid = 0;
			m_flag = default(SqlCompareOptions);
			m_fNotNull = false;
		}

		public SqlString(string data, int lcid, SqlCompareOptions compareOptions)
		{
			m_value = null;
			m_cmpInfo = null;
			m_lcid = 0;
			m_flag = default(SqlCompareOptions);
			m_fNotNull = false;
		}

		public SqlString(string data)
		{
			m_value = null;
			m_cmpInfo = null;
			m_lcid = 0;
			m_flag = default(SqlCompareOptions);
			m_fNotNull = false;
		}

		private SqlString(int lcid, SqlCompareOptions compareOptions, string data, CompareInfo cmpInfo)
		{
			m_value = null;
			m_cmpInfo = null;
			m_lcid = 0;
			m_flag = default(SqlCompareOptions);
			m_fNotNull = false;
		}

		private void SetCompareInfo()
		{
		}

		public static implicit operator SqlString(string x)
		{
			return default(SqlString);
		}

		public override string ToString()
		{
			return null;
		}

		public static SqlString operator +(SqlString x, SqlString y)
		{
			return default(SqlString);
		}

		private static int StringCompare(SqlString x, SqlString y)
		{
			return 0;
		}

		private static SqlBoolean Compare(SqlString x, SqlString y, EComparison ecExpectedResult)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator ==(SqlString x, SqlString y)
		{
			return default(SqlBoolean);
		}

		private static void ValidateSqlCompareOptions(SqlCompareOptions compareOptions)
		{
		}

		public static CompareOptions CompareOptionsFromSqlCompareOptions(SqlCompareOptions compareOptions)
		{
			return default(CompareOptions);
		}

		private bool FBinarySort()
		{
			return false;
		}

		private static int CompareBinary(SqlString x, SqlString y)
		{
			return 0;
		}

		private static int CompareBinary2(SqlString x, SqlString y)
		{
			return 0;
		}

		public int CompareTo(object value)
		{
			return 0;
		}

		public int CompareTo(SqlString value)
		{
			return 0;
		}

		public override bool Equals(object value)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		void IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		public static XmlQualifiedName GetXsdType(XmlSchemaSet schemaSet)
		{
			return null;
		}
	}
}
