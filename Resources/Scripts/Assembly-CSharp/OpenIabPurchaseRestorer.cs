using OnePF;
using UnityEngine;

public class OpenIabPurchaseRestorer : MonoBehaviour
{
	public OpenIabInventoryLoader OpenIabInventoryLoader;

	public RestorePurchaseEvent OnPurchasesRestored;

	public RestorePurchaseErrorEvent OnPurchasesRestoreFailed;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void RestorePurchases()
	{
	}

	private void InventoryLoaded(Inventory inventory)
	{
	}

	private void OnTransactionRestored(string sku)
	{
	}

	private void OnTransactionsFinishedRestoring()
	{
	}

	private void OnTransactionsFailedRestoring(string reason)
	{
	}
}
