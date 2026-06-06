using UnityEngine;

public class DefuseController : MonoBehaviour
{
	public ActivityMessages ActivityMessages;

	public TurnQueue TurnQueue;

	public void OnPlayDefuseCard(Player player, Card card)
	{
	}

	private bool HasTurnsRemaining(Player player)
	{
		return false;
	}
}
