using System.Runtime.Serialization;

namespace System.Xml.Linq
{
	[Serializable]
	public sealed class XName : IEquatable<XName>, ISerializable
	{
		private XNamespace _ns;

		private string _localName;

		private int _hashCode;

		public string LocalName => null;

		public XNamespace Namespace => null;

		public string NamespaceName => null;

		internal XName(XNamespace ns, string localName)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public static XName Get(string expandedName)
		{
			return null;
		}

		public static XName Get(string localName, string namespaceName)
		{
			return null;
		}

		[CLSCompliant(false)]
		public static implicit operator XName(string expandedName)
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(XName left, XName right)
		{
			return false;
		}

		bool IEquatable<XName>.Equals(XName other)
		{
			return false;
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		internal XName()
		{
		}
	}
}
