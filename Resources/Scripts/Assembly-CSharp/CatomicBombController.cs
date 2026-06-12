using UnityEngine;

public class CatomicBombController : MonoBehaviour
{
	public GameMessages GameMessages;

	public ActivityMessages ActivityMessages;

	public TurnQueue TurnQueue;

	public PlayerRepository PlayerRepository;

	public GameDeck GameDeck;

	private Deck Deck => null;

	public void OnPlayCatomicBomb(Player player, Card card)
	{
	}
}
