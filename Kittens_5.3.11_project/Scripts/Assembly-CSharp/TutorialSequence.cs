using System.Collections.Generic;
using UnityEngine;

public class TutorialSequence : MonoBehaviour
{
	public List<TutorialSequenceStep> Steps;

	public NavigationController TutorialController;

	public NavigationController RootController;

	public WindowTransitioner FinalDestination;

	public TutorialChecklist TutorialChecklist;

	private int index;

	private TutorialSequenceStep CurrentStep => null;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnStepSuccess()
	{
	}

	public void NextTutorialStep()
	{
	}
}
