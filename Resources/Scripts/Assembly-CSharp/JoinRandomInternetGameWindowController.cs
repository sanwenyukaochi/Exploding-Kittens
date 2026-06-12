using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class JoinRandomInternetGameWindowController : WindowController
{
	[CompilerGenerated]
	private sealed class _003CRetryIfLobbyIsEmptyTimeout_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public JoinRandomInternetGameWindowController _003C_003E4__this;

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
		public _003CRetryIfLobbyIsEmptyTimeout_003Ed__23(int _003C_003E1__state)
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
	private sealed class _003CRetryJoiningRandomRoom_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public JoinRandomInternetGameWindowController _003C_003E4__this;

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
		public _003CRetryJoiningRandomRoom_003Ed__28(int _003C_003E1__state)
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

	public static bool retry;

	public PhotonConnectionAdapter PhotonConnectionAdapter;

	public PhotonClientStatusUpdater PhotonClientStatusUpdater;

	public InternetLobbyAvatarGridController LobbyAvatarGridController;

	public PunEventBridge PunEventBridge;

	public LobbyFrozenUiDisabler LobbyFrozenUiDisabler;

	public GameObject StartGameButton;

	public PrivateInternetGameWindowController PrivateInternetGameWindowController;

	public LobbyFrameFactory LobbyFrameFactory;

	public PlayerRepository PlayerRepository;

	public PhotonRandomRoomJoinHandler PhotonRandomRoomJoinHandler;

	public DeckMetadataRepository Debug_DeckMetadataRepository;

	public PlayerAvatar Debug_PlayerAvatar_Default;

	public PlayerAvatar Debug_PlayerAvatar_AutoSwitchWhileConnecting;

	public float Debug_PlayerAvatar_AutoSwitchInvokeDelay;

	public string Debug_PhotonClientStatusToSwitchAvatar;

	private bool hasAttemptedToConnect;

	private bool hasResentAvatarID;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPunJoinedRoom()
	{
	}

	private void OnPhotonClientStatusUpdate(string status)
	{
	}

	[IteratorStateMachine(typeof(_003CRetryIfLobbyIsEmptyTimeout_003Ed__23))]
	private IEnumerator RetryIfLobbyIsEmptyTimeout()
	{
		return null;
	}

	public override void OnLoad()
	{
	}

	private void DebugChangeAvatar()
	{
	}

	public override void OnUnload()
	{
	}

	public void LeaveGame()
	{
	}

	[IteratorStateMachine(typeof(_003CRetryJoiningRandomRoom_003Ed__28))]
	private IEnumerator RetryJoiningRandomRoom()
	{
		return null;
	}
}
