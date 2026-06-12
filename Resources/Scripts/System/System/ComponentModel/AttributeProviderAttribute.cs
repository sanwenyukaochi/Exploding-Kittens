namespace System.ComponentModel
{
	[AttributeUsage(AttributeTargets.Property)]
	public class AttributeProviderAttribute : Attribute
	{
		public string TypeName { get; }

		public string PropertyName { get; }

		public AttributeProviderAttribute(string typeName)
		{
		}

		public AttributeProviderAttribute(string typeName, string propertyName)
		{
		}

		public AttributeProviderAttribute(Type type)
		{
		}
	}
}
