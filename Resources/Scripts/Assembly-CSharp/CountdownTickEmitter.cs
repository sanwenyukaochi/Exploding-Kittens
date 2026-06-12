using UnityEngine;

public class CountdownTickEmitter : MonoBehaviour
{
	public string[] TickSoundNames;

	public CatPawCountdown CatPawCountdown;

	public CountdownProvider CountdownProvider;

	private bool shown;

	private string RandomTickSoundName => null;

	private Countdown Countdown => null;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Tick(int _)
	{
	}
}
