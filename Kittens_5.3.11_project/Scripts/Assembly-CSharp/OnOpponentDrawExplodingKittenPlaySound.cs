using System.Collections.Generic;
using UnityEngine;

public class OnOpponentDrawExplodingKittenPlaySound : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public PlayerRepository PlayerRepository;

	private string soundEffectName;

	private List<Player> MyOpponents => null;

	private Player Player => null;

	private void Start()
	{
	}

	private void OnDrawExplodingKitten(Player player, Card card)
	{
	}

	private void OnPlayCard(Player _, Card card)
	{
	}

	private void OnDisconnect(Player _)
	{
	}
}
