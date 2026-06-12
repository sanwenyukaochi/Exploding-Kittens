using System;
using UnityEngine;

public class WindowTransitioner2 : MonoBehaviour
{
	private const float ANIMATION_TIME = 0.5f;

	public UIPanel[] Panels;

	public WindowController OptionalWindowController;

	private bool didLoad;

	private Action onAnimationCompleted;

	public bool IsVisible;

	private CanvasRenderer[] CanvasRenderers;

	public string Name => null;

	public bool IsBackDisabled => false;

	private bool IsHidden => false;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

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
