using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

internal class PhotonHandler : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CPingAvailableRegionsCoroutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool connectToBest;

		private PhotonPingManager _003CpingManager_003E5__2;

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
		public _003CPingAvailableRegionsCoroutine_003Ed__25(int _003C_003E1__state)
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

	public static PhotonHandler SP;

	public int updateInterval;

	public int updateIntervalOnSerialize;

	private int nextSendTickCount;

	private int nextSendTickCountOnSerialize;

	private static bool sendThreadShouldRun;

	private static Stopwatch timerToStopConnectionInBackground;

	protected internal static bool AppQuits;

	protected internal static Type PingImplementation;

	private const string PlayerPrefsKey = "PUNCloudBestRegion";

	internal static CloudRegionCode BestRegionCodeInPreferences
	{
		get
		{
			return default(CloudRegionCode);
		}
		set
		{
		}
	}

	protected void Awake()
	{
	}

	protected void Start()
	{
	}

	protected void OnApplicationQuit()
	{
	}

	protected void OnApplicationPause(bool pause)
	{
	}

	protected void OnDestroy()
	{
	}

	protected void Update()
	{
	}

	protected void OnJoinedRoom()
	{
	}

	protected void OnCreatedRoom()
	{
	}

	public static void StartFallbackSendAckThread()
	{
	}

	public static void StopFallbackSendAckThread()
	{
	}

	public static bool FallbackSendAckThread()
	{
		return false;
	}

	protected internal static void PingAvailableRegionsAndConnectToBest()
	{
	}

	[IteratorStateMachine(typeof(_003CPingAvailableRegionsCoroutine_003Ed__25))]
	internal IEnumerator PingAvailableRegionsCoroutine(bool connectToBest)
	{
		return null;
	}
}
