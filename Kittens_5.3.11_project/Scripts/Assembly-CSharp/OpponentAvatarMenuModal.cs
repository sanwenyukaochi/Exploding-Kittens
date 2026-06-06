using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OpponentAvatarMenuModal : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitThenDismiss_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OpponentAvatarMenuModal _003C_003E4__this;

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
		public _003CWaitThenDismiss_003Ed__6(int _003C_003E1__state)
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

	public float AutomaticDismissDelay;

	public PlayerProvider PlayerProvider;

	public WindowTransitioner WindowTransitioner;

	public void Toggle()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitThenDismiss_003Ed__6))]
	private IEnumerator WaitThenDismiss()
	{
		return null;
	}

	private void ZeroOutRotation()
	{
	}
}
