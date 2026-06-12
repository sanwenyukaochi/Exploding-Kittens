using UnityEngine;

public class TutorialChecklistItem : MonoBehaviour
{
	public PlayMakerFSM Fsm;

	public UILabel Label;

	[HideInInspector]
	public TutorialChecklistStep Step;

	public void Initialize(TutorialChecklistStep step, string title)
	{
	}

	public void Disable()
	{
	}

	public void Uncheck()
	{
	}

	public void Check()
	{
	}

	private void Event(string eventName)
	{
	}
}
