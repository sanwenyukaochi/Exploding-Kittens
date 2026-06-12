using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Data.SqlTypes
{
	[Serializable]
	[XmlSchemaProvider("GetXsdType")]
	public struct SqlDecimal : INullable, IComparable, IXmlSerializable
	{
		internal byte _bStatus;

		internal byte _bLen;

		internal byte _bPrec;

		internal byte _bScale;

		internal uint _data1;

		internal uint _data2;

		internal uint _data3;

		internal uint _data4;

		private static readonly byte s_NUMERIC_MAX_PRECISION;

		public static readonly byte MaxPrecision;

		public static readonly byte MaxScale;

		private static readonly byte s_bNullMask;

		private static readonly byte s_bIsNull;

		private static readonly byte s_bNotNull;

		private static readonly byte s_bReverseNullMask;

		private static readonly byte s_bSignMask;

		private static readonly byte s_bPositive;

		private static readonly byte s_bNegative;

		private static readonly byte s_bReverseSignMask;

		private static readonly uint s_uiZero;

		private static readonly int s_cNumeMax;

		private static readonly long s_lInt32Base;

		private static readonly ulong s_ulInt32Base;

		private static readonly ulong s_ulInt32BaseForMod;

		internal static readonly ulong s_llMax;

		private static readonly uint s_ulBase10;

		private static readonly double s_DUINT_BASE;

		private static readonly double s_DUINT_BASE2;

		private static readonly double s_DUINT_BASE3;

		private static readonly double s_DMAX_NUME;

		private static readonly uint s_DBL_DIG;

		private static readonly byte s_cNumeDivScaleMin;

		private static readonly uint[] s_rgulShiftBase;

		private static readonly uint[] s_decimalHelpersLo;

		private static readonly uint[] s_decimalHelpersMid;

		private static readonly uint[] s_decimalHelpersHi;

		private static readonly uint[] s_decimalHelpersHiHi;

		private static readonly byte[] s_rgCLenFromPrec;

		private static readonly uint s_ulT1;

		private static readonly uint s_ulT2;

		private static readonly uint s_ulT3;

		private static readonly uint s_ulT4;

		private static readonly uint s_ulT5;

		private static readonly uint s_ulT6;

		private static readonly uint s_ulT7;

		private static readonly uint s_ulT8;

		private static readonly uint s_ulT9;

		private static readonly ulong s_dwlT10;

		private static readonly ulong s_dwlT11;

		private static readonly ulong s_dwlT12;

		private static readonly ulong s_dwlT13;

		private static readonly ulong s_dwlT14;

		private static readonly ulong s_dwlT15;

		private static readonly ulong s_dwlT16;

		private static readonly ulong s_dwlT17;

		private static readonly ulong s_dwlT18;

		private static readonly ulong s_dwlT19;

		public static readonly SqlDecimal Null;

		public static readonly SqlDecimal MinValue;

		public static readonly SqlDecimal MaxValue;

		public bool IsNull => false;

		public decimal Value => default(decimal);

		public bool IsPositive => false;

		public byte Scale => 0;

		public int[] Data => null;

		private byte CalculatePrecision()
		{
			return 0;
		}

		private bool VerifyPrecision(byte precision)
		{
			return false;
		}

		private SqlDecimal(bool fNull)
		{
			_bStatus = 0;
			_bLen = 0;
			_bPrec = 0;
			_bScale = 0;
			_data1 = 0u;
			_data2 = 0u;
			_data3 = 0u;
			_data4 = 0u;
		}

		public SqlDecimal(decimal value)
		{
			_bStatus = 0;
			_bLen = 0;
			_bPrec = 0;
			_bScale = 0;
			_data1 = 0u;
			_data2 = 0u;
			_data3 = 0u;
			_data4 = 0u;
		}

		public SqlDecimal(int value)
		{
			_bStatus = 0;
			_bLen = 0;
			_bPrec = 0;
			_bScale = 0;
			_data1 = 0u;
			_data2 = 0u;
			_data3 = 0u;
			_data4 = 0u;
		}

		public SqlDecimal(long value)
		{
			_bStatus = 0;
			_bLen = 0;
			_bPrec = 0;
			_bScale = 0;
			_data1 = 0u;
			_data2 = 0u;
			_data3 = 0u;
			_data4 = 0u;
		}

		private SqlDecimal(uint[] rglData, byte bLen, byte bPrec, byte bScale, bool fPositive)
		{
			_bStatus = 0;
			_bLen = 0;
			_bPrec = 0;
			_bScale = 0;
			_data1 = 0u;
			_data2 = 0u;
			_data3 = 0u;
			_data4 = 0u;
		}

		private void SetPositive()
		{
		}

		private void SetSignBit(bool fPositive)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static SqlDecimal Parse(string s)
		{
			return default(SqlDecimal);
		}

		public double ToDouble()
		{
			return 0.0;
		}

		private decimal ToDecimal()
		{
			return default(decimal);
		}

		public static implicit operator SqlDecimal(decimal x)
		{
			return default(SqlDecimal);
		}

		public static implicit operator SqlDecimal(long x)
		{
			return default(SqlDecimal);
		}

		public static SqlDecimal operator -(SqlDecimal x)
		{
			return default(SqlDecimal);
		}

		public static SqlDecimal operator +(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlDecimal);
		}

		public static SqlDecimal operator -(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlDecimal);
		}

		public static SqlDecimal operator *(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlDecimal);
		}

		public static SqlDecimal operator /(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlDecimal);
		}

		public static implicit operator SqlDecimal(SqlByte x)
		{
			return default(SqlDecimal);
		}

		public static implicit operator SqlDecimal(SqlInt16 x)
		{
			return default(SqlDecimal);
		}

		public static implicit operator SqlDecimal(SqlInt32 x)
		{
			return default(SqlDecimal);
		}

		public static implicit operator SqlDecimal(SqlInt64 x)
		{
			return default(SqlDecimal);
		}

		public static implicit operator SqlDecimal(SqlMoney x)
		{
			return default(SqlDecimal);
		}

		private static void ZeroToMaxLen(uint[] rgulData, int cUI4sCur)
		{
		}

		private bool FZero()
		{
			return false;
		}

		private bool FGt10_38()
		{
			return false;
		}

		private bool FGt10_38(uint[] rglData)
		{
			return false;
		}

		private static byte BGetPrecUI4(uint value)
		{
			return 0;
		}

		private static byte BGetPrecUI8(ulong dwlVal)
		{
			return 0;
		}

		private void AddULong(uint ulAdd)
		{
		}

		private void MultByULong(uint uiMultiplier)
		{
		}

		private uint DivByULong(uint iDivisor)
		{
			return 0u;
		}

		internal void AdjustScale(int digits, bool fRound)
		{
		}

		private int LAbsCmp(SqlDecimal snumOp)
		{
			return 0;
		}

		private static void MpMove(uint[] rgulS, int ciulS, uint[] rgulD, out int ciulD)
		{
			ciulD = default(int);
		}

		private static void MpSet(uint[] rgulD, out int ciulD, uint iulN)
		{
			ciulD = default(int);
		}

		private static void MpNormalize(uint[] rgulU, ref int ciulU)
		{
		}

		private static void MpMul1(uint[] piulD, ref int ciulD, uint iulX)
		{
		}

		private static void MpDiv1(uint[] rgulU, ref int ciulU, uint iulD, out uint iulR)
		{
			iulR = default(uint);
		}

		internal static ulong DWL(uint lo, uint hi)
		{
			return 0uL;
		}

		private static uint HI(ulong x)
		{
			return 0u;
		}

		private static uint LO(ulong x)
		{
			return 0u;
		}

		private static void MpDiv(uint[] rgulU, int ciulU, uint[] rgulD, int ciulD, uint[] rgulQ, out int ciulQ, uint[] rgulR, out int ciulR)
		{
			ciulQ = default(int);
			ciulR = default(int);
		}

		private EComparison CompareNm(SqlDecimal snumOp)
		{
			return default(EComparison);
		}

		private static void CheckValidPrecScale(byte bPrec, byte bScale)
		{
		}

		public static SqlBoolean operator ==(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator <(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean operator >(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean LessThan(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlBoolean);
		}

		public static SqlBoolean GreaterThan(SqlDecimal x, SqlDecimal y)
		{
			return default(SqlBoolean);
		}

		public SqlDouble ToSqlDouble()
		{
			return default(SqlDouble);
		}

		public SqlInt64 ToSqlInt64()
		{
			return default(SqlInt64);
		}

		public SqlMoney ToSqlMoney()
		{
			return default(SqlMoney);
		}

		private static char ChFromDigit(uint uiDigit)
		{
			return '\0';
		}

		private void StoreFromWorkingArray(uint[] rguiData)
		{
		}

		private void SetToZero()
		{
		}

		public int CompareTo(object value)
		{
			return 0;
		}

		public int CompareTo(SqlDecimal value)
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
