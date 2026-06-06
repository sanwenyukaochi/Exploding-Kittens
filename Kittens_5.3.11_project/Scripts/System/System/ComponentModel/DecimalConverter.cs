using System.Globalization;

namespace System.ComponentModel
{
	public class DecimalConverter : BaseNumberConverter
	{
		internal override bool AllowHex => false;

		internal override Type TargetType => null;

		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return false;
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		internal override object FromString(string value, int radix)
		{
			return null;
		}

		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return null;
		}

		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return null;
		}
	}
}
