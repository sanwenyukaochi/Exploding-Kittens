namespace OnePF
{
	public class SkuDetails
	{
		public string ItemType { get; private set; }

		public string Sku { get; private set; }

		public string Type { get; private set; }

		public string Price { get; private set; }

		public string Title { get; private set; }

		public string Description { get; private set; }

		public string Json { get; private set; }

		public string CurrencyCode { get; private set; }

		public string PriceValue { get; private set; }

		public SkuDetails(string jsonString)
		{
		}

		private void ParseFromJson()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
