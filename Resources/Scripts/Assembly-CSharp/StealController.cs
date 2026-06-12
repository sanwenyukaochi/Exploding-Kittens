using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StealController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAIGiveStealCardDelay_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StealController _003C_003E4__this;

		public Player player;

		public Player targetedPlayer;

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
		public _003CAIGiveStealCardDelay_003Ed__8(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CAIPlayEmoteDelay_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StealController _003C_003E4__this;

		public Player player;

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
		public _003CAIPlayEmoteDelay_003Ed__7(int _003C_003E1__state)
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

	public PlayerInterfaceRepository PlayerInterfaceRepository;

	public GameDeck GameDeck;

	private Player requestingPlayer;

	private Card cardToStealIfTargetDisconnects;

	public void OpponentChosen(Player player, Player targetedPlayer, Card _)
	{
	}

	[IteratorStateMachine(typeof(_003CAIPlayEmoteDelay_003Ed__7))]
	private IEnumerator AIPlayEmoteDelay(Player player)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAIGiveStealCardDelay_003Ed__8))]
	private IEnumerator AIGiveStealCardDelay(Player player, Player targetedPlayer, Card card)
	{
		return null;
	}

	public void GiveSteal(Player player, Player targetedPlayer, Card card)
	{
	}

	private void EditorOnlyPlayerChange(Player player)
	{
	}

	private void OnTargetedPlayerDisconnected(Player disconnectedPlayer)
	{
	}
}
