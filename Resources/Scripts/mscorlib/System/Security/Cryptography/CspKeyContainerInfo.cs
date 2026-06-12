using System.Runtime.InteropServices;
using System.Security.AccessControl;

namespace System.Security.Cryptography
{
	[ComVisible(true)]
	public sealed class CspKeyContainerInfo
	{
		private CspParameters _params;

		internal bool _random;

		public bool Accessible => false;

		public CryptoKeySecurity CryptoKeySecurity => null;

		public bool Exportable => false;

		public bool HardwareDevice => false;

		public string KeyContainerName => null;

		public KeyNumber KeyNumber => default(KeyNumber);

		public bool MachineKeyStore => false;

		public bool Protected => false;

		public string ProviderName => null;

		public int ProviderType => 0;

		public bool RandomlyGenerated => false;

		public bool Removable => false;

		public string UniqueKeyContainerName => null;

		public CspKeyContainerInfo(CspParameters parameters)
		{
		}
	}
}
