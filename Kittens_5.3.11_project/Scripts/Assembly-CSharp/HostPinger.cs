using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HostPinger : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitThenPing_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitTime;

		public HostPinger _003C_003E4__this;

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
		public _003CWaitThenPing_003Ed__8(int _003C_003E1__state)
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

	public MultipeerLobbyMessages MultipeerLobbyMessages;

	public HostEvent OnHostNotResponding;

	public TimeoutAction PingTimeoutAction;

	public float PingInterval;

	private bool hostTimedOut;

	public void StartPinging()
	{
	}

	public void StopPinging()
	{
	}

	private void SchedulePing()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitThenPing_003Ed__8))]
	private IEnumerator WaitThenPing(float waitTime)
	{
		return null;
	}

	private void OnPong()
	{
	}

	private void Vomit()
	{
	}
}
