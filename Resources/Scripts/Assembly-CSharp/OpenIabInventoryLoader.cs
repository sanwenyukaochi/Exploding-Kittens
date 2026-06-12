using OnePF;
using UnityEngine;

public class OpenIabInventoryLoader : MonoBehaviour
{
	public PurchasableProductRepository PurchasableProductRepository;

	public InventoryLoadEvent OnInventoryLoaded;

	public InventoryErrorEvent OnInventoryFailedToLoad;

	public OpenIabInitializer OpenIabInitializer;

	private bool canQueryInventory;

	public void QueryInventory()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnBillingInitialized()
	{
	}

	private void InventoryQuerySucceeded(Inventory inventory)
	{
	}

	private void InventoryQueryFailed(string reason)
	{
	}
}
