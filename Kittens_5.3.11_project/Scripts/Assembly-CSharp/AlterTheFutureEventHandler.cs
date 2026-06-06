using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AlterTheFutureEventHandler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CEndSharingTheFuture_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AlterTheFutureEventHandler _003C_003E4__this;

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
		public _003CEndSharingTheFuture_003Ed__7(int _003C_003E1__state)
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

	public AlterTheFutureModal AlterTheFutureModal;

	public PlayerProvider PlayerProvider;

	public TurnQueue TurnQueue;

	public ActivityMessages ActivityMessages;

	public void Start()
	{
	}

	private void OnAlteringTheFuture(Player player, List<Card> cards)
	{
	}

	private void OnSharingTheFuture(Player player, List<Card> cards)
	{
	}

	[IteratorStateMachine(typeof(_003CEndSharingTheFuture_003Ed__7))]
	private IEnumerator EndSharingTheFuture(Player player)
	{
		return null;
	}
}
