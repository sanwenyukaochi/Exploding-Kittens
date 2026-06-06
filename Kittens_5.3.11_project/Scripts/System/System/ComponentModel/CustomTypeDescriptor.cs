namespace System.ComponentModel
{
	public abstract class CustomTypeDescriptor : ICustomTypeDescriptor
	{
		private readonly ICustomTypeDescriptor _parent;

		protected CustomTypeDescriptor()
		{
		}

		protected CustomTypeDescriptor(ICustomTypeDescriptor parent)
		{
		}

		public virtual AttributeCollection GetAttributes()
		{
			return null;
		}

		public virtual string GetClassName()
		{
			return null;
		}

		public virtual string GetComponentName()
		{
			return null;
		}

		public virtual TypeConverter GetConverter()
		{
			return null;
		}

		public virtual EventDescriptor GetDefaultEvent()
		{
			return null;
		}

		public virtual PropertyDescriptor GetDefaultProperty()
		{
			return null;
		}

		public virtual object GetEditor(Type editorBaseType)
		{
			return null;
		}

		public virtual EventDescriptorCollection GetEvents()
		{
			return null;
		}

		public virtual EventDescriptorCollection GetEvents(Attribute[] attributes)
		{
			return null;
		}

		public virtual PropertyDescriptorCollection GetProperties()
		{
			return null;
		}

		public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes)
		{
			return null;
		}

		public virtual object GetPropertyOwner(PropertyDescriptor pd)
		{
			return null;
		}
	}
}
