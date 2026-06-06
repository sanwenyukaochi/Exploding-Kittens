using System.IO;
using System.Runtime.Serialization;

namespace System.Net
{
	[Serializable]
	public class HttpWebResponse : WebResponse, ISerializable, IDisposable
	{
		private Uri uri;

		private WebHeaderCollection webHeaders;

		private CookieCollection cookieCollection;

		private string method;

		private Version version;

		private HttpStatusCode statusCode;

		private string statusDescription;

		private long contentLength;

		private string contentType;

		private CookieContainer cookie_container;

		private bool disposed;

		private Stream stream;

		public override WebHeaderCollection Headers => null;

		public override Uri ResponseUri => null;

		public virtual HttpStatusCode StatusCode => default(HttpStatusCode);

		public virtual string StatusDescription => null;

		public HttpWebResponse()
		{
		}

		internal HttpWebResponse(Uri uri, string method, HttpStatusCode status, WebHeaderCollection headers)
		{
		}

		internal HttpWebResponse(Uri uri, string method, WebResponseStream stream, CookieContainer container)
		{
		}

		[Obsolete("Serialization is obsoleted for this type", false)]
		protected HttpWebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		public override Stream GetResponseStream()
		{
			return null;
		}

		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		protected override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		public override void Close()
		{
		}

		private new void Dispose()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}

		protected override void Dispose(bool disposing)
		{
		}

		private void CheckDisposed()
		{
		}

		private void FillCookies()
		{
		}
	}
}
