using System.Collections.Generic;
using UnityEngine;

public class TurnQueue : MonoBehaviour
{
	public int TurnsRemaining;

	public TurnQueueDirection Direction;

	public DirectionChangeEvent OnDirectionChange;

	public Player CurrentPlayer => null;

	public List<Player> Queue => null;

	public void Initialize(List<Player> players)
	{
	}

	public void AddPlayerToRotation(Player player)
	{
	}

	public void Reverse()
	{
	}

	private void FlipDirection()
	{
	}

	public void Reset()
	{
	}

	public void ResetTurnsRemaining()
	{
	}

	public void RotateToPlayer(Player player)
	{
	}

	private void Rotate()
	{
	}

	public Player PeekNextPlayer()
	{
		return null;
	}

	public Player PeekNextAlivePlayer()
	{
		return null;
	}

	public void AdvanceTurn()
	{
	}

	public int IndexOf(Player player)
	{
		return 0;
	}

	public List<Player> OpponentList(Player currentPlayer)
	{
		return null;
	}

	public List<Player> TurnQueueFrom(Player player)
	{
		return null;
	}
}
