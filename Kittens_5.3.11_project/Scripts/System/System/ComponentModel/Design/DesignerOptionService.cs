using System.Collections;
using System.Globalization;
using System.Reflection;

namespace System.ComponentModel.Design
{
	public abstract class DesignerOptionService
	{
		[DefaultMember("Item")]
		[TypeConverter(typeof(DesignerOptionConverter))]
		[Editor(null, "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public sealed class DesignerOptionCollection : ICollection
		{
			private sealed class WrappedPropertyDescriptor : PropertyDescriptor
			{
				private object target;

				private PropertyDescriptor property;

				public override AttributeCollection Attributes => null;

				public override Type ComponentType => null;

				public override bool IsReadOnly => false;

				public override Type PropertyType => null;

				internal WrappedPropertyDescriptor(PropertyDescriptor property, object target)
					: base((string)null, (Attribute[])null)
				{
				}

				public override bool CanResetValue(object component)
				{
					return false;
				}

				public override object GetValue(object component)
				{
					return null;
				}

				public override void ResetValue(object component)
				{
				}

				public override void SetValue(object component, object value)
				{
				}

				public override bool ShouldSerializeValue(object component)
				{
					return false;
				}
			}

			private DesignerOptionService _service;

			private string _name;

			private object _value;

			private ArrayList _children;

			private PropertyDescriptorCollection _properties;

			public int Count => 0;

			public string Name => null;

			public PropertyDescriptorCollection Properties => null;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => null;

			public void CopyTo(Array array, int index)
			{
			}

			private void EnsurePopulated()
			{
			}

			public IEnumerator GetEnumerator()
			{
				return null;
			}
		}

		internal sealed class DesignerOptionConverter : TypeConverter
		{
			private class OptionPropertyDescriptor : PropertyDescriptor
			{
				private DesignerOptionCollection _option;

				public override Type ComponentType => null;

				public override bool IsReadOnly => false;

				public override Type PropertyType => null;

				internal OptionPropertyDescriptor(DesignerOptionCollection option)
					: base((string)null, (Attribute[])null)
				{
				}

				public override bool CanResetValue(object component)
				{
					return false;
				}

				public override object GetValue(object component)
				{
					return null;
				}

				public override void ResetValue(object component)
				{
				}

				public override void SetValue(object component, object value)
				{
				}

				public override bool ShouldSerializeValue(object component)
				{
					return false;
				}
			}

			public override bool GetPropertiesSupported(ITypeDescriptorContext cxt)
			{
				return false;
			}

			public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext cxt, object value, Attribute[] attributes)
			{
				return null;
			}

			public override object ConvertTo(ITypeDescriptorContext cxt, CultureInfo culture, object value, Type destinationType)
			{
				return null;
			}
		}

		protected virtual void PopulateOptionCollection(DesignerOptionCollection options)
		{
		}
	}
}
