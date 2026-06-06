using System;
using System.Collections.Generic;
using UnityEngine;

public class AlterTheFutureModal : MonoBehaviour
{
	public Countdown Countdown;

	public WindowTransitioner WindowTransitioner;

	public CatPawCountdownFactory CatPawCountdownFactory;

	public GridController GridController;

	public UILabel DescriptionLabel;

	public DraggableCardFactory DraggableCardFactory;

	public Transform TopCardAccessory;

	public Transform BottomCardAccessory;

	public GridAccessoryPositionCalculator GridAccessoryPositionCalculator;

	public GameDeck GameDeck;

	public GameMessages GameMessages;

	public PlayerProvider PlayerProvider;

	public GameObject AlterBannerImage;

	public GameObject ShareBannerImage;

	private Action doneCallback;

	private List<DraggableCard> draggableCards;

	private bool DoneFlag;

	private List<Card> ReorderedCards => null;

	private Deck Deck => null;

	private Player Player => null;

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void RevealCards(List<Card> cards, Action doneCallback)
	{
	}

	public void RevealSTFCards(List<Card> cards, Action doneCallback)
	{
	}

	public void Reset()
	{
	}

	public void OnDone()
	{
	}

	private void ResetThenHide()
	{
	}

	private void UpdateDescriptionLabel(int numberOfCards)
	{
	}

	private void UpdateDescriptionLabelSTF(int numberOfCards)
	{
	}

	private void SetupCards(List<Card> cards)
	{
	}

	private void SetupAccessories(int cardCount)
	{
	}

	private void OnCountdownEnded()
	{
	}
}
