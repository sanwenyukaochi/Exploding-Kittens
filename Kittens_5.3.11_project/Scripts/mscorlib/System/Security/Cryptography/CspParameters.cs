using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public sealed class CspParameters
	{
		public int ProviderType;

		public string ProviderName;

		public string KeyContainerName;

		public int KeyNumber;

		private int m_flags;

		private CryptoKeySecurity m_cryptoKeySecurity;

		private SecureString m_keyPassword;

		private IntPtr m_parentWindowHandle;

		public CspProviderFlags Flags
		{
			get
			{
				return default(CspProviderFlags);
			}
			set
			{
			}
		}

		public CryptoKeySecurity CryptoKeySecurity
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SecureString KeyPassword
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IntPtr ParentWindowHandle
		{
			get
			{
				return (IntPtr)0;
			}
			set
			{
			}
		}

		public CspParameters()
		{
		}

		public CspParameters(int dwTypeIn)
		{
		}

		public CspParameters(int dwTypeIn, string strProviderNameIn)
		{
		}

		public CspParameters(int dwTypeIn, string strProviderNameIn, string strContainerNameIn)
		{
		}

		public CspParameters(int providerType, string providerName, string keyContainerName, CryptoKeySecurity cryptoKeySecurity, SecureString keyPassword)
		{
		}

		public CspParameters(int providerType, string providerName, string keyContainerName, CryptoKeySecurity cryptoKeySecurity, IntPtr parentWindowHandle)
		{
		}

		internal CspParameters(int providerType, string providerName, string keyContainerName, CspProviderFlags flags)
		{
		}

		internal CspParameters(CspParameters parameters)
		{
		}
	}
}
