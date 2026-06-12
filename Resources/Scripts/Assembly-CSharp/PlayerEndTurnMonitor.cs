using System;

public class PlayerEndTurnMonitor
{
	public bool DidDrawDuringLastTurn;

	private Player player;

	private Action<Player> action;

	public PlayerEndTurnMonitor(Player player, Action<Player> action)
	{
	}

	private void StopMonitoring()
	{
	}

	private void OnStartTurn(Player player, int _)
	{
	}

	private void OnDrawCard(Player player, Card _)
	{
	}

	private void OnEndTurn(Player player)
	{
	}
}
