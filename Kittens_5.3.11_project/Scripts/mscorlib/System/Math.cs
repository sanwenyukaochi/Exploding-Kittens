using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace System
{
	public static class Math
	{
		private static double doubleRoundLimit;

		private static double[] roundPower10Double;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Abs(int value)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static long Abs(long value)
		{
			return 0L;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Abs(decimal value)
		{
			return default(decimal);
		}

		[StackTraceHidden]
		private static void ThrowAbsOverflow()
		{
		}

		public static int DivRem(int a, int b, out int result)
		{
			result = default(int);
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Clamp(int value, int min, int max)
		{
			return 0;
		}

		public static double IEEERemainder(double x, double y)
		{
			return 0.0;
		}

		public static double Log(double a, double newBase)
		{
			return 0.0;
		}

		[NonVersionable]
		public static byte Max(byte val1, byte val2)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Max(decimal val1, decimal val2)
		{
			return default(decimal);
		}

		public static double Max(double val1, double val2)
		{
			return 0.0;
		}

		[NonVersionable]
		public static short Max(short val1, short val2)
		{
			return 0;
		}

		[NonVersionable]
		public static int Max(int val1, int val2)
		{
			return 0;
		}

		[NonVersionable]
		public static long Max(long val1, long val2)
		{
			return 0L;
		}

		[NonVersionable]
		[CLSCompliant(false)]
		public static sbyte Max(sbyte val1, sbyte val2)
		{
			return 0;
		}

		public static float Max(float val1, float val2)
		{
			return 0f;
		}

		[NonVersionable]
		[CLSCompliant(false)]
		public static ushort Max(ushort val1, ushort val2)
		{
			return 0;
		}

		[NonVersionable]
		[CLSCompliant(false)]
		public static uint Max(uint val1, uint val2)
		{
			return 0u;
		}

		[CLSCompliant(false)]
		[NonVersionable]
		public static ulong Max(ulong val1, ulong val2)
		{
			return 0uL;
		}

		[NonVersionable]
		public static byte Min(byte val1, byte val2)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Min(decimal val1, decimal val2)
		{
			return default(decimal);
		}

		public static double Min(double val1, double val2)
		{
			return 0.0;
		}

		[NonVersionable]
		public static short Min(short val1, short val2)
		{
			return 0;
		}

		[NonVersionable]
		public static int Min(int val1, int val2)
		{
			return 0;
		}

		[NonVersionable]
		public static long Min(long val1, long val2)
		{
			return 0L;
		}

		[CLSCompliant(false)]
		[NonVersionable]
		public static sbyte Min(sbyte val1, sbyte val2)
		{
			return 0;
		}

		public static float Min(float val1, float val2)
		{
			return 0f;
		}

		[CLSCompliant(false)]
		[NonVersionable]
		public static ushort Min(ushort val1, ushort val2)
		{
			return 0;
		}

		[CLSCompliant(false)]
		[NonVersionable]
		public static uint Min(uint val1, uint val2)
		{
			return 0u;
		}

		[CLSCompliant(false)]
		[NonVersionable]
		public static ulong Min(ulong val1, ulong val2)
		{
			return 0uL;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Round(decimal d)
		{
			return default(decimal);
		}

		public static double Round(double a)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Round(double value, int digits)
		{
			return 0.0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double Round(double value, MidpointRounding mode)
		{
			return 0.0;
		}

		public static double Round(double value, int digits, MidpointRounding mode)
		{
			return 0.0;
		}

		public static int Sign(double value)
		{
			return 0;
		}

		public static int Sign(long value)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static decimal Truncate(decimal d)
		{
			return default(decimal);
		}

		public static double Truncate(double d)
		{
			return 0.0;
		}

		private static void ThrowMinMaxException<T>(T min, T max)
		{
		}

		public static double Abs(double value)
		{
			return 0.0;
		}

		public static float Abs(float value)
		{
			return 0f;
		}

		public static double Acos(double d)
		{
			return 0.0;
		}

		public static double Asin(double d)
		{
			return 0.0;
		}

		public static double Atan(double d)
		{
			return 0.0;
		}

		public static double Atan2(double y, double x)
		{
			return 0.0;
		}

		public static double Ceiling(double a)
		{
			return 0.0;
		}

		public static double Cos(double d)
		{
			return 0.0;
		}

		public static double Cosh(double value)
		{
			return 0.0;
		}

		public static double Exp(double d)
		{
			return 0.0;
		}

		public static double Floor(double d)
		{
			return 0.0;
		}

		public static double Log(double d)
		{
			return 0.0;
		}

		public static double Log10(double d)
		{
			return 0.0;
		}

		public static double Pow(double x, double y)
		{
			return 0.0;
		}

		public static double Sin(double a)
		{
			return 0.0;
		}

		public static double Sinh(double value)
		{
			return 0.0;
		}

		public static double Sqrt(double d)
		{
			return 0.0;
		}

		public static double Tan(double a)
		{
			return 0.0;
		}

		public static double Tanh(double value)
		{
			return 0.0;
		}

		private unsafe static double ModF(double x, double* intptr)
		{
			return 0.0;
		}
	}
}
