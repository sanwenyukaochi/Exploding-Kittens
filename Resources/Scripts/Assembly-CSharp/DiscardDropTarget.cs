using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DiscardDropTarget : CardDropTarget
{
	[CompilerGenerated]
	private sealed class _003CPlayCardDelayed_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HandCard handCard;

		public Action onFailure;

		public float delay;

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
		public _003CPlayCardDelayed_003Ed__2(int _003C_003E1__state)
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

	public Transform DiscardedCardsContainer;

	public override void DropCard(HandCard handCard, Action onFailure)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayCardDelayed_003Ed__2))]
	private IEnumerator PlayCardDelayed(HandCard handCard, Action onFailure, float delay)
	{
		return null;
	}
}
