using UnityEngine;

public class DiarrheaController : MonoBehaviour
{
	public GameMessages GameMessages;

	public ActivityMessages ActivityMessages;

	private PlayerEndTurnMonitor playerEndTurnMonitor;

	public void OpponentChosen(Player player, Player targetedPlayer, Card card)
	{
	}

	private void OnEndTurnWithDraw(Player player)
	{
	}

	private int AmountToDiarrhea(Card card)
	{
		return 0;
	}
}
