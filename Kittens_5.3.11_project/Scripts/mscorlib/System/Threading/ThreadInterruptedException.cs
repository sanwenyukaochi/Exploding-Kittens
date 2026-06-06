using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Threading
{
	[Serializable]
	[ComVisible(true)]
	public class ThreadInterruptedException : SystemException
	{
		public ThreadInterruptedException()
		{
		}

		protected ThreadInterruptedException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
