namespace UnityEngine.Purchasing.Security
{
	public class CrossPlatformValidator
	{
		private GooglePlayValidator google;

		private AppleValidator apple;

		private string googleBundleId;

		private string appleBundleId;

		public CrossPlatformValidator(byte[] googlePublicKey, byte[] appleRootCert, string appBundleId)
		{
		}

		public CrossPlatformValidator(byte[] googlePublicKey, byte[] appleRootCert, byte[] unityChannelPublicKey_not_used, string googleBundleId, string appleBundleId, string xiaomiBundleId_not_used)
		{
		}

		public IPurchaseReceipt[] Validate(string unityIAPReceipt)
		{
			return null;
		}
	}
}
