using System.Xml.Serialization;

namespace System.Xml.Schema
{
	public abstract class XmlSchemaParticle : XmlSchemaAnnotated
	{
		[Flags]
		private enum Occurs
		{
			None = 0,
			Min = 1,
			Max = 2
		}

		private class EmptyParticle : XmlSchemaParticle
		{
			internal override bool IsEmpty => false;
		}

		private decimal minOccurs;

		private decimal maxOccurs;

		private Occurs flags;

		internal static readonly XmlSchemaParticle Empty;

		[XmlAttribute("minOccurs")]
		public string MinOccursString
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[XmlAttribute("maxOccurs")]
		public string MaxOccursString
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
		public decimal MinOccurs
		{
			get
			{
				return default(decimal);
			}
			set
			{
			}
		}

		[XmlIgnore]
		public decimal MaxOccurs
		{
			get
			{
				return default(decimal);
			}
			set
			{
			}
		}

		internal virtual bool IsEmpty => false;

		internal virtual string NameString => null;

		internal XmlQualifiedName GetQualifiedName()
		{
			return null;
		}
	}
}
