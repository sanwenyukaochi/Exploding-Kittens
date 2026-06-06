using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PotLuckController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAIGiveGarbageCollectionCardDelay_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PotLuckController _003C_003E4__this;

		public Player player;

		public Player targetPlayer;

		public Card card;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAIGiveGarbageCollectionCardDelay_003Ed__16(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public GameMessages GameMessages;

	public ActivityMessages ActivityMessages;

	public GameDeck GameDeck;

	public TurnQueueAuthority TurnQueueAuthority;

	public TurnQueue TurnQueue;

	private List<bool> m_PlayersDone;

	private List<Card> m_PlayersCards;

	private List<Player> m_Players;

	private List<Player> m_PlayersMatched;

	private Player requestingPlayer;

	private void OnTimeOut()
	{
	}

	public void OnPlayed(Player player, Card _)
	{
	}

	private void OnTargetedPlayerDisconnected(Player disconnectedPlayer)
	{
	}

	private int GetActivePlayerCount()
	{
		return 0;
	}

	private bool CheckCollectionComplete(Player player, Player targetedPlayer, Card card)
	{
		return false;
	}

	public void GarbageCollectionChosen(Player player, Player targetedPlayer, Card card)
	{
	}

	[IteratorStateMachine(typeof(_003CAIGiveGarbageCollectionCardDelay_003Ed__16))]
	private IEnumerator AIGiveGarbageCollectionCardDelay(Player player, Player targetPlayer, Card card)
	{
		return null;
	}
}
