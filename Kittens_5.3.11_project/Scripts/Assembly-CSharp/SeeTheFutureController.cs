using UnityEngine;

public class SeeTheFutureController : MonoBehaviour
{
	public GameMessages GameMessages;

	public ActivityMessages ActivityMessages;

	public GameDeck GameDeck;

	public Deck Deck => null;

	public void OnPlaySeeTheFutureCard(Player player, Card card)
	{
	}

	public int NumVisibleCards(CardCategory cardCategory)
	{
		return 0;
	}
}
