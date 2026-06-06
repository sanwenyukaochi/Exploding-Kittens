using System.Globalization;
using System.Runtime.Versioning;

namespace System
{
	[Serializable]
	public readonly struct Int16 : IComparable, IConvertible, IFormattable, IComparable<short>, IEquatable<short>, ISpanFormattable
	{
		private readonly short m_value;

		public const short MaxValue = 32767;

		public const short MinValue = -32768;

		public int CompareTo(object value)
		{
			return 0;
		}

		public int CompareTo(short value)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		[NonVersionable]
		public bool Equals(short obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}

		public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format = default(ReadOnlySpan<char>), IFormatProvider provider = null)
		{
			charsWritten = default(int);
			return false;
		}

		public static short Parse(string s, IFormatProvider provider)
		{
			return 0;
		}

		public static short Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			return 0;
		}

		private static short Parse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info)
		{
			return 0;
		}

		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out short result)
		{
			result = default(short);
			return false;
		}

		private static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, NumberFormatInfo info, out short result)
		{
			result = default(short);
			return false;
		}

		public TypeCode GetTypeCode()
		{
			return default(TypeCode);
		}

		bool IConvertible.ToBoolean(IFormatProvider provider)
		{
			return false;
		}

		char IConvertible.ToChar(IFormatProvider provider)
		{
			return '\0';
		}

		sbyte IConvertible.ToSByte(IFormatProvider provider)
		{
			return 0;
		}

		byte IConvertible.ToByte(IFormatProvider provider)
		{
			return 0;
		}

		short IConvertible.ToInt16(IFormatProvider provider)
		{
			return 0;
		}

		ushort IConvertible.ToUInt16(IFormatProvider provider)
		{
			return 0;
		}

		int IConvertible.ToInt32(IFormatProvider provider)
		{
			return 0;
		}

		uint IConvertible.ToUInt32(IFormatProvider provider)
		{
			return 0u;
		}

		long IConvertible.ToInt64(IFormatProvider provider)
		{
			return 0L;
		}

		ulong IConvertible.ToUInt64(IFormatProvider provider)
		{
			return 0uL;
		}

		float IConvertible.ToSingle(IFormatProvider provider)
		{
			return 0f;
		}

		double IConvertible.ToDouble(IFormatProvider provider)
		{
			return 0.0;
		}

		decimal IConvertible.ToDecimal(IFormatProvider provider)
		{
			return default(decimal);
		}

		DateTime IConvertible.ToDateTime(IFormatProvider provider)
		{
			return default(DateTime);
		}

		object IConvertible.ToType(Type type, IFormatProvider provider)
		{
			return null;
		}
	}
}
