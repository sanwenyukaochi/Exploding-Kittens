using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class YourTurnModal : MonoBehaviour, IModal
{
	[CompilerGenerated]
	private sealed class _003CWaitForAnimationThenDisable_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public YourTurnModal _003C_003E4__this;

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
		public _003CWaitForAnimationThenDisable_003Ed__10(int _003C_003E1__state)
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

	public SkeletonAnimation SkeletonAnimation;

	public float AnimationTime;

	public ActionBase AudioSourceCycler;

	public GameMessages GameMessages;

	private bool FirstTurn;

	[SpineAnimation(null, "SkeletonAnimation")]
	public string AnimationName;

	public event ModalDelegate OnDone
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Show()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForAnimationThenDisable_003Ed__10))]
	private IEnumerator WaitForAnimationThenDisable()
	{
		return null;
	}
}
