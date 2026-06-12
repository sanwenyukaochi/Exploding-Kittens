using System.Collections;
using System.Collections.Generic;

namespace System.Xml.Serialization
{
	public class XmlReflectionImporter
	{
		private string initialDefaultNamespace;

		private XmlAttributeOverrides attributeOverrides;

		private ArrayList includedTypes;

		private ReflectionHelper helper;

		private int arrayChoiceCount;

		private ArrayList relatedMaps;

		private bool allowPrivateTypes;

		private static readonly string errSimple;

		private static readonly string errSimple2;

		public XmlReflectionImporter(XmlAttributeOverrides attributeOverrides, string defaultNamespace)
		{
		}

		public XmlTypeMapping ImportTypeMapping(Type type)
		{
			return null;
		}

		public XmlTypeMapping ImportTypeMapping(Type type, string defaultNamespace)
		{
			return null;
		}

		public XmlTypeMapping ImportTypeMapping(Type type, XmlRootAttribute root, string defaultNamespace)
		{
			return null;
		}

		private XmlTypeMapping ImportTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			return null;
		}

		private XmlTypeMapping CreateTypeMapping(TypeData typeData, XmlRootAttribute root, string defaultXmlType, string defaultNamespace)
		{
			return null;
		}

		private XmlTypeMapping ImportClassMapping(Type type, XmlRootAttribute root, string defaultNamespace, bool isBaseType = false)
		{
			return null;
		}

		private XmlTypeMapping ImportClassMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, bool isBaseType = false)
		{
			return null;
		}

		private void RegisterDerivedMap(XmlTypeMapping map, XmlTypeMapping derivedMap)
		{
		}

		private string GetTypeNamespace(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			return null;
		}

		private XmlTypeMapping ImportListMapping(Type type, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel)
		{
			return null;
		}

		private XmlTypeMapping ImportListMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace, XmlAttributes atts, int nestingLevel)
		{
			return null;
		}

		private XmlTypeMapping ImportXmlNodeMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			return null;
		}

		private XmlTypeMapping ImportPrimitiveMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			return null;
		}

		private XmlTypeMapping ImportEnumMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			return null;
		}

		private XmlTypeMapping ImportXmlSerializableMapping(TypeData typeData, XmlRootAttribute root, string defaultNamespace)
		{
			return null;
		}

		private void ImportIncludedTypes(Type type, string defaultNamespace)
		{
		}

		private List<XmlReflectionMember> GetReflectionMembers(Type type)
		{
			return null;
		}

		private XmlTypeMapMember CreateMapMember(Type declaringType, XmlReflectionMember rmember, string defaultNamespace)
		{
			return null;
		}

		private XmlTypeMapElementInfoList ImportElementInfo(Type cls, string defaultName, string defaultNamespace, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts)
		{
			return null;
		}

		private XmlTypeMapElementInfoList ImportAnyElementInfo(string defaultNamespace, XmlReflectionMember rmember, XmlTypeMapMemberElement member, XmlAttributes atts)
		{
			return null;
		}

		private void ImportTextElementInfo(XmlTypeMapElementInfoList list, Type defaultType, XmlTypeMapMemberElement member, XmlAttributes atts, string defaultNamespace)
		{
		}

		private bool CanBeNull(TypeData type)
		{
			return false;
		}

		public void IncludeType(Type type)
		{
		}

		private object GetDefaultValue(TypeData typeData, object defaultValue)
		{
			return null;
		}
	}
}
