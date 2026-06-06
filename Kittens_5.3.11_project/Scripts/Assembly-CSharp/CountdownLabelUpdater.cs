using UnityEngine;

public class CountdownLabelUpdater : MonoBehaviour
{
	public Countdown Countdown;

	public UILabel CountdownLabel;

	public void Awake()
	{
	}

	private void OnCountdownUpdated(int secondsLeft)
	{
	}
}
