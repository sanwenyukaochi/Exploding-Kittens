using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HandCardStaggerer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitAndExecute_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public Action callback;

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
		public _003CWaitAndExecute_003Ed__10(int _003C_003E1__state)
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

	public int HandCardStartingDepth;

	public float GridAnimationDelay;

	public PlayerHand PlayerHand;

	public UIGrid Grid;

	private List<HandCard> HorizontallySortedHandCards => null;

	private List<HandCard> HandCards => null;

	public void Start()
	{
	}

	private void OnGridRepositionStart()
	{
	}

	private void OnGridRepositionEnd()
	{
	}

	private void StaggerCards()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitAndExecute_003Ed__10))]
	private IEnumerator WaitAndExecute(float delay, Action callback)
	{
		return null;
	}
}
