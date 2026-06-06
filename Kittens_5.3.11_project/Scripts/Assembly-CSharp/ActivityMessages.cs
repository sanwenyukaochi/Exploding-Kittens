using UnityEngine;

public class ActivityMessages : MonoBehaviour
{
	public PlayerRepository PlayerRepository;

	public ActivityStream ActivityStream;

	private IMessageClient MessageClient => null;

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	public void WriteActivityMessage(NetworkMessage message)
	{
	}

	public void WriteLocalActivityMessage(ActivityType type, Player subject, Player target)
	{
	}

	public void SendActivityMessage(ActivityType type, Player subject)
	{
	}

	public void SendActivityMessage(ActivityType activityType, Player subject, Player target)
	{
	}
}
