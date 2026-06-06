namespace System.Security.Cryptography.X509Certificates
{
	public struct X509ChainStatus
	{
		private X509ChainStatusFlags status;

		private string info;

		public X509ChainStatusFlags Status
		{
			get
			{
				return default(X509ChainStatusFlags);
			}
			set
			{
			}
		}

		public string StatusInformation
		{
			set
			{
			}
		}

		internal X509ChainStatus(X509ChainStatusFlags flag)
		{
			status = default(X509ChainStatusFlags);
			info = null;
		}

		internal static string GetInformation(X509ChainStatusFlags flags)
		{
			return null;
		}
	}
}
