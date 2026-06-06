using System.Collections.Generic;
using UnityEngine;

public class PlayerReadinessMonitor : MonoBehaviour
{
	public PlayersReadyEventDelegate OnPlayersReady;

	public HashSet<Player> ReadyPlayers;

	private bool AllPlayersAreReady => false;

	public void PlayerIsReady(Player player)
	{
	}
}
