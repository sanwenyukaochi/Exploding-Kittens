using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class JoinWindowController : WindowController
{
	[CompilerGenerated]
	private sealed class _003CWaitThenExit_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public JoinWindowController _003C_003E4__this;

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
		public _003CWaitThenExit_003Ed__29(int _003C_003E1__state)
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

	public NavigationController NavigationController;

	public MessageBoxModal MessageBoxModal;

	public StatusBadgeProvider StatusBadgeProvider;

	public LobbyFrameProvider LobbyFrameProvider;

	public GameClient GameClient;

	public PlayerRepository PlayerRepository;

	public WindowTransitioner WindowTransitioner;

	public MCPeerConnectionsMonitor MCPeerConnectionsMonitor;

	public MultipeerHostConnectionMonitor MultipeerHostConnectionMonitor;

	public LobbyAvatarGridController LobbyAvatarGridController;

	public HostPinger HostPinger;

	public float JoinAttemptDelay;

	public float PlayerReceivedAttemptDelay;

	public string JoiningStatusString;

	public string JoinedStatusString;

	public string HostConnectedStatusString;

	public string GameStartingStatusString;

	private MultipeerGameInfo gameInfo;

	public void SetupGame(MultipeerGameInfo gameInfo)
	{
	}

	public override void OnLoad()
	{
	}

	public override void OnUnload()
	{
	}

	public void FreezeLobby()
	{
	}

	private void JoinGame()
	{
	}

	public void LeaveGame()
	{
	}

	private void OnPeerConnected(MultipeerPeerInfo peerInfo)
	{
	}

	private void OnHostConnected()
	{
	}

	private void OnHostNotResponding()
	{
	}

	private void OnPlayerAdded(Player __)
	{
	}

	private bool PeerIsHost(MultipeerPeerInfo peerInfo)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CWaitThenExit_003Ed__29))]
	private IEnumerator WaitThenExit(float time)
	{
		return null;
	}

	private void ProceedUserToExitWindow()
	{
	}
}
