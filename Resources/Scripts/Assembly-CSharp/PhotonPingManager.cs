using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Realtime;

public class PhotonPingManager
{
	[CompilerGenerated]
	private sealed class _003CPingSocket_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Region region;

		public PhotonPingManager _003C_003E4__this;

		private PhotonPing _003Cping_003E5__2;

		private float _003CrttSum_003E5__3;

		private int _003CreplyCount_003E5__4;

		private string _003CregionAddress_003E5__5;

		private int _003Ci_003E5__6;

		private bool _003Covertime_003E5__7;

		private Stopwatch _003Csw_003E5__8;

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
		public _003CPingSocket_003Ed__10(int _003C_003E1__state)
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

	public bool UseNative;

	public static int Attempts;

	public static bool IgnoreInitialAttempt;

	public static int MaxMilliseconsPerPing;

	private const string wssProtocolString = "wss://";

	private int PingsRunning;

	public Region BestRegion => null;

	public bool Done => false;

	[IteratorStateMachine(typeof(_003CPingSocket_003Ed__10))]
	public IEnumerator PingSocket(Region region)
	{
		return null;
	}

	public static string ResolveHost(string hostName)
	{
		return null;
	}
}
