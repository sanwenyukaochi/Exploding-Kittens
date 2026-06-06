using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TurnDirectionIndicator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPredelay_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TurnDirectionIndicator _003C_003E4__this;

		public IEnumerator nextRoutine;

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
		public _003CPredelay_003Ed__13(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CWaitThenNag_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TurnDirectionIndicator _003C_003E4__this;

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
		public _003CWaitThenNag_003Ed__15(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CWaitThenPlay_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TurnDirectionIndicator _003C_003E4__this;

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
		public _003CWaitThenPlay_003Ed__14(int _003C_003E1__state)
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

	public TurnQueue TurnQueue;

	public DotsAnimator OddDotsAnimator;

	public DotsAnimator EvenDotsAnimator;

	public float PreDelay;

	public float NagDelay;

	public float FlashInterval;

	private DotsAnimator DotsAnimator => null;

	public void Initialize()
	{
	}

	private void Enable()
	{
	}

	private void Reset()
	{
	}

	private void OnStartTurn(Player _, int __)
	{
	}

	private void OnDirectionChange(TurnQueueDirection _)
	{
	}

	private void StartNag()
	{
	}

	private void StartPlay()
	{
	}

	[IteratorStateMachine(typeof(_003CPredelay_003Ed__13))]
	private IEnumerator Predelay(IEnumerator nextRoutine)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitThenPlay_003Ed__14))]
	private IEnumerator WaitThenPlay()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitThenNag_003Ed__15))]
	private IEnumerator WaitThenNag()
	{
		return null;
	}
}
