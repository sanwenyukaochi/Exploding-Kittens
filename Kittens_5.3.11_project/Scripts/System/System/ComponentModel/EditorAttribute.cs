namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public sealed class EditorAttribute : Attribute
	{
		private string _typeId;

		public string EditorBaseTypeName { get; }

		public string EditorTypeName { get; }

		public override object TypeId => null;

		public EditorAttribute()
		{
		}

		public EditorAttribute(string typeName, string baseTypeName)
		{
		}

		public EditorAttribute(string typeName, Type baseType)
		{
		}

		public EditorAttribute(Type type, Type baseType)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
