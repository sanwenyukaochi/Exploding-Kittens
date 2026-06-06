using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	public readonly struct Decimal : IFormattable, IComparable, IConvertible, IComparable<decimal>, IEquatable<decimal>, IDeserializationCallback, ISpanFormattable
	{
		[StructLayout((LayoutKind)2)]
		private struct DecCalc
		{
			internal enum RoundingMode
			{
				ToEven = 0,
				AwayFromZero = 1,
				Truncate = 2,
				Floor = 3,
				Ceiling = 4
			}

			private struct PowerOvfl
			{
				public readonly uint Hi;

				public readonly ulong MidLo;

				public PowerOvfl(uint hi, uint mid, uint lo)
				{
					Hi = 0u;
					MidLo = 0uL;
				}
			}

			[StructLayout((LayoutKind)2)]
			private struct Buf12
			{
				[FieldOffset(0)]
				public uint U0;

				[FieldOffset(4)]
				public uint U1;

				[FieldOffset(8)]
				public uint U2;

				[FieldOffset(0)]
				private ulong ulo64LE;

				[FieldOffset(4)]
				private ulong uhigh64LE;

				public ulong Low64
				{
					get
					{
						return 0uL;
					}
					set
					{
					}
				}

				public ulong High64
				{
					get
					{
						return 0uL;
					}
					set
					{
					}
				}
			}

			[StructLayout((LayoutKind)2)]
			private struct Buf16
			{
				[FieldOffset(0)]
				public uint U0;

				[FieldOffset(4)]
				public uint U1;

				[FieldOffset(8)]
				public uint U2;

				[FieldOffset(12)]
				public uint U3;

				[FieldOffset(0)]
				private ulong ulo64LE;

				[FieldOffset(8)]
				private ulong uhigh64LE;

				public ulong Low64
				{
					get
					{
						return 0uL;
					}
					set
					{
					}
				}

				public ulong High64
				{
					get
					{
						return 0uL;
					}
					set
					{
					}
				}
			}

			[StructLayout((LayoutKind)2)]
			private struct Buf24
			{
				[FieldOffset(0)]
				public uint U0;

				[FieldOffset(4)]
				public uint U1;

				[FieldOffset(8)]
				public uint U2;

				[FieldOffset(12)]
				public uint U3;

				[FieldOffset(16)]
				public uint U4;

				[FieldOffset(20)]
				public uint U5;

				[FieldOffset(0)]
				private ulong ulo64LE;

				[FieldOffset(8)]
				private ulong umid64LE;

				[FieldOffset(16)]
				private ulong uhigh64LE;

				public ulong Low64
				{
					get
					{
						return 0uL;
					}
					set
					{
					}
				}

				public ulong Mid64
				{
					set
					{
					}
				}

				public ulong High64
				{
					set
					{
					}
				}
			}

			[FieldOffset(0)]
			private uint uflags;

			[FieldOffset(4)]
			private uint uhi;

			[FieldOffset(8)]
			private uint ulo;

			[FieldOffset(12)]
			private uint umid;

			[FieldOffset(8)]
			private ulong ulomidLE;

			private static readonly uint[] s_powers10;

			private static readonly ulong[] s_ulongPowers10;

			private static readonly double[] s_doublePowers10;

			private static readonly PowerOvfl[] PowerOvflValues;

			private uint High
			{
				get
				{
					return 0u;
				}
				set
				{
				}
			}

			private uint Low
			{
				get
				{
					return 0u;
				}
				set
				{
				}
			}

			private uint Mid
			{
				get
				{
					return 0u;
				}
				set
				{
				}
			}

			private bool IsNegative => false;

			private ulong Low64
			{
				get
				{
					return 0uL;
				}
				set
				{
				}
			}

			private static uint GetExponent(float f)
			{
				return 0u;
			}

			private static uint GetExponent(double d)
			{
				return 0u;
			}

			private static ulong UInt32x32To64(uint a, uint b)
			{
				return 0uL;
			}

			private static void UInt64x64To128(ulong a, ulong b, ref DecCalc result)
			{
			}

			private static uint Div96By32(ref Buf12 bufNum, uint den)
			{
				return 0u;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private static bool Div96ByConst(ref ulong high64, ref uint low, uint pow)
			{
				return false;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private static void Unscale(ref uint low, ref ulong high64, ref int scale)
			{
			}

			private static uint Div96By64(ref Buf12 bufNum, ulong den)
			{
				return 0u;
			}

			private static uint Div128By96(ref Buf16 bufNum, ref Buf12 bufDen)
			{
				return 0u;
			}

			private static uint IncreaseScale(ref Buf12 bufNum, uint power)
			{
				return 0u;
			}

			private static void IncreaseScale64(ref Buf12 bufNum, uint power)
			{
			}

			private unsafe static int ScaleResult(Buf24* bufRes, uint hiRes, int scale)
			{
				return 0;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private unsafe static uint DivByConst(uint* result, uint hiRes, out uint quotient, out uint remainder, uint power)
			{
				quotient = default(uint);
				remainder = default(uint);
				return 0u;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private static int LeadingZeroCount(uint value)
			{
				return 0;
			}

			private static int OverflowUnscale(ref Buf12 bufQuo, int scale, bool sticky)
			{
				return 0;
			}

			private static int SearchScale(ref Buf12 bufQuo, int scale)
			{
				return 0;
			}

			private static bool Add32To96(ref Buf12 bufNum, uint value)
			{
				return false;
			}

			internal static void DecAddSub(ref DecCalc d1, ref DecCalc d2, bool sign)
			{
			}

			internal static int VarDecCmp(in decimal d1, in decimal d2)
			{
				return 0;
			}

			private static int VarDecCmpSub(in decimal d1, in decimal d2)
			{
				return 0;
			}

			internal static void VarDecMul(ref DecCalc d1, ref DecCalc d2)
			{
			}

			internal static void VarDecFromR4(float input, out DecCalc result)
			{
				result = default(DecCalc);
			}

			internal static void VarDecFromR8(double input, out DecCalc result)
			{
				result = default(DecCalc);
			}

			internal static float VarR4FromDec(in decimal value)
			{
				return 0f;
			}

			internal static double VarR8FromDec(in decimal value)
			{
				return 0.0;
			}

			internal static int GetHashCode(in decimal d)
			{
				return 0;
			}

			internal static void VarDecDiv(ref DecCalc d1, ref DecCalc d2)
			{
			}

			internal static void InternalRound(ref DecCalc d, uint scale, RoundingMode mode)
			{
			}

			internal static uint DecDivMod1E9(ref DecCalc value)
			{
				return 0u;
			}
		}

		private const int SignMask = int.MinValue;

		private const int ScaleMask = 16711680;

		private const int ScaleShift = 16;

		public const decimal Zero = 0m;

		public const decimal One = 1m;

		public const decimal MinusOne = -1m;

		public const decimal MaxValue = 79228162514264337593543950335m;

		public const decimal MinValue = -79228162514264337593543950335m;

		[FieldOffset(0)]
		private readonly int flags;

		[FieldOffset(4)]
		private readonly int hi;

		[FieldOffset(8)]
		private readonly int lo;

		[FieldOffset(12)]
		private readonly int mid;

		[FieldOffset(8)]
		[NonSerialized]
		private readonly ulong ulomidLE;

		internal uint High => 0u;

		internal uint Low => 0u;

		internal uint Mid => 0u;

		internal bool IsNegative => false;

		internal int Scale => 0;

		private ulong Low64 => 0uL;

		private static ref DecCalc AsMutable(ref decimal d)
		{
			throw null;
		}

		internal static uint DecDivMod1E9(ref decimal value)
		{
			return 0u;
		}

		public Decimal(int value)
		{
			flags = 0;
			hi = 0;
			lo = 0;
			mid = 0;
			ulomidLE = 0uL;
		}

		[CLSCompliant(false)]
		public Decimal(uint value)
		{
			flags = 0;
			hi = 0;
			lo = 0;
			mid = 0;
			ulomidLE = 0uL;
		}

		public Decimal(long value)
		{
			flags = 0;
			hi = 0;
			lo = 0;
			mid = 0;
			ulomidLE = 0uL;
		}

		[CLSCompliant(false)]
		public Decimal(ulong value)
		{
			flags = 0;
			hi = 0;
			lo = 0;
			mid = 0;
			ulomidLE = 0uL;
		}

		public Decimal(float value)
		{
			flags = 0;
			hi = 0;
			lo = 0;
			mid = 0;
			ulomidLE = 0uL;
		}

		public Decimal(double value)
		{
			flags = 0;
			hi = 0;
			lo = 0;
			mid = 0;
			ulomidLE = 0uL;
		}

		private static bool IsValid(int flags)
		{
			return false;
		}

		public Decimal(int[] bits)
		{
			flags = 0;
			hi = 0;
			lo = 0;
			mid = 0;
			ulomidLE = 0uL;
		}

		public Decimal(int lo, int mid, int hi, bool isNegative, byte scale)
		{
			flags = 0;
			this.hi = 0;
			this.lo = 0;
			this.mid = 0;
			ulomidLE = 0uL;
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		private Decimal(in decimal d, int flags)
		{
			this.flags = 0;
			hi = 0;
			lo = 0;
			mid = 0;
			ulomidLE = 0uL;
		}

		internal static decimal Abs(ref decimal d)
		{
			return default(decimal);
		}

		public static decimal Add(decimal d1, decimal d2)
		{
			return default(decimal);
		}

		public static int Compare(decimal d1, decimal d2)
		{
			return 0;
		}

		public int CompareTo(object value)
		{
			return 0;
		}

		public int CompareTo(decimal value)
		{
			return 0;
		}

		public static decimal Divide(decimal d1, decimal d2)
		{
			return default(decimal);
		}

		public override bool Equals(object value)
		{
			return false;
		}

		public bool Equals(decimal value)
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

		public static decimal Parse(string s, IFormatProvider provider)
		{
			return default(decimal);
		}

		public static decimal Parse(string s, NumberStyles style, IFormatProvider provider)
		{
			return default(decimal);
		}

		public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out decimal result)
		{
			result = default(decimal);
			return false;
		}

		public static int[] GetBits(decimal d)
		{
			return null;
		}

		internal static ref decimal Max(ref decimal d1, ref decimal d2)
		{
			throw null;
		}

		internal static ref decimal Min(ref decimal d1, ref decimal d2)
		{
			throw null;
		}

		public static decimal Multiply(decimal d1, decimal d2)
		{
			return default(decimal);
		}

		public static decimal Negate(decimal d)
		{
			return default(decimal);
		}

		public static decimal Round(decimal d, int decimals)
		{
			return default(decimal);
		}

		private static decimal Round(ref decimal d, int decimals, MidpointRounding mode)
		{
			return default(decimal);
		}

		public static byte ToByte(decimal value)
		{
			return 0;
		}

		[CLSCompliant(false)]
		public static sbyte ToSByte(decimal value)
		{
			return 0;
		}

		public static short ToInt16(decimal value)
		{
			return 0;
		}

		public static double ToDouble(decimal d)
		{
			return 0.0;
		}

		public static int ToInt32(decimal d)
		{
			return 0;
		}

		public static long ToInt64(decimal d)
		{
			return 0L;
		}

		[CLSCompliant(false)]
		public static ushort ToUInt16(decimal value)
		{
			return 0;
		}

		[CLSCompliant(false)]
		public static uint ToUInt32(decimal d)
		{
			return 0u;
		}

		[CLSCompliant(false)]
		public static ulong ToUInt64(decimal d)
		{
			return 0uL;
		}

		public static float ToSingle(decimal d)
		{
			return 0f;
		}

		public static decimal Truncate(decimal d)
		{
			return default(decimal);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void Truncate(ref decimal d)
		{
		}

		public static implicit operator decimal(byte value)
		{
			return default(decimal);
		}

		[CLSCompliant(false)]
		public static implicit operator decimal(sbyte value)
		{
			return default(decimal);
		}

		public static implicit operator decimal(short value)
		{
			return default(decimal);
		}

		[CLSCompliant(false)]
		public static implicit operator decimal(ushort value)
		{
			return default(decimal);
		}

		public static implicit operator decimal(char value)
		{
			return default(decimal);
		}

		public static implicit operator decimal(int value)
		{
			return default(decimal);
		}

		[CLSCompliant(false)]
		public static implicit operator decimal(uint value)
		{
			return default(decimal);
		}

		public static implicit operator decimal(long value)
		{
			return default(decimal);
		}

		[CLSCompliant(false)]
		public static implicit operator decimal(ulong value)
		{
			return default(decimal);
		}

		public static explicit operator decimal(float value)
		{
			return default(decimal);
		}

		public static explicit operator decimal(double value)
		{
			return default(decimal);
		}

		public static explicit operator int(decimal value)
		{
			return 0;
		}

		public static explicit operator long(decimal value)
		{
			return 0L;
		}

		[CLSCompliant(false)]
		public static explicit operator ulong(decimal value)
		{
			return 0uL;
		}

		public static explicit operator float(decimal value)
		{
			return 0f;
		}

		public static explicit operator double(decimal value)
		{
			return 0.0;
		}

		public static decimal operator -(decimal d)
		{
			return default(decimal);
		}

		public static decimal operator ++(decimal d)
		{
			return default(decimal);
		}

		public static decimal operator +(decimal d1, decimal d2)
		{
			return default(decimal);
		}

		public static decimal operator -(decimal d1, decimal d2)
		{
			return default(decimal);
		}

		public static decimal operator *(decimal d1, decimal d2)
		{
			return default(decimal);
		}

		public static decimal operator /(decimal d1, decimal d2)
		{
			return default(decimal);
		}

		public static bool operator ==(decimal d1, decimal d2)
		{
			return false;
		}

		public static bool operator !=(decimal d1, decimal d2)
		{
			return false;
		}

		public static bool operator <(decimal d1, decimal d2)
		{
			return false;
		}

		public static bool operator <=(decimal d1, decimal d2)
		{
			return false;
		}

		public static bool operator >(decimal d1, decimal d2)
		{
			return false;
		}

		public static bool operator >=(decimal d1, decimal d2)
		{
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
