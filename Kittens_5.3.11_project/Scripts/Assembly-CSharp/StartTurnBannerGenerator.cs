using UnityEngine;

public class StartTurnBannerGenerator : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public ActivityBannerQueue ActivityBannerQueue;

	public UIAtlas CardTableAtlas;

	public string HeaderText;

	public void Start()
	{
	}

	private void OnStartTurn(Player player, int turnsRemaining)
	{
	}
}
