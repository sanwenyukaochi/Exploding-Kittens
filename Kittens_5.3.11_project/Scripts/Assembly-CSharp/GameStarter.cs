using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitForOpeningSoundThenSendStartTurn_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameStarter _003C_003E4__this;

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
		public _003CWaitForOpeningSoundThenSendStartTurn_003Ed__17(int _003C_003E1__state)
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

	public static GameStarter Instance;

	public StartTurnController StartTurnController;

	public CardRepositoryInitializer CardRepositoryInitializer;

	public PlayerInterfaceRepository PlayerInterfaceRepository;

	public PlayerHudFactory PlayerHudFactory;

	public ModalAnnouncer ModalAnnouncer;

	public PlayerHealthMonitor PlayerHealthMonitor;

	public MultipeerHostConnectionMonitor MultipeerHostConnectionMonitor;

	public ChooseOpponentMonitor ChooseOpponentMonitor;

	public VisibleKittenDetector VisibleKittenDetector;

	public DeckStats DeckStats;

	public GameSetup GameSetup;

	public GameMessages GameMessages;

	public GameStartMessages GameStartMessages;

	public float GameStartSoundDelay;

	public RematchGameAction RematchGameAction;

	public void StartGame()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForOpeningSoundThenSendStartTurn_003Ed__17))]
	private IEnumerator WaitForOpeningSoundThenSendStartTurn()
	{
		return null;
	}

	private void CreatePlayerHuds()
	{
	}
}
