using UnityEngine;

public class SlapBannerGenerator : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public ActivityBannerQueue ActivityBannerQueue;

	public UIAtlas PlayerAtlas;

	public string HeaderText;

	public void Start()
	{
	}

	private void OnAttack(Player attacker, Player victim, int turnsRemaining)
	{
	}
}
