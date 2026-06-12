using System.ComponentModel;
using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public class XmlSchemaType : XmlSchemaAnnotated
	{
		private string name;

		private XmlSchemaDerivationMethod final;

		private XmlSchemaDerivationMethod derivedBy;

		private XmlSchemaType baseSchemaType;

		private XmlSchemaDatatype datatype;

		private XmlSchemaDerivationMethod finalResolved;

		private SchemaElementDecl elementDecl;

		private XmlQualifiedName qname;

		private XmlSchemaType redefined;

		private XmlSchemaContentType contentType;

		[XmlAttribute("name")]
		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute("final")]
		[DefaultValue(XmlSchemaDerivationMethod.None)]
		public XmlSchemaDerivationMethod Final
		{
			get
			{
				return default(XmlSchemaDerivationMethod);
			}
			set
			{
			}
		}

		[XmlIgnore]
		public XmlQualifiedName QualifiedName => null;

		[XmlIgnore]
		public XmlSchemaDerivationMethod FinalResolved => default(XmlSchemaDerivationMethod);

		[XmlIgnore]
		public XmlSchemaType BaseXmlSchemaType => null;

		[XmlIgnore]
		public XmlSchemaDerivationMethod DerivedBy => default(XmlSchemaDerivationMethod);

		[XmlIgnore]
		public XmlSchemaDatatype Datatype => null;

		[XmlIgnore]
		public virtual bool IsMixed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[XmlIgnore]
		public XmlTypeCode TypeCode => default(XmlTypeCode);

		[XmlIgnore]
		internal XmlValueConverter ValueConverter => null;

		internal XmlSchemaContentType SchemaContentType => default(XmlSchemaContentType);

		internal SchemaElementDecl ElementDecl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlIgnore]
		internal XmlSchemaType Redefined
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlIgnore]
		internal override string NameAttribute
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlQualifiedName qualifiedName)
		{
			return null;
		}

		public static XmlSchemaSimpleType GetBuiltInSimpleType(XmlTypeCode typeCode)
		{
			return null;
		}

		public static XmlSchemaComplexType GetBuiltInComplexType(XmlQualifiedName qualifiedName)
		{
			return null;
		}

		internal void SetQualifiedName(XmlQualifiedName value)
		{
		}

		internal void SetFinalResolved(XmlSchemaDerivationMethod value)
		{
		}

		internal void SetBaseSchemaType(XmlSchemaType value)
		{
		}

		internal void SetDerivedBy(XmlSchemaDerivationMethod value)
		{
		}

		internal void SetDatatype(XmlSchemaDatatype value)
		{
		}

		internal void SetContentType(XmlSchemaContentType value)
		{
		}

		public static bool IsDerivedFrom(XmlSchemaType derivedType, XmlSchemaType baseType, XmlSchemaDerivationMethod except)
		{
			return false;
		}

		internal static bool IsDerivedFromDatatype(XmlSchemaDatatype derivedDataType, XmlSchemaDatatype baseDataType, XmlSchemaDerivationMethod except)
		{
			return false;
		}
	}
}
