using UnityEngine;

public class FutureBannerGenerator : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public ActivityBannerQueue ActivityBannerQueue;

	public UIAtlas TargetAtlas;

	public string HeaderText;

	public void Start()
	{
	}

	private void OnPlayCard(Player player, Card card)
	{
	}

	private int NumFutureSeen(Card card)
	{
		return 0;
	}
}
