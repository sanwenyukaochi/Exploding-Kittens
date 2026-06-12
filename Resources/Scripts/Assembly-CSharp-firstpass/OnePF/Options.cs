using System.Collections.Generic;

namespace OnePF
{
	public class Options
	{
		public const int DISCOVER_TIMEOUT_MS = 5000;

		public const int INVENTORY_CHECK_TIMEOUT_MS = 10000;

		public int discoveryTimeoutMs;

		public bool checkInventory;

		public int checkInventoryTimeoutMs;

		public OptionsVerifyMode verifyMode;

		public SearchStrategy storeSearchStrategy;

		public Dictionary<string, string> storeKeys;

		public string[] prefferedStoreNames;

		public string[] availableStoreNames;

		public int samsungCertificationRequestCode;
	}
}
