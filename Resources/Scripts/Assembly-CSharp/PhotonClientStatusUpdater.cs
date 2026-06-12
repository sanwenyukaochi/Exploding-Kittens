using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon;
using UnityEngine;

public class PhotonClientStatusUpdater : PunBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAloneTimer_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public PhotonClientStatusUpdater _003C_003E4__this;

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
		public _003CAloneTimer_003Ed__18(int _003C_003E1__state)
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

	public StatusBadgeProvider StatusBadgeProvider;

	public Gate GameStartGate;

	public Gate MinPlayersReachedGate;

	public Action<string> OnStatusUpdate;

	[Header("State Messages")]
	public string OnConnectingMessage;

	public string OnJoinedLobbyMessage;

	public string OnGameNotViableMessage;

	public string OnGameViableMessage;

	public string OnGameReadyToStartMessage;

	[Header("Alt messages")]
	public float UpdateWaitingMessageInterval;

	public List<string> WaitingForMorePlayersMessages;

	public void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnStartGateChanged()
	{
	}

	public void OnConnecting()
	{
	}

	public override void OnJoinedLobby()
	{
	}

	public override void OnLeftRoom()
	{
	}

	private void StartAloneTimer()
	{
	}

	[IteratorStateMachine(typeof(_003CAloneTimer_003Ed__18))]
	private IEnumerator AloneTimer(float delay)
	{
		return null;
	}

	private void UpdateStatus(string status)
	{
	}
}
