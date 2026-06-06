namespace OnePF
{
	public class Purchase
	{
		public string ItemType { get; private set; }

		public string OrderId { get; private set; }

		public string PackageName { get; private set; }

		public string Sku { get; private set; }

		public long PurchaseTime { get; private set; }

		public int PurchaseState { get; private set; }

		public string DeveloperPayload { get; private set; }

		public string Token { get; private set; }

		public string OriginalJson { get; private set; }

		public string Signature { get; private set; }

		public string AppstoreName { get; private set; }

		public string Receipt { get; private set; }

		private Purchase()
		{
		}

		public Purchase(string jsonString)
		{
		}

		public static Purchase CreateFromSku(string sku)
		{
			return null;
		}

		public static Purchase CreateFromSku(string sku, string developerPayload)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public string Serialize()
		{
			return null;
		}
	}
}
