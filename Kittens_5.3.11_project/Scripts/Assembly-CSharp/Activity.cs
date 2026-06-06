using System;

[Serializable]
public class Activity
{
	public ActivityType ActivityType;

	public Player Subject;

	public Player Target;

	public bool HasTarget => false;

	public Activity(ActivityType activityType, Player subject, Player target)
	{
	}
}
