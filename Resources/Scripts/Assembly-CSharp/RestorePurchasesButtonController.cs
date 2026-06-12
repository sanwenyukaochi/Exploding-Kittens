using UnityEngine;

public class RestorePurchasesButtonController : MonoBehaviour
{
	public SpinnyButton RestorePurchasesSpinnyButton;

	public OpenIabPurchaseRestorer OpenIabPurchaseRestorer;

	public MessageBoxModal MessageBoxModal;

	private float FailTimer;

	public GameObject InputBlock;

	public void OnRestorePurchasesClicked()
	{
	}

	private void OnPurchasesRestored()
	{
	}

	private void OnPurchasesRestoreFailed()
	{
	}

	private void RegisterForPurchaseRestoreCallbacks()
	{
	}

	private void UnregisterForPurchaseRestoreCallbacks()
	{
	}

	private void Update()
	{
	}
}
