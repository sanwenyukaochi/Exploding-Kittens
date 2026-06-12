using System;

[Serializable]
public class PromotionalPlayOffer
{
	public string ModalTitle;

	public string ModalDescription;

	public DeckType DeckType;

	public string Id => null;

	public bool ProductAlreadyPurchased => false;

	private DeckMetadata DeckMetadata => null;
}
