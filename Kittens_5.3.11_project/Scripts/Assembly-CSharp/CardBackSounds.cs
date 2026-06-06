using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CardBackSounds : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitForStartThenLoop_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CardBackSounds _003C_003E4__this;

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
		public _003CWaitForStartThenLoop_003Ed__6(int _003C_003E1__state)
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

	public AudioSource DrumRollStart;

	public AudioSource DrumRollLoop;

	public AudioSource DrumRollEnd;

	public void Play()
	{
	}

	public void Cancel()
	{
	}

	public void End()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForStartThenLoop_003Ed__6))]
	private IEnumerator WaitForStartThenLoop()
	{
		return null;
	}
}
