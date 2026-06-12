using System;
using System.Collections.Generic;
using Unity.Services.Analytics.Data;
using Unity.Services.Analytics.Internal;
using Unity.Services.Authentication.Internal;
using Unity.Services.Core.Configuration.Internal;
using Unity.Services.Core.Device.Internal;

namespace Unity.Services.Analytics
{
	internal class AnalyticsServiceInstance : IAnalyticsService, IUnstructuredEventRecorder, IBufferIds
	{
		internal enum ConsentFlow
		{
			Neither = 0,
			Old = 1,
			New = 2
		}

		private const string k_ForgetCallingId = "com.unity.services.analytics.Events.OptOut";

		private const string m_StartUpCallingId = "com.unity.services.analytics.Events.Startup";

		private readonly TimeSpan k_BackgroundSessionRefreshPeriod;

		private readonly StdCommonParams m_CommonParams;

		private readonly IPlayerId m_PlayerId;

		private readonly IInstallationId m_InstallId;

		private readonly IDataGenerator m_DataGenerator;

		private readonly ICoreStatsHelper m_CoreStatsHelper;

		private readonly IConsentTracker m_ConsentTracker;

		private readonly IDispatcher m_DataDispatcher;

		private readonly IAnalyticsForgetter m_AnalyticsForgetter;

		private readonly IExternalUserId m_CustomUserId;

		private readonly IAnalyticsServiceSystemCalls m_SystemCalls;

		private readonly IAnalyticsContainer m_Container;

		internal IBuffer m_DataBuffer;

		private int m_BufferLengthAtLastGameRunning;

		private DateTime m_ApplicationPauseTime;

		private bool m_IsActive;

		private ConsentFlow m_ConsentFlow;

		private bool m_StartUpEventsRecorded;

		private readonly TransactionCurrencyConverter converter;

		internal string CustomAnalyticsId => null;

		public string SessionID { get; private set; }

		public string UserId => null;

		public string InstallId => null;

		public string PlayerId => null;

		public string SessionId => null;

		internal int AutoflushPeriodMultiplier => 0;

		internal void OldForgetMeEventUploaded()
		{
		}

		internal AnalyticsServiceInstance(IDataGenerator dataGenerator, IBuffer realBuffer, ICoreStatsHelper coreStatsHelper, IConsentTracker consentTracker, IDispatcher dispatcher, IAnalyticsForgetter forgetter, IInstallationId installId, IPlayerId playerId, string environment, IExternalUserId customAnalyticsId, IAnalyticsServiceSystemCalls systemCalls, IAnalyticsContainer container)
		{
		}

		internal void ResumeDataDeletionIfNecessary()
		{
		}

		internal void DeactivateWithDataDeletionRequest()
		{
		}

		private void DataDeletionCompleted()
		{
		}

		private void Deactivate()
		{
		}

		public string GetAnalyticsUserID()
		{
			return null;
		}

		internal void ApplicationPaused(bool paused)
		{
		}

		internal void RefreshSessionID()
		{
		}

		public void Flush()
		{
		}

		internal void ApplicationQuit()
		{
		}

		internal void RecordGameRunningIfNecessary()
		{
		}

		private void SetVariableCommonParams()
		{
		}

		public void CustomData(string eventName, IDictionary<string, object> eventParams, int? eventVersion, bool includeCommonParams, bool includePlayerIds, string callingMethodIdentifier)
		{
		}

		private void SerializeObject(string eventName, string key, object value)
		{
		}

		public long ConvertCurrencyToMinorUnits(string currencyCode, double value)
		{
			return 0L;
		}
	}
}
