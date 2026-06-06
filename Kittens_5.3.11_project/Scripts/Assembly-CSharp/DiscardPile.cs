using System.Collections.Generic;
using UnityEngine;

public class DiscardPile : MonoBehaviour
{
	public DiscardedCardFactory DiscardedCardFactory;

	public CardStackPositionCalculator CardStackPositionCalculator;

	private List<DiscardedCard> cards;

	public void Discard(Player player, HandCard handCard, DiscardedCardEffect discardedCardEffect)
	{
	}

	public void Discard(Player player, Card card, Vector3 position, Vector3 startingScale, DiscardedCardEffect discardedCardEffect)
	{
	}
}
