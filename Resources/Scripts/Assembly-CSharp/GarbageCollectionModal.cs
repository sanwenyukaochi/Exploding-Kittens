using System;
using UnityEngine;

public class GarbageCollectionModal : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public PlayMakerFSM StealFsm;

	public StealDropTarget StealDropTarget;

	public Countdown Countdown;

	public PlayerHand PlayerHand;

	public int HandCardDepthAfterAttachToStealDropTarget;

	private Card card;

	private Action<Card> callback;

	private Player attacker;

	public CatPawCountdownFactory CatPawCountdownFactory;

	public DrawPile DrawPile;

	public HandCard HandCardChosen;

	private Player Player => null;

	private void Start()
	{
	}

	private void OnCountdownEnded()
	{
	}

	private void AttachHandCardToCatPaw(HandCard handCard, Action onComplete)
	{
	}

	public void DetachHandCardMoveToDrawPile()
	{
	}

	private void OnRequestCardFromPlayer(Player player, Player attacker, Action<Card> callback)
	{
	}

	private void OnDisconnect(Player attacker)
	{
	}

	private void GiveUpCard(Card card)
	{
	}

	private void SendCard()
	{
	}
}
