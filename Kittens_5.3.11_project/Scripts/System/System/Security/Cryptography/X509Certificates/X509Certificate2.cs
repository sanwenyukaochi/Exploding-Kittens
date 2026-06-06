using System.Runtime.Serialization;

namespace System.Security.Cryptography.X509Certificates
{
	[Serializable]
	public class X509Certificate2 : X509Certificate
	{
		private byte[] lazyRawData;

		private Oid lazySignatureAlgorithm;

		private int lazyVersion;

		private X500DistinguishedName lazySubjectName;

		private X500DistinguishedName lazyIssuerName;

		private PublicKey lazyPublicKey;

		private AsymmetricAlgorithm lazyPrivateKey;

		private X509ExtensionCollection lazyExtensions;

		public X509ExtensionCollection Extensions => null;

		public bool HasPrivateKey => false;

		public AsymmetricAlgorithm PrivateKey => null;

		public X500DistinguishedName IssuerName => null;

		public DateTime NotAfter => default(DateTime);

		public DateTime NotBefore => default(DateTime);

		public PublicKey PublicKey => null;

		public byte[] RawData => null;

		public string SerialNumber => null;

		public Oid SignatureAlgorithm => null;

		public X500DistinguishedName SubjectName => null;

		public string Thumbprint => null;

		public int Version => 0;

		internal new X509Certificate2Impl Impl => null;

		public override void Reset()
		{
		}

		public X509Certificate2()
		{
		}

		public X509Certificate2(byte[] rawData)
		{
		}

		public X509Certificate2(X509Certificate certificate)
		{
		}

		protected X509Certificate2(SerializationInfo info, StreamingContext context)
		{
		}

		public static X509ContentType GetCertContentType(byte[] rawData)
		{
			return default(X509ContentType);
		}

		public string GetNameInfo(X509NameType nameType, bool forIssuer)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public override string ToString(bool verbose)
		{
			return null;
		}

		public bool Verify()
		{
			return false;
		}

		private static X509Extension CreateCustomExtensionIfAny(Oid oid)
		{
			return null;
		}
	}
}
