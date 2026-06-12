using System.IO;

namespace Unity.Services.Analytics.Internal
{
	internal class FileSystemCalls : IFileSystemCalls
	{
		public bool CanAccessFileSystem()
		{
			return false;
		}

		public bool FileExists(string path)
		{
			return false;
		}

		public void DeleteFile(string path)
		{
		}

		public Stream OpenFileForWriting(string path)
		{
			return null;
		}
	}
}
