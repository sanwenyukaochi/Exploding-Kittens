using UnityEngine;

public class NextDrawnCardProvider : MonoBehaviour
{
	public GameDeck GameDeck;

	public PlayerProvider PlayerProvider;

	private bool nextCardIsRandom;

	public Card Value => null;

	private Player Player => null;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnPlayCard(Player player, Card card)
	{
	}

	private void OnEndTurn(Player player)
	{
	}
}
