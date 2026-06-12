using System.IO;

namespace System.Net.Security
{
	public abstract class AuthenticatedStream : Stream
	{
		private Stream _InnerStream;

		private bool _LeaveStreamOpen;

		protected Stream InnerStream => null;

		public abstract bool IsAuthenticated { get; }

		protected AuthenticatedStream(Stream innerStream, bool leaveInnerStreamOpen)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}
	}
}
