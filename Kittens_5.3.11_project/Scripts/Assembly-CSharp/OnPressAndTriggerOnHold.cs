using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OnPressAndTriggerOnHold : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CTriggerOnHold_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnPressAndTriggerOnHold _003C_003E4__this;

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
		public _003CTriggerOnHold_003Ed__6(int _003C_003E1__state)
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

	public float PressAndHoldDuration;

	public ActionBase Action;

	private DateTime clickedAtTime;

	private bool isDown;

	private TimeSpan timeDiff;

	public void OnPress(bool isDown)
	{
	}

	[IteratorStateMachine(typeof(_003CTriggerOnHold_003Ed__6))]
	private IEnumerator TriggerOnHold()
	{
		return null;
	}
}
