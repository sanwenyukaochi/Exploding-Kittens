using System.ComponentModel;

namespace System.Xml.XmlConfiguration
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class XmlReaderSection
	{
		internal static bool ProhibitDefaultUrlResolver => false;

		internal static bool CollapseWhiteSpaceIntoEmptyString => false;

		internal static XmlResolver CreateDefaultResolver()
		{
			return null;
		}
	}
}
