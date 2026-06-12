using System.Runtime.Serialization;

namespace System.IO
{
	[Serializable]
	public sealed class FileInfo : FileSystemInfo
	{
		public override string Name => null;

		private FileInfo()
		{
		}

		public FileInfo(string fileName)
		{
		}

		internal FileInfo(string originalPath, string fullPath = null, string fileName = null, bool isNormalized = false)
		{
		}

		public StreamReader OpenText()
		{
			return null;
		}

		public StreamWriter CreateText()
		{
			return null;
		}

		public StreamWriter AppendText()
		{
			return null;
		}

		private FileInfo(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
