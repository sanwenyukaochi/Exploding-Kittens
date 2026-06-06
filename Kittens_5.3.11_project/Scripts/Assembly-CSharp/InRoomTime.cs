using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using UnityEngine;

public class InRoomTime : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSetRoomStartTimestamp_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InRoomTime _003C_003E4__this;

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
		public _003CSetRoomStartTimestamp_003Ed__8(int _003C_003E1__state)
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

	private int roomStartTimestamp;

	private const string StartTimeKey = "#rt";

	public double RoomTime => 0.0;

	public int RoomTimestamp => 0;

	public bool IsRoomTimeSet => false;

	[IteratorStateMachine(typeof(_003CSetRoomStartTimestamp_003Ed__8))]
	internal IEnumerator SetRoomStartTimestamp()
	{
		return null;
	}

	public void OnJoinedRoom()
	{
	}

	public void OnMasterClientSwitched(PhotonPlayer newMasterClient)
	{
	}

	public void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
	{
	}
}
