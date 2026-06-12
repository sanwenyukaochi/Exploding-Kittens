namespace System.Xml.Serialization
{
	public class XmlReflectionMember
	{
		private bool isReturnValue;

		private string memberName;

		private Type memberType;

		private XmlAttributes xmlAttributes;

		private Type declaringType;

		public bool IsReturnValue => false;

		public string MemberName => null;

		public Type MemberType => null;

		public XmlAttributes XmlAttributes => null;

		internal Type DeclaringType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal XmlReflectionMember(string name, Type type, XmlAttributes attributes)
		{
		}
	}
}
