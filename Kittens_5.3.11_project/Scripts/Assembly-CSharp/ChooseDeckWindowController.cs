using System.Collections.Generic;
using UnityEngine;

public class ChooseDeckWindowController : MonoBehaviour
{
	public NavigationController NavigationController;

	public MessageBoxModal MessageBoxModal;

	public InAppPurchaseController InAppPurchaseController;

	public List<PurchasableDeckButton> PurchasableDeckButtons;

	public DeckMetadataRepository DeckMetadataRepository;

	public GameObject PurchasePopUp;

	private ActionBase deckWasChosenAction;

	private DeckMetadata lastChosenDeck;

	private bool purchaseOnly;

	private PurchasableDeckButton LastSelectedDeckButton => null;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void Initialize(ActionBase deckWasChosenAction)
	{
	}

	private void DebugActOnCoreDeck()
	{
	}

	public void OnDeckSelected(DeckMetadata deck, bool purchaseonly = false)
	{
	}

	public void OnDeckSelectedViaPromotion(DeckType deckType)
	{
	}

	private bool IsUnlocked(DeckMetadata deck)
	{
		return false;
	}

	private void ActivateDeckAndCallback(DeckType deckType)
	{
	}

	private void OnPurchaseSucceeded()
	{
	}

	private void OnPurchasedItemAlreadyOwned()
	{
	}

	private void OnPurchaseFailed()
	{
	}

	private void ReenablePurchaseButtons()
	{
	}
}
