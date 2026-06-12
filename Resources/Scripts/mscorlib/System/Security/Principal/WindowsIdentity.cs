using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Claims;

namespace System.Security.Principal
{
	[Serializable]
	[ComVisible(true)]
	public class WindowsIdentity : ClaimsIdentity, IIdentity, IDeserializationCallback, ISerializable, IDisposable
	{
		private IntPtr _token;

		private string _type;

		private WindowsAccountType _account;

		private bool _authenticated;

		private string _name;

		private SerializationInfo _info;

		private static IntPtr invalidWindows;

		public sealed override string AuthenticationType => null;

		public override string Name => null;

		public WindowsIdentity(IntPtr userToken, string type, WindowsAccountType acctType, bool isAuthenticated)
		{
		}

		public WindowsIdentity(SerializationInfo info, StreamingContext context)
		{
		}

		[ComVisible(false)]
		public void Dispose()
		{
		}

		public static WindowsIdentity GetCurrent()
		{
			return null;
		}

		public virtual WindowsImpersonationContext Impersonate()
		{
			return null;
		}

		void IDeserializationCallback.OnDeserialization(object sender)
		{
		}

		void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		private void SetToken(IntPtr token)
		{
		}

		internal static IntPtr GetCurrentToken()
		{
			return (IntPtr)0;
		}

		private static string GetTokenName(IntPtr token)
		{
			return null;
		}
	}
}
