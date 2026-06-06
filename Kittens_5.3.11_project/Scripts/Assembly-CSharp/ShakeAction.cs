using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShakeAction : ActionBase
{
	[CompilerGenerated]
	private sealed class _003CShakeCO_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShakeAction _003C_003E4__this;

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
		public _003CShakeCO_003Ed__15(int _003C_003E1__state)
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

	[Header("Info")]
	private Vector3 _startPos;

	private float _timer;

	private Vector3 _randomPos;

	[Header("Settings")]
	[Range(0f, 2f)]
	public float _time;

	[Range(0f, 2f)]
	public float _distance;

	[Range(0f, 0.1f)]
	public float _delayBetweenShakes;

	public GameObject Target;

	public Vector3 Amount;

	public iTween.LoopType LoopType;

	public float Delay;

	public float AnimationTime;

	public bool IsLocal;

	private void Start()
	{
	}

	private void OnValidate()
	{
	}

	public void Shake()
	{
	}

	[IteratorStateMachine(typeof(_003CShakeCO_003Ed__15))]
	private IEnumerator ShakeCO()
	{
		return null;
	}

	public override void Act()
	{
	}

	public void Stop()
	{
	}
}
