using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AlterTheFutureController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSeeTheFutureDelay_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public AlterTheFutureController _003C_003E4__this;

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
		public _003CSeeTheFutureDelay_003Ed__8(int _003C_003E1__state)
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

	private const int MinAlterableCards = 2;

	public Deck Deck => null;

	public void OnPlayAlterTheFuture(Player player, Card card)
	{
	}

	public int NumAlterableCards(CardCategory cardCategory)
	{
		return 0;
	}

	[IteratorStateMachine(typeof(_003CSeeTheFutureDelay_003Ed__8))]
	private IEnumerator SeeTheFutureDelay(float delay)
	{
		return null;
	}
}
