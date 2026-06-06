using UnityEngine;

public class ActivityStream : MonoBehaviour
{
	public ActivityEvent OnActivity;

	public static ActivityStream Instance;

	private void Awake()
	{
	}

	public void Write(Activity activity)
	{
	}
}
