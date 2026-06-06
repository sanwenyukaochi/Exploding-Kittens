using UnityEngine;

public class PlayerCountLabelUpdater : MonoBehaviour
{
	public UILabel Label;

	public PlayerRepository PlayerRepository;

	public string Template;

	private string TextWithPlayerCount => null;

	private int PlayerCount => 0;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPlayerCountChanged(int _, int __)
	{
	}

	private void UpdateLabel()
	{
	}
}
