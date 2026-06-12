namespace System.Threading
{
	public readonly struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable
	{
		private readonly CancellationCallbackInfo m_callbackInfo;

		private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo;

		internal CancellationTokenRegistration(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo)
		{
			m_callbackInfo = null;
			m_registrationInfo = default(SparselyPopulatedArrayAddInfo<CancellationCallbackInfo>);
		}

		public bool Unregister()
		{
			return false;
		}

		public void Dispose()
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(CancellationTokenRegistration other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
