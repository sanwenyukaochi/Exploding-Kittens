namespace System.Xml.Schema
{
	public class XmlSchemaInfo : IXmlSchemaInfo
	{
		private bool isDefault;

		private bool isNil;

		private XmlSchemaElement schemaElement;

		private XmlSchemaAttribute schemaAttribute;

		private XmlSchemaType schemaType;

		private XmlSchemaSimpleType memberType;

		private XmlSchemaValidity validity;

		private XmlSchemaContentType contentType;

		public XmlSchemaValidity Validity
		{
			get
			{
				return default(XmlSchemaValidity);
			}
			set
			{
			}
		}

		public bool IsDefault
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsNil
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public XmlSchemaSimpleType MemberType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XmlSchemaType SchemaType
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XmlSchemaElement SchemaElement
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XmlSchemaAttribute SchemaAttribute
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public XmlSchemaContentType ContentType => default(XmlSchemaContentType);

		internal XmlSchemaType XmlType => null;

		internal bool HasDefaultValue => false;

		internal bool IsUnionType => false;

		public XmlSchemaInfo()
		{
		}

		internal XmlSchemaInfo(XmlSchemaValidity validity)
		{
		}

		internal void Clear()
		{
		}
	}
}
