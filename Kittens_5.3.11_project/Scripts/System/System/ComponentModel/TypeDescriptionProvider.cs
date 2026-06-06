using System.Collections;

namespace System.ComponentModel
{
	public abstract class TypeDescriptionProvider
	{
		private sealed class EmptyCustomTypeDescriptor : CustomTypeDescriptor
		{
		}

		private readonly TypeDescriptionProvider _parent;

		private EmptyCustomTypeDescriptor _emptyDescriptor;

		protected TypeDescriptionProvider()
		{
		}

		protected TypeDescriptionProvider(TypeDescriptionProvider parent)
		{
		}

		public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args)
		{
			return null;
		}

		public virtual IDictionary GetCache(object instance)
		{
			return null;
		}

		public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance)
		{
			return null;
		}

		protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance)
		{
			return null;
		}

		public virtual string GetFullComponentName(object component)
		{
			return null;
		}

		public Type GetReflectionType(Type objectType)
		{
			return null;
		}

		public Type GetReflectionType(object instance)
		{
			return null;
		}

		public virtual Type GetReflectionType(Type objectType, object instance)
		{
			return null;
		}

		public virtual Type GetRuntimeType(Type reflectionType)
		{
			return null;
		}

		public ICustomTypeDescriptor GetTypeDescriptor(Type objectType)
		{
			return null;
		}

		public ICustomTypeDescriptor GetTypeDescriptor(object instance)
		{
			return null;
		}

		public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance)
		{
			return null;
		}

		public virtual bool IsSupportedType(Type type)
		{
			return false;
		}
	}
}
