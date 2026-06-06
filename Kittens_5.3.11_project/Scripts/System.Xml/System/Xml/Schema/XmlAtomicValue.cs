using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.XPath;

namespace System.Xml.Schema
{
	public sealed class XmlAtomicValue : XPathItem, ICloneable
	{
		[StructLayout((LayoutKind)2)]
		private struct Union
		{
			[FieldOffset(0)]
			public bool boolVal;

			[FieldOffset(0)]
			public double dblVal;

			[FieldOffset(0)]
			public long i64Val;

			[FieldOffset(0)]
			public int i32Val;

			[FieldOffset(0)]
			public DateTime dtVal;
		}

		private class NamespacePrefixForQName : IXmlNamespaceResolver
		{
			public string prefix;

			public string ns;

			public NamespacePrefixForQName(string prefix, string ns)
			{
			}

			public string LookupNamespace(string prefix)
			{
				return null;
			}

			public string LookupPrefix(string namespaceName)
			{
				return null;
			}

			public IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
			{
				return null;
			}
		}

		private XmlSchemaType xmlType;

		private object objVal;

		private TypeCode clrType;

		private Union unionVal;

		private NamespacePrefixForQName nsPrefix;

		public override XmlSchemaType XmlType => null;

		public override Type ValueType => null;

		public override object TypedValue => null;

		public override bool ValueAsBoolean => false;

		public override DateTime ValueAsDateTime => default(DateTime);

		public override double ValueAsDouble => 0.0;

		public override int ValueAsInt => 0;

		public override long ValueAsLong => 0L;

		public override string Value => null;

		internal XmlAtomicValue(XmlSchemaType xmlType, bool value)
		{
		}

		internal XmlAtomicValue(XmlSchemaType xmlType, DateTime value)
		{
		}

		internal XmlAtomicValue(XmlSchemaType xmlType, double value)
		{
		}

		internal XmlAtomicValue(XmlSchemaType xmlType, int value)
		{
		}

		internal XmlAtomicValue(XmlSchemaType xmlType, long value)
		{
		}

		internal XmlAtomicValue(XmlSchemaType xmlType, string value)
		{
		}

		internal XmlAtomicValue(XmlSchemaType xmlType, string value, IXmlNamespaceResolver nsResolver)
		{
		}

		internal XmlAtomicValue(XmlSchemaType xmlType, object value)
		{
		}

		internal XmlAtomicValue(XmlSchemaType xmlType, object value, IXmlNamespaceResolver nsResolver)
		{
		}

		object ICloneable.Clone()
		{
			return null;
		}

		public override object ValueAs(Type type, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		private string GetPrefixFromQName(string value)
		{
			return null;
		}
	}
}
