using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerHealthMonitor : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCrownWinner_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Player winner;

		public PlayerHealthMonitor _003C_003E4__this;

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
		public _003CCrownWinner_003Ed__12(int _003C_003E1__state)
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
	private sealed class _003CEndTurnIfCurrentPlayerIsDead_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerHealthMonitor _003C_003E4__this;

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
		public _003CEndTurnIfCurrentPlayerIsDead_003Ed__16(int _003C_003E1__state)
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

	public GameMessages GameMessages;

	public ActivityMessages ActivityMessages;

	public PlayerRepository PlayerRepository;

	public TurnQueue TurnQueue;

	public TurnQueueAuthority TurnQueueAuthority;

	private bool CurrentPlayerIsDead => false;

	public void Initialize()
	{
	}

	public void DeadPlayerSkipTurn(Player player)
	{
	}

	public void OnDestroy()
	{
	}

	public void OnDeath(Player player)
	{
	}

	public void OnDisconnect(Player player)
	{
	}

	private void RemovePlayerFromGame(Player player)
	{
	}

	private void MoveGameForwardIfNecessary()
	{
	}

	[IteratorStateMachine(typeof(_003CCrownWinner_003Ed__12))]
	private IEnumerator CrownWinner(Player winner)
	{
		return null;
	}

	private void RemoveHandlers(Player player)
	{
	}

	[IteratorStateMachine(typeof(_003CEndTurnIfCurrentPlayerIsDead_003Ed__16))]
	private IEnumerator EndTurnIfCurrentPlayerIsDead()
	{
		return null;
	}
}
