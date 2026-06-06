using System.Collections;
using System.Globalization;

namespace System.ComponentModel
{
	public class EnumConverter : TypeConverter
	{
		private StandardValuesCollection values;

		private Type type;

		protected Type EnumType => null;

		protected StandardValuesCollection Values
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual IComparer Comparer => null;

		public EnumConverter(Type type)
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

		public override bool IsValid(ITypeDescriptorContext context, object value)
		{
			return false;
		}
	}
}
