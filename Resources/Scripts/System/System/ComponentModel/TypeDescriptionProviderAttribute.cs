namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public sealed class TypeDescriptionProviderAttribute : Attribute
	{
		public string TypeName { get; }

		public TypeDescriptionProviderAttribute(string typeName)
		{
		}

		public TypeDescriptionProviderAttribute(Type type)
		{
		}
	}
}
