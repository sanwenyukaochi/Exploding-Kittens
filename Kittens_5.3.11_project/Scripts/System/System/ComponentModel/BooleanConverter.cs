using System.Globalization;

namespace System.ComponentModel
{
	public class BooleanConverter : TypeConverter
	{
		private static StandardValuesCollection s_values;

		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return false;
		}

		public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
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
