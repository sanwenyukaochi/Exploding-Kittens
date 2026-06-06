using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Xml.Linq
{
	public abstract class XContainer : XNode
	{
		private sealed class ContentReader
		{
			private readonly NamespaceCache _eCache;

			private readonly NamespaceCache _aCache;

			private readonly IXmlLineInfo _lineInfo;

			private XContainer _currentContainer;

			private string _baseUri;

			public ContentReader(XContainer rootContainer)
			{
			}

			public ContentReader(XContainer rootContainer, XmlReader r, LoadOptions o)
			{
			}

			public bool ReadContentFrom(XContainer rootContainer, XmlReader r)
			{
				return false;
			}

			public bool ReadContentFrom(XContainer rootContainer, XmlReader r, LoadOptions o)
			{
				return false;
			}
		}

		[CompilerGenerated]
		private sealed class _003CNodes_003Ed__18 : IEnumerable<XNode>, IEnumerable, IEnumerator<XNode>, IDisposable, IEnumerator
		{
			private int _003C_003E1__state;

			private XNode _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public XContainer _003C_003E4__this;

			private XNode _003Cn_003E5__2;

			XNode IEnumerator<XNode>.Current
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
			public _003CNodes_003Ed__18(int _003C_003E1__state)
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
			IEnumerator<XNode> IEnumerable<XNode>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		internal object content;

		public XNode LastNode => null;

		internal XContainer()
		{
		}

		internal XContainer(XContainer other)
		{
		}

		public void Add(object content)
		{
		}

		[IteratorStateMachine(typeof(_003CNodes_003Ed__18))]
		public IEnumerable<XNode> Nodes()
		{
			return null;
		}

		internal virtual void AddAttribute(XAttribute a)
		{
		}

		internal virtual void AddAttributeSkipNotify(XAttribute a)
		{
		}

		internal void AddContentSkipNotify(object content)
		{
		}

		internal void AddNode(XNode n)
		{
		}

		internal void AddNodeSkipNotify(XNode n)
		{
		}

		internal void AddString(string s)
		{
		}

		internal void AddStringSkipNotify(string s)
		{
		}

		internal void AppendNode(XNode n)
		{
		}

		internal void AppendNodeSkipNotify(XNode n)
		{
		}

		internal override void AppendText(StringBuilder sb)
		{
		}

		internal void ConvertTextToNode()
		{
		}

		internal static string GetStringValue(object value)
		{
			return null;
		}

		internal void ReadContentFrom(XmlReader r)
		{
		}

		internal void ReadContentFrom(XmlReader r, LoadOptions o)
		{
		}

		internal void RemoveNode(XNode n)
		{
		}

		internal virtual void ValidateNode(XNode node, XNode previous)
		{
		}

		internal virtual void ValidateString(string s)
		{
		}

		internal void WriteContentTo(XmlWriter writer)
		{
		}
	}
}
