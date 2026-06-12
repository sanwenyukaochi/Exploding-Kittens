using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameFailedToStartDetector : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitThenAnnounceGameFailedToStart_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameFailedToStartDetector _003C_003E4__this;

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
		public _003CWaitThenAnnounceGameFailedToStart_003Ed__5(int _003C_003E1__state)
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

	public GameStartMessages GameStartMessages;

	public float Timeout;

	public GameFailedToStartDetectorEvent OnGameFailedToStart;

	public void Initialize()
	{
	}

	private void OnDestroy()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitThenAnnounceGameFailedToStart_003Ed__5))]
	private IEnumerator WaitThenAnnounceGameFailedToStart()
	{
		return null;
	}

	private void OnGameStarted()
	{
	}
}
