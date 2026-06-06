using UnityEngine;

public class FlagButtonController : MonoBehaviour
{
	public TogglyButton TogglyButton;

	public PlayerProvider PlayerProvider;

	private Player Opponent => null;

	private FlaggedDeviceIdRepository FlaggedDeviceIdRepository => null;

	private void OnEnable()
	{
	}

	private void Refresh()
	{
	}

	public void Toggle()
	{
	}
}
