using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StartTurnController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitAndStartTurn_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public StartTurnController _003C_003E4__this;

		public Player player;

		public int numTurnsRemaining;

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
		public _003CWaitAndStartTurn_003Ed__9(int _003C_003E1__state)
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

	public PlayerRepository PlayerRepository;

	public UIButton EndTurnButton;

	public PlayerInterfaceRepository PlayerInterfaceRepository;

	public ActivityMessages ActivityMessages;

	public GameMessages GameMessages;

	private bool FirstAITurn;

	private const float ANIMATION_PAUSE_TIME = 0.6f;

	private int TurnCount;

	public void Initialize()
	{
	}

	public void StartTurn(Player player, int numTurnsRemaining)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitAndStartTurn_003Ed__9))]
	public IEnumerator WaitAndStartTurn(Player player, int numTurnsRemaining)
	{
		return null;
	}

	private void DoStartTurn(Player player, int numTurnsRemaining)
	{
	}
}
