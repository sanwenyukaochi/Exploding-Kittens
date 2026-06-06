using System.Collections;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.ComponentModel
{
	[ComVisible(true)]
	public abstract class MemberDescriptor
	{
		private string name;

		private string displayName;

		private int nameHash;

		private AttributeCollection attributeCollection;

		private Attribute[] attributes;

		private Attribute[] originalAttributes;

		private bool attributesFiltered;

		private bool attributesFilled;

		private int metadataVersion;

		private string category;

		private string description;

		private object lockCookie;

		protected virtual Attribute[] AttributeArray
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual AttributeCollection Attributes => null;

		public virtual string Category => null;

		public virtual string Description => null;

		public virtual bool IsBrowsable => false;

		public virtual string Name => null;

		protected virtual int NameHashCode => 0;

		public virtual bool DesignTimeOnly => false;

		public virtual string DisplayName => null;

		protected MemberDescriptor(string name)
		{
		}

		protected MemberDescriptor(string name, Attribute[] attributes)
		{
		}

		protected MemberDescriptor(MemberDescriptor descr)
		{
		}

		protected MemberDescriptor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes)
		{
		}

		private void CheckAttributesValid()
		{
		}

		protected virtual AttributeCollection CreateAttributeCollection()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		protected virtual void FillAttributes(IList attributeList)
		{
		}

		private void FilterAttributesIfNeeded()
		{
		}

		protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType)
		{
			return null;
		}

		protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly)
		{
			return null;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		protected virtual object GetInvocationTarget(Type type, object instance)
		{
			return null;
		}

		protected static ISite GetSite(object component)
		{
			return null;
		}

		[Obsolete("This method has been deprecated. Use GetInvocationTarget instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
		protected static object GetInvokee(Type componentClass, object component)
		{
			return null;
		}
	}
}
