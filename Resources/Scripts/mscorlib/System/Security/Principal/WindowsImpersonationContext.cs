using System.Runtime.InteropServices;

namespace System.Security.Principal
{
	[ComVisible(true)]
	public class WindowsImpersonationContext : IDisposable
	{
		private IntPtr _token;

		private bool undo;

		internal WindowsImpersonationContext(IntPtr token)
		{
		}

		[ComVisible(false)]
		public void Dispose()
		{
		}

		public void Undo()
		{
		}

		private static bool CloseToken(IntPtr token)
		{
			return false;
		}

		private static IntPtr DuplicateToken(IntPtr token)
		{
			return (IntPtr)0;
		}

		private static bool SetCurrentToken(IntPtr token)
		{
			return false;
		}

		private static bool RevertToSelf()
		{
			return false;
		}
	}
}
