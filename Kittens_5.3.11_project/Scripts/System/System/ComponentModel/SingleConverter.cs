using System.Globalization;

namespace System.ComponentModel
{
	public class SingleConverter : BaseNumberConverter
	{
		internal override bool AllowHex => false;

		internal override Type TargetType => null;

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
