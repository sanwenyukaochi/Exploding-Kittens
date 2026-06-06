using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OnClickTrigger : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitThenRespondToClicksAgain_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnClickTrigger _003C_003E4__this;

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
		public _003CWaitThenRespondToClicksAgain_003Ed__5(int _003C_003E1__state)
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

	public float MinTimeBetweenPresses;

	public ActionBase Action;

	private bool isDisabled;

	private bool ShouldWaitBetweenPresses => false;

	private void OnClick()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitThenRespondToClicksAgain_003Ed__5))]
	private IEnumerator WaitThenRespondToClicksAgain()
	{
		return null;
	}
}
