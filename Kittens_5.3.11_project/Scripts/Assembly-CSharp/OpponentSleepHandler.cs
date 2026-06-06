using UnityEngine;

public class OpponentSleepHandler : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public ParticleSystem SleepIndicator;

	private Player Player => null;

	private void Start()
	{
	}

	private void OnActivity(Activity activity)
	{
	}

	private void OnStartTurn(Player _, int __)
	{
	}

	private void OnDeath(Player _)
	{
	}

	private void HideSleepIndicator()
	{
	}

	private void ShowSleepIndicator()
	{
	}
}
