using System.Diagnostics;
using System.Reflection;

namespace System.Text.RegularExpressions
{
	[DebuggerDisplay("Count = {Count}")]
	[DebuggerTypeProxy(typeof(CollectionDebuggerProxy<Capture>))]
	[DefaultMember("Item")]
	public class CaptureCollection
	{
		private readonly Group _group;

		private readonly int _capcount;

		private Capture[] _captures;
	}
}
