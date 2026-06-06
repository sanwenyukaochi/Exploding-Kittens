using System;
using UnityEngine;

public class CatPawCountdown : MonoBehaviour
{
	public UILabel CountdownLabel;

	public PlayMakerFSM ShowHideFsm;

	public CountdownProvider CountdownProvider;

	private Countdown countdown;

	private ActivityBanner activityBanner;

	private float showThreshold;

	private bool isVisible;

	public void Initialize(Countdown countdown, ActivityBanner activityBanner)
	{
	}

	private void OnDestroy()
	{
	}

	private void DeregisterEvents()
	{
	}

	public void WhenVisible(Action callback)
	{
	}

	private void OnCountdownUpdated(int secondsLeft)
	{
	}

	private void HideAndDestroy()
	{
	}
}
