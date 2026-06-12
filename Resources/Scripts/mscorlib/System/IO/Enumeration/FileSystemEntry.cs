namespace System.IO.Enumeration
{
	public ref struct FileSystemEntry
	{
		internal Interop.Sys.DirectoryEntry _directoryEntry;

		private FileStatus _status;

		private Span<char> _pathBuffer;

		private ReadOnlySpan<char> _fullPath;

		private ReadOnlySpan<char> _fileName;

		private unsafe fixed char _fileNameBuffer[256];

		private FileAttributes _initialAttributes;

		private ReadOnlySpan<char> FullPath => default(ReadOnlySpan<char>);

		public ReadOnlySpan<char> FileName => default(ReadOnlySpan<char>);

		public ReadOnlySpan<char> Directory { get; private set; }

		public ReadOnlySpan<char> RootDirectory { get; private set; }

		public ReadOnlySpan<char> OriginalRootDirectory { get; private set; }

		public FileAttributes Attributes => default(FileAttributes);

		public bool IsDirectory => false;

		internal static FileAttributes Initialize(ref FileSystemEntry entry, Interop.Sys.DirectoryEntry directoryEntry, ReadOnlySpan<char> directory, ReadOnlySpan<char> rootDirectory, ReadOnlySpan<char> originalRootDirectory, Span<char> pathBuffer)
		{
			return default(FileAttributes);
		}

		public string ToSpecifiedFullPath()
		{
			return null;
		}
	}
}
