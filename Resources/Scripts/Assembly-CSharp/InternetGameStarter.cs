using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InternetGameStarter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitThenStartGame_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InternetGameStarter _003C_003E4__this;

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
		public _003CWaitThenStartGame_003Ed__8(int _003C_003E1__state)
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

	public ActionBase StartGameAction;

	public Gate StartGate;

	private int LobbyFrozenDelay;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnStartGateChanged()
	{
	}

	public void StartGame()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitThenStartGame_003Ed__8))]
	private IEnumerator WaitThenStartGame()
	{
		return null;
	}
}
