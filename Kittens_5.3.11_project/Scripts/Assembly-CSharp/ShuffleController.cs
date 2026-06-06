using UnityEngine;

public class ShuffleController : MonoBehaviour
{
	public GameMessages GameMessages;

	public ActivityMessages ActivityMessages;

	public GameDeck GameDeck;

	private Deck Deck => null;

	public void OnPlayShuffleCard(Player player, Card card)
	{
	}
}
