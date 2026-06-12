using UnityEngine;

public class TargetSelectionNotifier : MonoBehaviour
{
	public ActivityMessages ActivityMessages;

	public PlayerRepository PlayerRepository;

	private void Start()
	{
	}

	private void OnPlayCard(Player player, Card card)
	{
	}

	private ActivityType? TypeForCard(Card card)
	{
		return null;
	}
}
