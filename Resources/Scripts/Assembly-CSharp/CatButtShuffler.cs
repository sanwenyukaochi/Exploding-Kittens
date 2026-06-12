using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CatButtShuffler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitForCatButtThenRepositionCards_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CatButtShuffler _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003CWaitForCatButtThenRepositionCards_003Ed__8(int _003C_003E1__state)
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

	public PlayerProvider PlayerProvider;

	public PlayerHand PlayerHand;

	public UIGrid Grid;

	public float MoveAnimationDelay;

	public float ReshuffleAfterCatButtDelay;

	public int NumShuffles;

	private Player Player => null;

	private List<HandCard> HandCards => null;

	public void Start()
	{
	}

	public void OnDisguiseHand(Player _)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForCatButtThenRepositionCards_003Ed__8))]
	private IEnumerator WaitForCatButtThenRepositionCards()
	{
		return null;
	}

	private void ShuffleCards()
	{
	}
}
