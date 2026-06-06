using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.ComponentModel
{
	[Serializable]
	public class Win32Exception : ExternalException, ISerializable
	{
		private readonly int nativeErrorCode;

		public int NativeErrorCode => 0;

		public Win32Exception()
		{
		}

		public Win32Exception(int error)
		{
		}

		public Win32Exception(int error, string message)
		{
		}

		public Win32Exception(string message)
		{
		}

		public Win32Exception(string message, Exception innerException)
		{
		}

		protected Win32Exception(SerializationInfo info, StreamingContext context)
		{
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		internal static string GetErrorMessage(int error)
		{
			return null;
		}
	}
}
