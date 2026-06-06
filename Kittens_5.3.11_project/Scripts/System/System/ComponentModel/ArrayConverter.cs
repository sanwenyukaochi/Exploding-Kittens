using System.Globalization;

namespace System.ComponentModel
{
	public class ArrayConverter : CollectionConverter
	{
		private class ArrayPropertyDescriptor : SimplePropertyDescriptor
		{
			private readonly int _index;

			public ArrayPropertyDescriptor(Type arrayType, Type elementType, int index)
				: base(null, null, null)
			{
			}

			public override object GetValue(object instance)
			{
				return null;
			}

			public override void SetValue(object instance, object value)
			{
			}
		}

		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return null;
		}

		public override bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return false;
		}
	}
}
