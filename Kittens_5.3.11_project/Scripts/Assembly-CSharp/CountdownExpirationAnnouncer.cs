using UnityEngine;

public class CountdownExpirationAnnouncer : MonoBehaviour
{
	public Countdown Countdown;

	public ActivityMessages ActivityMessages;

	public PlayerProvider PlayerProvider;

	public string SoundName;

	public ActivityType ActivityMessage;

	private Player Player => null;

	private void Awake()
	{
	}

	private void OnCountdownEnded()
	{
	}
}
