using System.Globalization;

namespace System.ComponentModel
{
	public abstract class TypeListConverter : TypeConverter
	{
		private readonly Type[] _types;

		private StandardValuesCollection _values;

		protected TypeListConverter(Type[] types)
		{
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
