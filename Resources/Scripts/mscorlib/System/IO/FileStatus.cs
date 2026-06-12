namespace System.IO
{
	internal struct FileStatus
	{
		private Interop.Sys.FileStatus _fileStatus;

		private int _fileStatusInitialized;

		internal bool _isDirectory;

		private bool _exists;

		internal bool InitiallyDirectory { get; private set; }

		internal static void Initialize(ref FileStatus status, bool isDirectory)
		{
		}

		internal bool IsReadOnly(ReadOnlySpan<char> path, bool continueOnError = false)
		{
			return false;
		}

		internal bool GetExists(ReadOnlySpan<char> path)
		{
			return false;
		}

		public void Refresh(ReadOnlySpan<char> path)
		{
		}

		internal void EnsureStatInitialized(ReadOnlySpan<char> path, bool continueOnError = false)
		{
		}
	}
}
