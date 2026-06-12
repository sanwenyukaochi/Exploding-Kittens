using System.Collections.Generic;
using UnityEngine;

public class TutorialChecklist : MonoBehaviour
{
	public WindowTransitioner Window;

	public TutorialChecklistItemDefinition[] ItemDefinitions;

	public TutorialChecklistItemFactory ItemFactory;

	private List<TutorialChecklistItem> items;

	public void Initialize()
	{
	}

	public void OnShowingStep(TutorialChecklistStep step)
	{
	}

	public void CompleteStep(TutorialChecklistStep step)
	{
	}

	private TutorialChecklistItem ItemForStep(TutorialChecklistStep step)
	{
		return null;
	}

	private bool StepIsInChecklist(TutorialChecklistStep step)
	{
		return false;
	}
}
