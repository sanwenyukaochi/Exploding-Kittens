using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ShakeTransformS : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CShake_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ShakeTransformS _003C_003E4__this;

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
		public _003CShake_003Ed__9(int _003C_003E1__state)
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

	[Range(0f, 2f)]
	[Header("Settings")]
	public float _time;

	[Range(0f, 2f)]
	public float _distance;

	[Range(0f, 0.1f)]
	public float _delayBetweenShakes;

	private void Awake()
	{
	}

	private void OnValidate()
	{
	}

	public void Begin()
	{
	}

	[IteratorStateMachine(typeof(_003CShake_003Ed__9))]
	private IEnumerator Shake()
	{
		return null;
	}
}
