namespace System.Xml.Serialization
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	public sealed class XmlSchemaProviderAttribute : Attribute
	{
		private string _methodName;

		private bool _isAny;

		public string MethodName => null;

		public bool IsAny
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public XmlSchemaProviderAttribute(string methodName)
		{
		}
	}
}
