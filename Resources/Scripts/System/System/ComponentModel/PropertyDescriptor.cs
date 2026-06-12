using System.Collections;

namespace System.ComponentModel
{
	public abstract class PropertyDescriptor : MemberDescriptor
	{
		private TypeConverter _converter;

		private Hashtable _valueChangedHandlers;

		private object[] _editors;

		private Type[] _editorTypes;

		private int _editorCount;

		public abstract Type ComponentType { get; }

		public virtual TypeConverter Converter => null;

		public virtual bool IsLocalizable => false;

		public abstract bool IsReadOnly { get; }

		public DesignerSerializationVisibility SerializationVisibility => default(DesignerSerializationVisibility);

		public abstract Type PropertyType { get; }

		public virtual bool SupportsChangeEvents => false;

		protected PropertyDescriptor(string name, Attribute[] attrs)
			: base((string)null)
		{
		}

		protected PropertyDescriptor(MemberDescriptor descr)
			: base((string)null)
		{
		}

		protected PropertyDescriptor(MemberDescriptor descr, Attribute[] attrs)
			: base((string)null)
		{
		}

		public virtual void AddValueChanged(object component, EventHandler handler)
		{
		}

		public abstract bool CanResetValue(object component);

		public override bool Equals(object obj)
		{
			return false;
		}

		protected object CreateInstance(Type type)
		{
			return null;
		}

		protected override void FillAttributes(IList attributeList)
		{
		}

		public PropertyDescriptorCollection GetChildProperties()
		{
			return null;
		}

		public PropertyDescriptorCollection GetChildProperties(Attribute[] filter)
		{
			return null;
		}

		public PropertyDescriptorCollection GetChildProperties(object instance)
		{
			return null;
		}

		public virtual PropertyDescriptorCollection GetChildProperties(object instance, Attribute[] filter)
		{
			return null;
		}

		public virtual object GetEditor(Type editorBaseType)
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		protected override object GetInvocationTarget(Type type, object instance)
		{
			return null;
		}

		protected Type GetTypeFromName(string typeName)
		{
			return null;
		}

		public abstract object GetValue(object component);

		protected virtual void OnValueChanged(object component, EventArgs e)
		{
		}

		public virtual void RemoveValueChanged(object component, EventHandler handler)
		{
		}

		protected internal EventHandler GetValueChangedHandler(object component)
		{
			return null;
		}

		public abstract void ResetValue(object component);

		public abstract void SetValue(object component, object value);

		public abstract bool ShouldSerializeValue(object component);
	}
}
