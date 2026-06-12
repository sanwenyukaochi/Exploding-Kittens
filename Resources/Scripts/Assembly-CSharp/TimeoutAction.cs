using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TimeoutAction : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitThenAct_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TimeoutAction _003C_003E4__this;

		public Action action;

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
		public _003CWaitThenAct_003Ed__13(int _003C_003E1__state)
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

	public float Timeout;

	public string Name;

	private Action action;

	public float TimeRemaining { get; private set; }

	public void StartTimer(Action action)
	{
	}

	public void StartTimer(Action action, float timeout)
	{
	}

	public void Stop()
	{
	}

	public void Reset()
	{
	}

	public void AdjustTimer(float adjustment)
	{
	}

	private void SetTimeout()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitThenAct_003Ed__13))]
	private IEnumerator WaitThenAct(Action action)
	{
		return null;
	}
}
