using System;

namespace Photon.SocketServer.Numeric
{
	internal class BigInteger
	{
		public static readonly int[] primesBelow2000;

		private uint[] data;

		public int dataLength;

		public BigInteger()
		{
		}

		public BigInteger(long value)
		{
		}

		public BigInteger(BigInteger bi)
		{
		}

		public BigInteger(byte[] inData)
		{
		}

		public BigInteger(uint[] inData)
		{
		}

		public static implicit operator BigInteger(long value)
		{
			return null;
		}

		public static implicit operator BigInteger(int value)
		{
			return null;
		}

		public static BigInteger operator +(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		public static BigInteger operator -(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		public static BigInteger operator *(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		public static BigInteger operator <<(BigInteger bi1, int shiftVal)
		{
			return null;
		}

		private static int shiftLeft(uint[] buffer, int shiftVal)
		{
			return 0;
		}

		private static int shiftRight(uint[] buffer, int shiftVal)
		{
			return 0;
		}

		public static BigInteger operator -(BigInteger bi1)
		{
			return null;
		}

		public static bool operator ==(BigInteger bi1, BigInteger bi2)
		{
			return false;
		}

		public override bool Equals(object o)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator >(BigInteger bi1, BigInteger bi2)
		{
			return false;
		}

		public static bool operator <(BigInteger bi1, BigInteger bi2)
		{
			return false;
		}

		public static bool operator >=(BigInteger bi1, BigInteger bi2)
		{
			return false;
		}

		private static void multiByteDivide(BigInteger bi1, BigInteger bi2, BigInteger outQuotient, BigInteger outRemainder)
		{
		}

		private static void singleByteDivide(BigInteger bi1, BigInteger bi2, BigInteger outQuotient, BigInteger outRemainder)
		{
		}

		public static BigInteger operator /(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		public static BigInteger operator %(BigInteger bi1, BigInteger bi2)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(int radix)
		{
			return null;
		}

		public BigInteger ModPow(BigInteger exp, BigInteger n)
		{
			return null;
		}

		private BigInteger BarrettReduction(BigInteger x, BigInteger n, BigInteger constant)
		{
			return null;
		}

		public static BigInteger GenerateRandom(int bits)
		{
			return null;
		}

		public void genRandomBits(int bits, Random rand)
		{
		}

		public int bitCount()
		{
			return 0;
		}

		public byte[] GetBytes()
		{
			return null;
		}
	}
}
