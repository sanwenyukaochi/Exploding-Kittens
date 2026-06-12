using UnityEngine;

public class KittenRollCallController : MonoBehaviour
{
	public GameMessages GameMessages;

	public ActivityMessages ActivityMessages;

	public TurnQueue TurnQueue;

	public PlayerRepository PlayerRepository;

	public GameDeck GameDeck;

	private Deck Deck => null;

	public void OnPlayKittenRollCall(Player player, Card card)
	{
	}
}
