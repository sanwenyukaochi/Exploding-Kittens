using System.Collections;
using System.Runtime.InteropServices;
using System.Text;

namespace System.Security
{
	[Serializable]
	[ComVisible(true)]
	public sealed class SecurityElement
	{
		internal class SecurityAttribute
		{
			private string _name;

			private string _value;

			public string Name => null;

			public string Value => null;

			public SecurityAttribute(string name, string value)
			{
			}
		}

		private string text;

		private string tag;

		private ArrayList attributes;

		private ArrayList children;

		private static readonly char[] invalid_tag_chars;

		private static readonly char[] invalid_text_chars;

		private static readonly char[] invalid_attr_name_chars;

		private static readonly char[] invalid_attr_value_chars;

		private static readonly char[] invalid_chars;

		public ArrayList Children => null;

		public string Tag => null;

		public string Text
		{
			set
			{
			}
		}

		internal string m_strText
		{
			set
			{
			}
		}

		public SecurityElement(string tag)
		{
		}

		public SecurityElement(string tag, string text)
		{
		}

		public void AddAttribute(string name, string value)
		{
		}

		public void AddChild(SecurityElement child)
		{
		}

		public static string Escape(string str)
		{
			return null;
		}

		private static string Unescape(string str)
		{
			return null;
		}

		public static bool IsValidAttributeName(string name)
		{
			return false;
		}

		public static bool IsValidAttributeValue(string value)
		{
			return false;
		}

		public static bool IsValidTag(string tag)
		{
			return false;
		}

		public static bool IsValidText(string text)
		{
			return false;
		}

		public SecurityElement SearchForChildByTag(string tag)
		{
			return null;
		}

		public string SearchForTextOfTag(string tag)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		private void ToXml(ref StringBuilder s, int level)
		{
		}

		internal SecurityAttribute GetAttribute(string name)
		{
			return null;
		}

		internal string SearchForTextOfLocalName(string strLocalName)
		{
			return null;
		}
	}
}
