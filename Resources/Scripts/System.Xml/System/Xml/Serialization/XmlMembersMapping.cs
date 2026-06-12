using System.Reflection;

namespace System.Xml.Serialization
{
	[DefaultMember("Item")]
	public class XmlMembersMapping : XmlMapping
	{
		private bool _hasWrapperElement;

		private XmlMemberMapping[] _mapping;

		public int Count => 0;

		internal bool HasWrapperElement => false;
	}
}
