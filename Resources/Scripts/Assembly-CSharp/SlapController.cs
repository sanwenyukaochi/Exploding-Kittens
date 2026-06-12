using UnityEngine;

public class SlapController : MonoBehaviour
{
	public GameMessages GameMessages;

	public TurnQueue TurnQueue;

	public ActivityMessages ActivityMessages;

	private Player lastVictim;

	private int numTurnsRemainingFromPlayer;

	public void OpponentChosen(Player player, Player targetedPlayer, Card card)
	{
	}

	private void CancelAttack()
	{
	}

	private void CancelAttackDied(Player _)
	{
	}

	private void AddResponders(Player player)
	{
	}

	private void RemoveResponders(Player player)
	{
	}

	private void AttackedPlayerEndTurn(Player player)
	{
	}

	private int TurnsForAttack(Card card)
	{
		return 0;
	}

	public void AttackPlayer(Player attacker, Player victim, int turns)
	{
	}
}
