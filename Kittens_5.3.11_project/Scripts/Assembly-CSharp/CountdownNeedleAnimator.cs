using UnityEngine;

public class CountdownNeedleAnimator : MonoBehaviour
{
	public CatPawCountdown CatPawCountdown;

	public Transform Needle;

	public RotationAction NeedleRotationAction;

	public CountdownProvider CountdownProvider;

	public int TotalSecondsInDial;

	public int DialDirection;

	public bool ManualFlag;

	private Countdown Countdown => null;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Tick(int secondsLeft)
	{
	}

	public void TickManual(int secondsLeft, bool animate)
	{
	}

	private Vector3 CalculateNeedleRotation(int targetSeconds)
	{
		return default(Vector3);
	}
}
