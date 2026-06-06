using System.Collections.Generic;
using System.IO;

namespace Unity.Services.Analytics.Internal
{
	internal interface IDiskCache
	{
		void Clear();

		void Write(List<int> eventEndIndices, Stream payload);
	}
}
