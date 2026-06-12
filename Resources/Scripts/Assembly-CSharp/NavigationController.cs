using System;
using System.Collections.Generic;
using UnityEngine;

public class NavigationController : MonoBehaviour
{
	public WindowTransitioner StartingWindow;

	public bool AutomaticallyShowStartingWindow;

	private WindowTransitioner currentWindow;

	private Stack<WindowTransitioner> HistoryStack;

	private Queue<Action> transitions;

	private bool performingTransition;

	public bool IsAtRoot => false;

	private WindowTransitioner CurrentWindow
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private bool HasCurrentWindow => false;

	public bool IsBackDisabled => false;

	public void OnEnable()
	{
	}

	public void Push(WindowTransitioner window)
	{
	}

	private void Enqueue(Action transition)
	{
	}

	private void PerformTransition()
	{
	}

	public void PresentModally(WindowTransitioner window)
	{
	}

	public void Push(WindowTransitioner window, bool disablePresentingWindow)
	{
	}

	public void Pop()
	{
	}

	public void PopToRoot()
	{
	}

	private void ShowWindow(WindowTransitioner window)
	{
	}

	private void TransitionTo(WindowTransitioner window, bool disablePresentingWindow, bool shouldHideCurrentWindow = true)
	{
	}
}
