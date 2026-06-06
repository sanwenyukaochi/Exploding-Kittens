using System.IO;
using System.Runtime.Serialization;

namespace System.Net
{
	[Serializable]
	public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable
	{
		private bool m_IsFromCache;

		public virtual bool IsFromCache => false;

		public virtual Uri ResponseUri => null;

		public virtual WebHeaderCollection Headers => null;

		protected WebResponse()
		{
		}

		protected WebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		public virtual void Close()
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public virtual Stream GetResponseStream()
		{
			return null;
		}
	}
}
