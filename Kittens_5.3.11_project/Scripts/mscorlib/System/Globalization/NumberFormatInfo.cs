using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization
{
	[Serializable]
	[ComVisible(true)]
	public sealed class NumberFormatInfo : ICloneable, IFormatProvider
	{
		private static NumberFormatInfo invariantInfo;

		internal int[] numberGroupSizes;

		internal int[] currencyGroupSizes;

		internal int[] percentGroupSizes;

		internal string positiveSign;

		internal string negativeSign;

		internal string numberDecimalSeparator;

		internal string numberGroupSeparator;

		internal string currencyGroupSeparator;

		internal string currencyDecimalSeparator;

		internal string currencySymbol;

		internal string ansiCurrencySymbol;

		internal string nanSymbol;

		internal string positiveInfinitySymbol;

		internal string negativeInfinitySymbol;

		internal string percentDecimalSeparator;

		internal string percentGroupSeparator;

		internal string percentSymbol;

		internal string perMilleSymbol;

		[OptionalField(VersionAdded = 2)]
		internal string[] nativeDigits;

		[OptionalField(VersionAdded = 1)]
		internal int m_dataItem;

		internal int numberDecimalDigits;

		internal int currencyDecimalDigits;

		internal int currencyPositivePattern;

		internal int currencyNegativePattern;

		internal int numberNegativePattern;

		internal int percentPositivePattern;

		internal int percentNegativePattern;

		internal int percentDecimalDigits;

		[OptionalField(VersionAdded = 2)]
		internal int digitSubstitution;

		internal bool isReadOnly;

		[OptionalField(VersionAdded = 1)]
		internal bool m_useUserOverride;

		[OptionalField(VersionAdded = 2)]
		internal bool m_isInvariant;

		[OptionalField(VersionAdded = 1)]
		internal bool validForParseAsNumber;

		[OptionalField(VersionAdded = 1)]
		internal bool validForParseAsCurrency;

		private const NumberStyles InvalidNumberStyles = ~(NumberStyles.Any | NumberStyles.AllowHexSpecifier);

		public static NumberFormatInfo InvariantInfo => null;

		public int CurrencyDecimalDigits => 0;

		public string CurrencyDecimalSeparator => null;

		public bool IsReadOnly => false;

		public int[] CurrencyGroupSizes => null;

		public int[] NumberGroupSizes => null;

		public int[] PercentGroupSizes => null;

		public string CurrencyGroupSeparator => null;

		public string CurrencySymbol => null;

		public static NumberFormatInfo CurrentInfo => null;

		public string NaNSymbol
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int CurrencyNegativePattern => 0;

		public int NumberNegativePattern => 0;

		public int PercentPositivePattern => 0;

		public int PercentNegativePattern => 0;

		public string NegativeInfinitySymbol => null;

		public string NegativeSign => null;

		public int NumberDecimalDigits => 0;

		public string NumberDecimalSeparator => null;

		public string NumberGroupSeparator => null;

		public int CurrencyPositivePattern => 0;

		public string PositiveInfinitySymbol => null;

		public string PositiveSign => null;

		public int PercentDecimalDigits => 0;

		public string PercentDecimalSeparator => null;

		public string PercentGroupSeparator => null;

		public string PercentSymbol => null;

		public string PerMilleSymbol => null;

		public NumberFormatInfo()
		{
		}

		[OnSerializing]
		private void OnSerializing(StreamingContext ctx)
		{
		}

		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
		}

		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
		}

		internal NumberFormatInfo(CultureData cultureData)
		{
		}

		private void VerifyWritable()
		{
		}

		public static NumberFormatInfo GetInstance(IFormatProvider formatProvider)
		{
			return null;
		}

		public object Clone()
		{
			return null;
		}

		public object GetFormat(Type formatType)
		{
			return null;
		}

		public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi)
		{
			return null;
		}

		internal static void ValidateParseStyleInteger(NumberStyles style)
		{
		}

		internal static void ValidateParseStyleFloatingPoint(NumberStyles style)
		{
		}
	}
}
