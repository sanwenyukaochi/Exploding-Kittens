using System;
using System.Collections.Generic;
using UnityEngine;

public class SeeTheFutureModal : MonoBehaviour
{
	public Countdown Countdown;

	public List<SimpleCard> SimpleCards;

	public WindowTransitioner WindowTransitioner;

	public CatPawCountdownFactory CatPawCountdownFactory;

	private Action doneCallback;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void RevealCards(List<Card> cards, Action doneCallback)
	{
	}

	public void Hide()
	{
	}

	public void Reset()
	{
	}

	private void ResetThenHide()
	{
	}

	private void SetupCards(List<Card> cards)
	{
	}

	private void OnCountdownEnded()
	{
	}
}
