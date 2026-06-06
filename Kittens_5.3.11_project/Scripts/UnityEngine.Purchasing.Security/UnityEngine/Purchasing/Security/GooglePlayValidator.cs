namespace UnityEngine.Purchasing.Security
{
	internal class GooglePlayValidator
	{
		private RSAKey key;

		public GooglePlayValidator(byte[] rsaKey)
		{
		}

		public GooglePlayReceipt Validate(string receipt, string signature)
		{
			return null;
		}
	}
}
