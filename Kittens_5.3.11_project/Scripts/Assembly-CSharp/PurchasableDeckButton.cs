using UnityEngine;

public class PurchasableDeckButton : MonoBehaviour
{
	public IapButtonLabelUpdater IapButtonLabelUpdater;

	public DeckMetadataRepository DeckMetadataRepository;

	public SpinnyButton SpinnyButton;

	public DeckType DeckType;

	public DeckPurchaseEvent OnDeckSelected;

	public GameObject PurchasePopUp;

	public DeckMetadata DeckMetadata => null;

	private void Start()
	{
	}

	public void StartSpinning()
	{
	}

	public void StopSpinning()
	{
	}

	public void DeckSelected()
	{
	}

	public void DeckSelectedPurchaseOnly()
	{
	}

	public void BarkingSelected()
	{
	}

	private bool IsUnlocked(DeckMetadata deck)
	{
		return false;
	}
}
