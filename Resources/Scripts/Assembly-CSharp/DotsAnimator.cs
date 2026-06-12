using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DotsAnimator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitThenPulseNext_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DotsAnimator _003C_003E4__this;

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
		public _003CWaitThenPulseNext_003Ed__8(int _003C_003E1__state)
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

	public Dot[] Dots;

	public bool IsRotatingClockwise;

	public int CurrentDotIndex;

	public float PulseDelay;

	private int increment;

	private int StartOfCycle => 0;

	public void Play()
	{
	}

	public void Reset()
	{
	}

	public void Reverse()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitThenPulseNext_003Ed__8))]
	private IEnumerator WaitThenPulseNext()
	{
		return null;
	}

	private void AdvanceDot()
	{
	}

	private static int Modulo(int a, int b)
	{
		return 0;
	}
}
