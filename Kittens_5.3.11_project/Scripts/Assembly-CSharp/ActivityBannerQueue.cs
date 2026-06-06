using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ActivityBannerQueue : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitThenUnlock_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ActivityBannerQueue _003C_003E4__this;

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
		public _003CWaitThenUnlock_003Ed__5(int _003C_003E1__state)
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

	public ActivityBanner ActivityBanner;

	public float BannerMinShowTime;

	private bool bannerLocked;

	private Queue<BannerMetadata> queue;

	private bool ShouldShowNextActivity => false;

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitThenUnlock_003Ed__5))]
	public IEnumerator WaitThenUnlock()
	{
		return null;
	}

	public void Enqueue(BannerMetadata activity)
	{
	}
}
