using UnityEngine;

public class RandomInternetGameCountdownController : MonoBehaviour
{
	public Countdown Countdown;

	public Gate AcceptableGameTestingGate;

	public PlayerRepository PlayerRepository;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPlayerCountChanged(int count, int oldCount)
	{
	}

	private void OnGateChanged()
	{
	}

	private void RestartCountdownIfPossible()
	{
	}
}
