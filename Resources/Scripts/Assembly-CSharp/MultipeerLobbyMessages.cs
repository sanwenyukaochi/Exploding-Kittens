using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MultipeerLobbyMessages : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CReRequestPlayerInfoForMultipeerId_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MultipeerLobbyMessages _003C_003E4__this;

		public string hostPeerId;

		public string requestingPeerId;

		public string playerPeerId;

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
		public _003CReRequestPlayerInfoForMultipeerId_003Ed__26(int _003C_003E1__state)
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

	public ActionBase StartGameAction;

	public MCPeerConnectionReadinessMonitor PeerConnectionReadinessMonitor;

	public PlayerRepository PlayerRepository;

	public PlayerAvatarRepository PlayerAvatarRepository;

	public LobbyStateHashGenerator LobbyStateHashGenerator;

	public ActionDebouncer SetLobbyStateDebouncer;

	public HandshakeMessageEvent OnPong;

	private List<string> requestedPeerIds;

	private float RE_REQUEST_WAIT_TIME;

	private NetworkMessageRouter router => null;

	private MultipeerMessageClient MessageClient => null;

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	public void SendPing()
	{
	}

	public void SendPong(NetworkMessage message)
	{
	}

	public void NotifyPong(NetworkMessage _)
	{
	}

	public void SendLocalPlayerInfo(PlayerProfileSettings playerProfileSettings)
	{
	}

	public void CreatePlayerInfo(NetworkMessage message)
	{
	}

	public void SendUpdatePlayerInfo(Player player)
	{
	}

	public void UpdatePlayerInfo(NetworkMessage message)
	{
	}

	public void SendRequestPlayerInfoForMultipeerId(string hostPeerId, string requestingPeerId, string peerId)
	{
	}

	public void RequestPlayerInfoForMultipeerId(NetworkMessage message)
	{
	}

	public void SendPlayerInfoForMultipeerId(string requestingPeerId, string playerPeerId, string playerId, string playerUsername, string playerAvatarId, string playerDeviceId)
	{
	}

	public void PlayerInfoForMultipeerId(NetworkMessage message)
	{
	}

	public void SendPlayerInfoNotFound(string hostId, string requestingPeerId, string playerPeerId)
	{
	}

	private void PlayerInfoNotFound(NetworkMessage message)
	{
	}

	[IteratorStateMachine(typeof(_003CReRequestPlayerInfoForMultipeerId_003Ed__26))]
	private IEnumerator ReRequestPlayerInfoForMultipeerId(string hostPeerId, string requestingPeerId, string playerPeerId)
	{
		return null;
	}

	private void SendSetLobbyStateHash(string hash)
	{
	}

	private void SetLobbyStateHash(NetworkMessage message)
	{
	}

	private void SendToPeer(string peerId, string message, params string[] parameters)
	{
	}

	public void RemovePlayer(NetworkMessage message)
	{
	}

	public void SendRemovePlayer(Player player)
	{
	}

	private void GuardIsLobbyHost(Action OnSuccess)
	{
	}

	private void GuardIsLobbyClient(Action OnSuccess)
	{
	}
}
