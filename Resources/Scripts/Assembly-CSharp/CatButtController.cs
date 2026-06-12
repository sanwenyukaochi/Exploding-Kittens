using UnityEngine;

public class CatButtController : MonoBehaviour
{
	public GameMessages GameMessages;

	public ActivityMessages ActivityMessages;

	public void OpponentChosen(Player player, Player targetedPlayer, Card _)
	{
	}

	private void OnEndTurnWithDraw(Player player)
	{
	}
}
