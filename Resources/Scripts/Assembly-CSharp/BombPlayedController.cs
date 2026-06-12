using UnityEngine;

public class BombPlayedController : MonoBehaviour
{
	public GameMessages GameMessages;

	public ActivityMessages ActivityMessages;

	public GameDeck GameDeck;

	private Deck Deck => null;

	public void OnBombPlayed(Player player, Card card)
	{
	}

	private void Update()
	{
	}
}
