using System;

public class ActivityGate
{
	private ActivityType activityType;

	private Func<Activity, bool> additionalConditions;

	public ActivityGate(ActivityType activityType, Func<Activity, bool> additionalConditions)
	{
	}

	public void Try(Activity activity, Action action)
	{
	}

	public bool Passes(Activity activity)
	{
		return false;
	}
}
