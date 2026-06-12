namespace System.IO
{
	internal static class FileSystem
	{
		private static bool CopyDanglingSymlink(string sourceFullPath, string destFullPath)
		{
			return false;
		}

		public static void CopyFile(string sourceFullPath, string destFullPath, bool overwrite)
		{
		}

		public static void DeleteFile(string fullPath)
		{
		}

		public static void CreateDirectory(string fullPath)
		{
		}

		public static bool DirectoryExists(ReadOnlySpan<char> fullPath)
		{
			return false;
		}

		private static bool DirectoryExists(ReadOnlySpan<char> fullPath, out Interop.ErrorInfo errorInfo)
		{
			errorInfo = default(Interop.ErrorInfo);
			return false;
		}

		public static bool FileExists(ReadOnlySpan<char> fullPath)
		{
			return false;
		}

		private static bool FileExists(ReadOnlySpan<char> fullPath, int fileType, out Interop.ErrorInfo errorInfo)
		{
			errorInfo = default(Interop.ErrorInfo);
			return false;
		}
	}
}
