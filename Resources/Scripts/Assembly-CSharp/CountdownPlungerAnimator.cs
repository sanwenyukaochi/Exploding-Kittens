using UnityEngine;

public class CountdownPlungerAnimator : MonoBehaviour
{
	public PlayMakerFSM PlungerFsm;

	public PlayMakerFSM SqueezeFsm;

	public CountdownProvider CountdownProvider;

	private Countdown Countdown => null;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void HitPlunger(int secondsLeft)
	{
	}

	private void HitPlunger()
	{
	}
}
