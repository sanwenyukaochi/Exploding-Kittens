using System.Collections.Generic;
using System.IO;

namespace Unity.Services.Analytics.Internal
{
	internal class DiskCache : IDiskCache
	{
		private readonly string k_CacheFilePath;

		private readonly IFileSystemCalls k_SystemCalls;

		private readonly long k_CacheFileMaximumSize;

		internal DiskCache(IFileSystemCalls systemCalls)
		{
		}

		public void Write(List<int> eventEndIndices, Stream payload)
		{
		}

		public void Clear()
		{
		}
	}
}
