using System;
using UnityEngine;

public class WindowTransitioner : MonoBehaviour
{
	private const float ANIMATION_TIME = 0.25f;

	public UIPanel[] Panels;

	public WindowController OptionalWindowController;

	private bool didLoad;

	private Action onAnimationCompleted;

	public bool IsVisible;

	public string Name => null;

	public bool IsBackDisabled => false;

	private bool IsHidden => false;

	public void Show()
	{
	}

	public void Show(Action callback)
	{
	}

	public void Hide()
	{
	}

	public void Hide(Action callback)
	{
	}

	public void Hide(bool shouldDisableThisWindow, Action callback)
	{
	}

	private void Transition(float from, float to)
	{
	}

	public void OnTransitionCompleted()
	{
	}

	private void SetAlpha(float alpha)
	{
	}

	private void MapPanels(Action<UIPanel> callback)
	{
	}
}
