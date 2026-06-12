using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace System.Xml.Linq
{
	[XmlSchemaProvider(null, IsAny = true)]
	[XmlTypeConvertor("ConvertForAssignment")]
	public class XElement : XContainer, IXmlSerializable
	{
		[CompilerGenerated]
		private sealed class _003CGetAttributes_003Ed__116 : IEnumerable<XAttribute>, IEnumerable, IEnumerator<XAttribute>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private XAttribute _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public XElement _003C_003E4__this;

			private XName name;

			public XName _003C_003E3__name;

			private XAttribute _003Ca_003E5__2;

			XAttribute IEnumerator<XAttribute>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CGetAttributes_003Ed__116(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<XAttribute> IEnumerable<XAttribute>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		internal XName name;

		internal XAttribute lastAttr;

		public bool HasAttributes => false;

		public bool IsEmpty => false;

		public XName Name => null;

		public override XmlNodeType NodeType => default(XmlNodeType);

		public string Value => null;

		public XElement(XName name)
		{
		}

		public XElement(XElement other)
		{
		}

		public XElement(XStreamingElement other)
		{
		}

		public XAttribute Attribute(XName name)
		{
			return null;
		}

		public IEnumerable<XAttribute> Attributes()
		{
			return null;
		}

		public string GetPrefixOfNamespace(XNamespace ns)
		{
			return null;
		}

		public override void WriteTo(XmlWriter writer)
		{
		}

		XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		void IXmlSerializable.ReadXml(XmlReader reader)
		{
		}

		void IXmlSerializable.WriteXml(XmlWriter writer)
		{
		}

		internal override void AddAttribute(XAttribute a)
		{
		}

		internal override void AddAttributeSkipNotify(XAttribute a)
		{
		}

		internal void AppendAttribute(XAttribute a)
		{
		}

		internal void AppendAttributeSkipNotify(XAttribute a)
		{
		}

		internal override XNode CloneNode()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetAttributes_003Ed__116))]
		private IEnumerable<XAttribute> GetAttributes(XName name)
		{
			return null;
		}

		private string GetNamespaceOfPrefixInScope(string prefix, XElement outOfScope)
		{
			return null;
		}

		private void ReadElementFrom(XmlReader r, LoadOptions o)
		{
		}

		private void ReadElementFromImpl(XmlReader r, LoadOptions o)
		{
		}

		internal void SetEndElementLineInfo(int lineNumber, int linePosition)
		{
		}

		internal override void ValidateNode(XNode node, XNode previous)
		{
		}
	}
}
