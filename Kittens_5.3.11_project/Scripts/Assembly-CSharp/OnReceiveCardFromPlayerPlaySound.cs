using UnityEngine;

public class OnReceiveCardFromPlayerPlaySound : MonoBehaviour
{
	public PlayerRepository PlayerRepository;

	private const string soundEffectName = "Received.Card";

	private void Start()
	{
	}

	private void OnReceiveCardFromPlayer(Player player, Player fromPlayer, Card card)
	{
	}
}
