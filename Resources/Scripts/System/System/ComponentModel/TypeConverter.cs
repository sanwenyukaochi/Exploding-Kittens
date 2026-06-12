using System.Collections;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	[ComVisible(true)]
	public class TypeConverter
	{
		protected abstract class SimplePropertyDescriptor : PropertyDescriptor
		{
			private Type componentType;

			private Type propertyType;

			public override Type ComponentType => null;

			public override bool IsReadOnly => false;

			public override Type PropertyType => null;

			protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType)
				: base((string)null, (Attribute[])null)
			{
			}

			protected SimplePropertyDescriptor(Type componentType, string name, Type propertyType, Attribute[] attributes)
				: base((string)null, (Attribute[])null)
			{
			}

			public override bool CanResetValue(object component)
			{
				return false;
			}

			public override void ResetValue(object component)
			{
			}

			public override bool ShouldSerializeValue(object component)
			{
				return false;
			}
		}

		public class StandardValuesCollection : ICollection, IEnumerable
		{
			private ICollection values;

			private Array valueArray;

			public int Count => 0;

			public object this[int index] => null;

			int ICollection.Count => 0;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => null;

			public StandardValuesCollection(ICollection values)
			{
			}

			public void CopyTo(Array array, int index)
			{
			}

			public IEnumerator GetEnumerator()
			{
				return null;
			}

			void ICollection.CopyTo(Array array, int index)
			{
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";

		private static bool useCompatibleTypeConversion;

		private static bool UseCompatibleTypeConversion => false;

		public bool CanConvertFrom(Type sourceType)
		{
			return false;
		}

		public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return false;
		}

		public bool CanConvertTo(Type destinationType)
		{
			return false;
		}

		public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return false;
		}

		public object ConvertFrom(object value)
		{
			return null;
		}

		public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		public object ConvertFromInvariantString(string text)
		{
			return null;
		}

		public object ConvertFromInvariantString(ITypeDescriptorContext context, string text)
		{
			return null;
		}

		public object ConvertFromString(string text)
		{
			return null;
		}

		public object ConvertFromString(ITypeDescriptorContext context, string text)
		{
			return null;
		}

		public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text)
		{
			return null;
		}

		public object ConvertTo(object value, Type destinationType)
		{
			return null;
		}

		public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		public string ConvertToInvariantString(object value)
		{
			return null;
		}

		public string ConvertToInvariantString(ITypeDescriptorContext context, object value)
		{
			return null;
		}

		public string ConvertToString(object value)
		{
			return null;
		}

		public string ConvertToString(ITypeDescriptorContext context, object value)
		{
			return null;
		}

		public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value)
		{
			return null;
		}

		public object CreateInstance(IDictionary propertyValues)
		{
			return null;
		}

		public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues)
		{
			return null;
		}

		protected Exception GetConvertFromException(object value)
		{
			return null;
		}

		protected Exception GetConvertToException(object value, Type destinationType)
		{
			return null;
		}

		public bool GetCreateInstanceSupported()
		{
			return false;
		}

		public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context)
		{
			return false;
		}

		public PropertyDescriptorCollection GetProperties(object value)
		{
			return null;
		}

		public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value)
		{
			return null;
		}

		public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
		{
			return null;
		}

		public bool GetPropertiesSupported()
		{
			return false;
		}

		public virtual bool GetPropertiesSupported(ITypeDescriptorContext context)
		{
			return false;
		}

		public ICollection GetStandardValues()
		{
			return null;
		}

		public virtual StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
		{
			return null;
		}

		public bool GetStandardValuesExclusive()
		{
			return false;
		}

		public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context)
		{
			return false;
		}

		public bool GetStandardValuesSupported()
		{
			return false;
		}

		public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context)
		{
			return false;
		}

		public bool IsValid(object value)
		{
			return false;
		}

		public virtual bool IsValid(ITypeDescriptorContext context, object value)
		{
			return false;
		}

		protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names)
		{
			return null;
		}
	}
}
