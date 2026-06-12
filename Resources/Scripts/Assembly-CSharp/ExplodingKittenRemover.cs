using System.Collections.Generic;
using UnityEngine;

public class ExplodingKittenRemover : MonoBehaviour
{
	public GameDeck GameDeck;

	public PlayerRepository PlayerRepository;

	private List<Player> playersWhoDied;

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	public void OnDeath(Player player)
	{
	}

	public void OnDisconnect(Player player)
	{
	}
}
