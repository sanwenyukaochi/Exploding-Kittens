using System.IO;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using Mono.Net.Security;
using Mono.Security.Interface;

namespace System.Net.Security
{
	public class SslStream : AuthenticatedStream
	{
		private MobileTlsProvider provider;

		private MonoTlsSettings settings;

		private RemoteCertificateValidationCallback validationCallback;

		private LocalCertificateSelectionCallback selectionCallback;

		private MobileAuthenticatedStream impl;

		private bool explicitSettings;

		internal MobileAuthenticatedStream Impl => null;

		internal string InternalTargetHost => null;

		public override bool IsAuthenticated => false;

		public virtual X509Certificate LocalCertificate => null;

		public override bool CanSeek => false;

		public override bool CanRead => false;

		public override bool CanTimeout => false;

		public override bool CanWrite => false;

		public override int ReadTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int WriteTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override long Length => 0L;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		private static MobileTlsProvider GetProvider()
		{
			return null;
		}

		public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback)
			: base(null, leaveInnerStreamOpen: false)
		{
		}

		public SslStream(Stream innerStream, bool leaveInnerStreamOpen, RemoteCertificateValidationCallback userCertificateValidationCallback, LocalCertificateSelectionCallback userCertificateSelectionCallback)
			: base(null, leaveInnerStreamOpen: false)
		{
		}

		internal SslStream(Stream innerStream, bool leaveInnerStreamOpen, MonoTlsProvider provider, MonoTlsSettings settings)
			: base(null, leaveInnerStreamOpen: false)
		{
		}

		private void SetAndVerifyValidationCallback(RemoteCertificateValidationCallback callback)
		{
		}

		private void SetAndVerifySelectionCallback(LocalCertificateSelectionCallback callback)
		{
		}

		public virtual void AuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
		}

		public virtual IAsyncResult BeginAuthenticateAsClient(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation, AsyncCallback asyncCallback, object asyncState)
		{
			return null;
		}

		public virtual void EndAuthenticateAsClient(IAsyncResult asyncResult)
		{
		}

		public virtual Task AuthenticateAsClientAsync(string targetHost, X509CertificateCollection clientCertificates, SslProtocols enabledSslProtocols, bool checkCertificateRevocation)
		{
			return null;
		}

		public override void SetLength(long value)
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public override void Flush()
		{
		}

		private void CheckDisposed()
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			return 0;
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			return null;
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
		}
	}
}
