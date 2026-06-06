namespace Unity.Services.Analytics.Internal
{
	internal interface IConsentTracker
	{
		void FinishOptOutProcess();

		bool IsGeoIpChecked();

		bool IsConsentGiven();

		bool IsOptingOutInProgress();
	}
}
