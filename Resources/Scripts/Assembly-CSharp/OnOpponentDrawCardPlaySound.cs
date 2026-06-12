using System.Collections.Generic;
using UnityEngine;

public class OnOpponentDrawCardPlaySound : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public PlayerRepository PlayerRepository;

	private const string soundEffectName = "OpponentDrawCard";

	private List<Player> MyOpponents => null;

	private Player Player => null;

	private void Start()
	{
	}

	private void OnDrawCard(Player player, Card card)
	{
	}
}
