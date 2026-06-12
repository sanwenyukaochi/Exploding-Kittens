using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.IO
{
	[Serializable]
	public abstract class FileSystemInfo : MarshalByRefObject, ISerializable
	{
		private FileStatus _fileStatus;

		protected string FullPath;

		protected string OriginalPath;

		internal string _name;

		internal bool ExistsCore => false;

		internal string NormalizedPath => null;

		public virtual string Name => null;

		public virtual bool Exists => false;

		protected FileSystemInfo()
		{
		}

		protected FileSystemInfo(SerializationInfo info, StreamingContext context)
		{
		}

		[ComVisible(false)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
