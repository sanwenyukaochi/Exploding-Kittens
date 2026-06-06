using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace System.ComponentModel
{
	public class CultureInfoConverter : TypeConverter
	{
		private class CultureComparer : IComparer
		{
			private CultureInfoConverter _converter;

			public CultureComparer(CultureInfoConverter cultureConverter)
			{
			}

			public int Compare(object item1, object item2)
			{
				return 0;
			}
		}

		private static class CultureInfoMapper
		{
			private static readonly Dictionary<string, string> s_cultureInfoNameMap;

			private static Dictionary<string, string> CreateMap()
			{
				return null;
			}

			public static string GetCultureInfoName(string cultureInfoDisplayName)
			{
				return null;
			}
		}

		private StandardValuesCollection _values;

		private const string DefaultInvariantCultureString = "(Default)";

		private string DefaultCultureString => null;

		protected virtual string GetCultureName(CultureInfo culture)
		{
			return null;
		}

		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return false;
		}

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return false;
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return null;
		}

		public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return false;
		}

		public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return false;
		}
	}
}
