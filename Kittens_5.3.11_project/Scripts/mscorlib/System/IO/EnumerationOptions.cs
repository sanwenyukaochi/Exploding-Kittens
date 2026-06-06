using System.Runtime.CompilerServices;

namespace System.IO
{
	public class EnumerationOptions
	{
		[CompilerGenerated]
		private static readonly EnumerationOptions _003CCompatibleRecursive_003Ek__BackingField;

		internal static EnumerationOptions Compatible { get; }

		internal static EnumerationOptions Default { get; }

		public bool RecurseSubdirectories { get; set; }

		public bool IgnoreInaccessible { get; set; }

		public FileAttributes AttributesToSkip { get; set; }

		public MatchType MatchType { get; set; }

		public MatchCasing MatchCasing { get; }

		public bool ReturnSpecialDirectories { get; }
	}
}
