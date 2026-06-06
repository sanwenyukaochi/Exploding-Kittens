using OnePF;

public class PriceFinder
{
	private Inventory inventory;

	private static PriceFinder instance;

	public static PriceFinder Instance => null;

	public bool HasInventory => false;

	public void UpdateInventory(Inventory inventory)
	{
	}

	public string GetPrice(string sku)
	{
		return null;
	}

	public bool HasProduct(string sku)
	{
		return false;
	}
}
