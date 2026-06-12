using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KittenMeterBeanAnimator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CDelayThenCall_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KittenMeterBeanAnimator _003C_003E4__this;

		public Action onComplete;

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
		public _003CDelayThenCall_003Ed__3(int _003C_003E1__state)
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

	public KittenMeterBeanFactory KittenMeterBeanFactory;

	public float Delay;

	public void Animate(Action onComplete)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayThenCall_003Ed__3))]
	private IEnumerator DelayThenCall(Action onComplete)
	{
		return null;
	}
}
