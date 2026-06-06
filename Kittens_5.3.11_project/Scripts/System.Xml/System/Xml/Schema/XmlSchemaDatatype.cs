namespace System.Xml.Schema
{
	public abstract class XmlSchemaDatatype
	{
		public abstract Type ValueType { get; }

		public abstract XmlTokenizedType TokenizedType { get; }

		public virtual XmlSchemaDatatypeVariety Variety => default(XmlSchemaDatatypeVariety);

		public virtual XmlTypeCode TypeCode => default(XmlTypeCode);

		internal abstract bool HasLexicalFacets { get; }

		internal abstract bool HasValueFacets { get; }

		internal abstract XmlValueConverter ValueConverter { get; }

		internal abstract RestrictionFacets Restriction { get; }

		internal abstract FacetsChecker FacetsChecker { get; }

		internal abstract XmlSchemaWhiteSpace BuiltInWhitespaceFacet { get; }

		internal string TypeCodeString => null;

		public abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr);

		public virtual bool IsDerivedFrom(XmlSchemaDatatype datatype)
		{
			return false;
		}

		internal abstract int Compare(object value1, object value2);

		internal abstract object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, bool createAtomicValue);

		internal abstract Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue);

		internal abstract Exception TryParseValue(object value, XmlNameTable nameTable, IXmlNamespaceResolver namespaceResolver, out object typedValue);

		internal abstract XmlSchemaDatatype DeriveByRestriction(XmlSchemaObjectCollection facets, XmlNameTable nameTable, XmlSchemaType schemaType);

		internal abstract XmlSchemaDatatype DeriveByList(XmlSchemaType schemaType);

		internal abstract void VerifySchemaValid(XmlSchemaObjectTable notations, XmlSchemaObject caller);

		internal abstract bool IsEqual(object o1, object o2);

		internal abstract bool IsComparable(XmlSchemaDatatype dtype);

		internal string TypeCodeToString(XmlTypeCode typeCode)
		{
			return null;
		}

		internal static string ConcatenatedToString(object value)
		{
			return null;
		}

		internal static XmlSchemaDatatype FromXmlTokenizedType(XmlTokenizedType token)
		{
			return null;
		}

		internal static XmlSchemaDatatype FromXmlTokenizedTypeXsd(XmlTokenizedType token)
		{
			return null;
		}

		internal static XmlSchemaDatatype FromXdrName(string name)
		{
			return null;
		}

		internal static XmlSchemaDatatype DeriveByUnion(XmlSchemaSimpleType[] types, XmlSchemaType schemaType)
		{
			return null;
		}

		internal static string XdrCanonizeUri(string uri, XmlNameTable nameTable, SchemaNames schemaNames)
		{
			return null;
		}
	}
}
