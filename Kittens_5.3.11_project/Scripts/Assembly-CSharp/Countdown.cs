using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Countdown : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitAndTick_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Countdown _003C_003E4__this;

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
		public _003CWaitAndTick_003Ed__14(int _003C_003E1__state)
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

	public CountdownUpdateEvent OnCountdownStarted;

	public CountdownUpdateEvent OnCountdownUpdated;

	public CountdownEvent OnCountdownEnded;

	public CountdownEvent OnCountdownCancelled;

	public int Duration;

	private int secondsLeft;

	private CountdownState countdownState;

	private bool hasTimeLeft => false;

	public void StartCountdown(int timeradust = 0)
	{
	}

	public void PauseCountdown()
	{
	}

	public void ResumeCountdown()
	{
	}

	public void CancelCountdown()
	{
	}

	private void CountdownEnded()
	{
	}

	public void WhenRunning(Action callback)
	{
	}

	public void WhenPaused(Action callback)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitAndTick_003Ed__14))]
	private IEnumerator WaitAndTick()
	{
		return null;
	}

	private void NotifyCountdownStarted()
	{
	}

	private void NotifyCountdownUpdated()
	{
	}

	private void NotifyCountdownEnded()
	{
	}

	private void NotifyCountdownCancelled()
	{
	}
}
