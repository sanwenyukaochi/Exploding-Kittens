using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions
{
	[Serializable]
	public class Group : Capture
	{
		internal static readonly Group s_emptyGroup;

		internal readonly int[] _caps;

		internal int _capcount;

		internal CaptureCollection _capcoll;

		[CompilerGenerated]
		private readonly string _003CName_003Ek__BackingField;

		public bool Success => false;

		internal Group(string text, int[] caps, int capcount, string name)
			: base(null, 0, 0)
		{
		}

		internal Group()
			: base(null, 0, 0)
		{
		}
	}
}
