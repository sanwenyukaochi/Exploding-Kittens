using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoveAddAction : ActionBase
{
	[CompilerGenerated]
	private sealed class _003CDelayThenAct_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MoveAddAction _003C_003E4__this;

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
		public _003CDelayThenAct_003Ed__8(int _003C_003E1__state)
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

	public GameObject Target;

	public Vector3 Amount;

	public iTween.EaseType EaseType;

	public iTween.LoopType LoopType;

	public float Delay;

	public float AnimationTime;

	public bool IsLocal;

	private Vector3 TargetPosition => default(Vector3);

	private Vector3 Position => default(Vector3);

	public override void Act()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayThenAct_003Ed__8))]
	private IEnumerator DelayThenAct()
	{
		return null;
	}
}
