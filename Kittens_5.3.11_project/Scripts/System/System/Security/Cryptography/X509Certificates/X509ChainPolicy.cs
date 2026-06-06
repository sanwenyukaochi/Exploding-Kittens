namespace System.Security.Cryptography.X509Certificates
{
	public sealed class X509ChainPolicy
	{
		private OidCollection apps;

		private OidCollection cert;

		private X509CertificateCollection store;

		private X509Certificate2Collection store2;

		private X509RevocationFlag rflag;

		private X509RevocationMode mode;

		private TimeSpan timeout;

		private X509VerificationFlags vflags;

		private DateTime vtime;

		public X509Certificate2Collection ExtraStore => null;

		public X509RevocationFlag RevocationFlag => default(X509RevocationFlag);

		public X509RevocationMode RevocationMode
		{
			get
			{
				return default(X509RevocationMode);
			}
			set
			{
			}
		}

		public X509VerificationFlags VerificationFlags
		{
			get
			{
				return default(X509VerificationFlags);
			}
			set
			{
			}
		}

		public DateTime VerificationTime => default(DateTime);

		public void Reset()
		{
		}
	}
}
