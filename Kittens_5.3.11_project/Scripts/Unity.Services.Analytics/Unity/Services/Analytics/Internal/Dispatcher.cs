namespace Unity.Services.Analytics.Internal
{
	internal class Dispatcher : IDispatcher
	{
		private readonly IWebRequestHelper m_WebRequestHelper;

		private readonly string m_CollectUrl;

		private IBuffer m_DataBuffer;

		private IWebRequest m_FlushRequest;

		private int m_FlushBufferIndex;

		public int ConsecutiveFailedUploadCount { get; private set; }

		internal bool FlushInProgress { get; private set; }

		public Dispatcher(IWebRequestHelper webRequestHelper, string collectUrl)
		{
		}

		public void SetBuffer(IBuffer buffer)
		{
		}

		public void Flush()
		{
		}

		private void FlushBufferToService()
		{
		}

		private void UploadCompleted(long responseCode)
		{
		}
	}
}
