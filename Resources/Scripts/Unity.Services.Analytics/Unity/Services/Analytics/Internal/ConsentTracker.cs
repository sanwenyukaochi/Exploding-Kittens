namespace Unity.Services.Analytics.Internal
{
	internal class ConsentTracker : IConsentTracker
	{
		private readonly IGeoAPI m_GeoAPI;

		private readonly ICoreStatsHelper m_CoreStatsHelper;

		internal GeoIPResponse response;

		internal ConsentStatus optInPiplConsentStatus { get; set; }

		internal ConsentStatus optOutConsentStatus { get; set; }

		public ConsentTracker(ICoreStatsHelper coreStatsHelper)
		{
		}

		internal ConsentTracker(IGeoAPI geoApi, ICoreStatsHelper coreStatsHelper)
		{
		}

		public bool IsGeoIpChecked()
		{
			return false;
		}

		public bool IsConsentGiven()
		{
			return false;
		}

		public bool IsConsentGiven(string identifier)
		{
			return false;
		}

		public bool IsOptingOutInProgress()
		{
			return false;
		}

		public void FinishOptOutProcess()
		{
		}

		internal void ReadOptInPiplConsentStatus()
		{
		}

		internal void ReadOptOutConsentStatus()
		{
		}

		private void ValidateConsentWasChecked()
		{
		}
	}
}
