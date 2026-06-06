using System.Collections;
using System.Globalization;

namespace System.ComponentModel
{
	public class ReferenceConverter : TypeConverter
	{
		private class ReferenceComparer : IComparer
		{
			private ReferenceConverter _converter;

			public ReferenceComparer(ReferenceConverter converter)
			{
			}

			public int Compare(object item1, object item2)
			{
				return 0;
			}
		}

		private static readonly string s_none;

		private Type _type;

		public ReferenceConverter(Type type)
		{
		}

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

		protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value)
		{
			return false;
		}
	}
}
