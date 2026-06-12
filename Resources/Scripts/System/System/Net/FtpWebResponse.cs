using System.IO;

namespace System.Net
{
	public class FtpWebResponse : WebResponse, IDisposable
	{
		internal sealed class EmptyStream : MemoryStream
		{
			internal EmptyStream()
			{
			}
		}

		internal Stream _responseStream;

		private long _contentLength;

		private Uri _responseUri;

		private FtpStatusCode _statusCode;

		private string _statusLine;

		private WebHeaderCollection _ftpRequestHeaders;

		private DateTime _lastModified;

		private string _bannerMessage;

		private string _welcomeMessage;

		private string _exitMessage;

		public override WebHeaderCollection Headers => null;

		public override Uri ResponseUri => null;

		public FtpStatusCode StatusCode => default(FtpStatusCode);

		internal FtpWebResponse(Stream responseStream, long contentLength, Uri responseUri, FtpStatusCode statusCode, string statusLine, DateTime lastModified, string bannerMessage, string welcomeMessage, string exitMessage)
		{
		}

		internal void UpdateStatus(FtpStatusCode statusCode, string statusLine, string exitMessage)
		{
		}

		public override Stream GetResponseStream()
		{
			return null;
		}

		internal void SetResponseStream(Stream stream)
		{
		}

		public override void Close()
		{
		}
	}
}
