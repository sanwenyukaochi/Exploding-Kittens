using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Schema;

namespace System.Xml.XPath
{
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	public abstract class XPathNavigator : XPathItem, ICloneable, IXmlNamespaceResolver
	{
		internal static readonly XPathNavigatorKeyComparer comparer;

		internal static readonly char[] NodeTypeLetter;

		internal static readonly char[] UniqueIdTbl;

		internal static readonly int[] ContentKindMasks;

		public override XmlSchemaType XmlType => null;

		public override object TypedValue => null;

		public override Type ValueType => null;

		public override bool ValueAsBoolean => false;

		public override DateTime ValueAsDateTime => default(DateTime);

		public override double ValueAsDouble => 0.0;

		public override int ValueAsInt => 0;

		public override long ValueAsLong => 0L;

		public abstract XmlNameTable NameTable { get; }

		public abstract XPathNodeType NodeType { get; }

		public abstract string LocalName { get; }

		public abstract string NamespaceURI { get; }

		public abstract string Prefix { get; }

		public virtual object UnderlyingObject => null;

		public virtual IXmlSchemaInfo SchemaInfo => null;

		public override string ToString()
		{
			return null;
		}

		public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		object ICloneable.Clone()
		{
			return null;
		}

		public virtual string LookupNamespace(string prefix)
		{
			return null;
		}

		public virtual string LookupPrefix(string namespaceURI)
		{
			return null;
		}

		public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return null;
		}

		public abstract XPathNavigator Clone();

		public virtual bool MoveToNamespace(string name)
		{
			return false;
		}

		public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

		public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

		public abstract bool MoveToParent();

		public abstract bool IsSamePosition(XPathNavigator other);

		internal static bool IsText(XPathNodeType type)
		{
			return false;
		}
	}
}
