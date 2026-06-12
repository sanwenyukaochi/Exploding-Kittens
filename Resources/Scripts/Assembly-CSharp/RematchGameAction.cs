using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class RematchGameAction : ActionBase
{
	[CompilerGenerated]
	private sealed class _003CAutoDeclinePromptAfterTimeout_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RematchGameAction _003C_003E4__this;

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
		public _003CAutoDeclinePromptAfterTimeout_003Ed__27(int _003C_003E1__state)
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
	private sealed class _003CAutoDeclineRematchTimeout_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RematchGameAction _003C_003E4__this;

		public Player player;

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
		public _003CAutoDeclineRematchTimeout_003Ed__28(int _003C_003E1__state)
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

	public static RematchGameAction m;

	public static bool rematchingGame;

	public static bool lobbyPublic;

	public static string rematchRoomCode;

	public static List<Player> rematchingPlayers;

	public static string rematchHostPlayerId;

	public GameMessages GameMessages;

	public TurnQueue TurnQueue;

	public PlayerInterfaceRepository PlayerInterfaceRepository;

	public PlayerRepository PlayerRepository;

	public PhotonConnectionAdapter PhotonConnectionAdapter;

	public ActionBase ChangeSceneAction;

	public GameStats GameStats;

	public TwoButtonModal TwoButtonModal;

	public ExitGameAction ExitGameAction;

	public PhotonPlayerDisconnectionMonitor PhotonPlayerDisconnectionMonitor;

	public float autoDeclineTimeout;

	private float autoDeclineTimer;

	private bool RespondedToPrompt;

	private PhotonRoomCodeGenerator PhotonRoomCodeGenerator;

	private PlayerHud playerHud;

	private string promptTitleText;

	public void Initialize()
	{
	}

	private void Awake()
	{
	}

	public override void Act()
	{
	}

	public void PromptPlayersForRematch(Player playerThatInitiatedRematch, string newRoomCode)
	{
	}

	public void GoToLobbyMenu()
	{
	}

	[IteratorStateMachine(typeof(_003CAutoDeclinePromptAfterTimeout_003Ed__27))]
	private IEnumerator AutoDeclinePromptAfterTimeout()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CAutoDeclineRematchTimeout_003Ed__28))]
	private IEnumerator AutoDeclineRematchTimeout(Player player)
	{
		return null;
	}

	private void AnswerPrompt(bool acceptRematch)
	{
	}

	public void PlayerRematchResponse(Player player, bool acceptsRematch)
	{
	}

	private void OnPlayerDisconnect(Player player)
	{
	}

	private void UpdatePromptTitleText()
	{
	}

	private void Update()
	{
	}
}
