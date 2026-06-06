namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All)]
	public class PropertyTabAttribute : Attribute
	{
		private Type[] _tabClasses;

		private string[] _tabClassNames;

		public Type[] TabClasses => null;

		protected string[] TabClassNames => null;

		public PropertyTabScope[] TabScopes { get; private set; }

		public PropertyTabAttribute()
		{
		}

		public PropertyTabAttribute(Type tabClass)
		{
		}

		public PropertyTabAttribute(string tabClassName)
		{
		}

		public PropertyTabAttribute(Type tabClass, PropertyTabScope tabScope)
		{
		}

		public PropertyTabAttribute(string tabClassName, PropertyTabScope tabScope)
		{
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(PropertyTabAttribute other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		protected void InitializeArrays(string[] tabClassNames, PropertyTabScope[] tabScopes)
		{
		}

		protected void InitializeArrays(Type[] tabClasses, PropertyTabScope[] tabScopes)
		{
		}

		private void InitializeArrays(string[] tabClassNames, Type[] tabClasses, PropertyTabScope[] tabScopes)
		{
		}
	}
}
