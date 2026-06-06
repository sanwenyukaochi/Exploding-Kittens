using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DrawCardController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCoDrawCard_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Player drawPlayer;

		public Card card;

		public DrawCardController _003C_003E4__this;

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
		public _003CCoDrawCard_003Ed__11(int _003C_003E1__state)
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

	public PlayerInterfaceRepository PlayerInterfaceRepository;

	public Deck Deck => null;

	public void DrawCard(Player player, Card card)
	{
	}

	private OpponentPlayerAvatar GetTargetPlayer(Player target, PlayerHud localHud)
	{
		return null;
	}

	private void DrawCardNow(Player player, Player drawPlayer, Card card)
	{
	}

	public void OnPlayDrawFromBottomCard(Player player, Card card)
	{
	}

	public void ReceiveCard(Card card, Player player)
	{
	}

	[IteratorStateMachine(typeof(_003CCoDrawCard_003Ed__11))]
	private IEnumerator CoDrawCard(Player player, Player drawPlayer, Card card)
	{
		return null;
	}
}
