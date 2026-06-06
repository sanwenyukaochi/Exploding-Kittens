using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRepository : MonoBehaviour
{
	public static string LocalPlayerId;

	public IntIntEvent OnPlayerCountChanged;

	public PlayerDelegate OnAdd;

	public PlayerDelegate OnRemove;

	private List<Player> LivingPlayers => null;

	public bool AllPlayersAreDead => false;

	public Player Winner => null;

	public bool HasWinner => false;

	public List<Player> Players => null;

	public Player FirstLocalPlayer => null;

	public void Reset()
	{
	}

	public void Add(Player player)
	{
	}

	public void Remove(Player player)
	{
	}

	public Player FindById(string playerId)
	{
		return null;
	}

	public void NotifyPlayerCountChanged(Action playerCountChangingAction)
	{
	}

	public List<Player> Opponents(string id)
	{
		return null;
	}

	public List<Player> AliveOpponents(string id)
	{
		return null;
	}

	public List<Player> Opponents(Player player)
	{
		return null;
	}

	public List<Player> AliveOpponents(Player player)
	{
		return null;
	}

	public List<Player> StealableOpponents(Player player)
	{
		return null;
	}

	public List<Player> TakeThatOpponents(Player player)
	{
		return null;
	}

	public List<Player> AlivePlayers()
	{
		return null;
	}
}
