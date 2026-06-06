using Unity.Services.Analytics.Internal;

namespace Unity.Services.Analytics.Data
{
	internal class StdCommonParams
	{
		internal string GameStoreID { get; }

		internal string GameBundleID { get; set; }

		internal string Platform { get; set; }

		internal string UasUserID { get; set; }

		internal string Idfv { get; set; }

		internal double? DeviceVolume { get; set; }

		internal double? BatteryLoad { get; set; }

		internal string BuildGuuid { get; set; }

		internal string ClientVersion { get; set; }

		internal string UserCountry { get; }

		internal string ProjectID { get; set; }

		internal void SerializeCommonEventParams(ref IBuffer buf, string callingMethodIdentifier)
		{
		}
	}
}
