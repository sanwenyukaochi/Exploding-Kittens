using System.Globalization;

namespace System.ComponentModel
{
	public abstract class BaseNumberConverter : TypeConverter
	{
		internal virtual bool AllowHex => false;

		internal abstract Type TargetType { get; }

		internal BaseNumberConverter()
		{
		}

		internal abstract object FromString(string value, int radix);

		internal abstract object FromString(string value, NumberFormatInfo formatInfo);

		internal abstract string ToString(object value, NumberFormatInfo formatInfo);

		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
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

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return false;
		}
	}
}
