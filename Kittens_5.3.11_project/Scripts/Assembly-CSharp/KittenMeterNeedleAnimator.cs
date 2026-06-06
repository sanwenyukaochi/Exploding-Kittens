using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KittenMeterNeedleAnimator : KittenMeterAnimator
{
	[CompilerGenerated]
	private sealed class _003CWaitForStopNeedleThenContinueAnimation_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KittenMeterNeedleAnimator _003C_003E4__this;

		public float chanceToExplode;

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
		public _003CWaitForStopNeedleThenContinueAnimation_003Ed__9(int _003C_003E1__state)
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

	public ActionBase NeedleFreakoutAction;

	public RotationAction NeedleRotationAction;

	public ActionBase StopNeedleMovementAction;

	public Transform Needle;

	public VisibleKittenDetector VisibleKittenDetector;

	private const float startingRotation = 134f;

	private const float totalDegreesInArc = 289f;

	private const float direction = -1f;

	public override void Animate(float chanceToExplode)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForStopNeedleThenContinueAnimation_003Ed__9))]
	private IEnumerator WaitForStopNeedleThenContinueAnimation(float chanceToExplode)
	{
		return null;
	}

	private void RotateNeedle(float chanceToExplode)
	{
	}

	private Vector3 CalculateNeedleRotation(float chanceToExplode)
	{
		return default(Vector3);
	}
}
