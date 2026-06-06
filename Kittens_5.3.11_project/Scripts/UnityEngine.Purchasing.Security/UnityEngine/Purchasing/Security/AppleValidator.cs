namespace UnityEngine.Purchasing.Security
{
	public class AppleValidator
	{
		private X509Cert cert;

		private AppleReceiptParser parser;

		public AppleValidator(byte[] appleRootCertificate)
		{
		}

		public AppleReceipt Validate(byte[] receiptData)
		{
			return null;
		}
	}
}
