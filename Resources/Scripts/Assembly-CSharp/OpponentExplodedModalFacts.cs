using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class OpponentExplodedModalFacts : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CSequentiallyShowFacts_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OpponentExplodedModalFacts _003C_003E4__this;

		private List<FactStamp>.Enumerator _003C_003E7__wrap1;

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
		public _003CSequentiallyShowFacts_003Ed__5(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public float AnimationDelay;

	public FactStampFactory[] FactStampFactories;

	private List<FactStamp> factStamps;

	public void Show()
	{
	}

	public void Remove()
	{
	}

	[IteratorStateMachine(typeof(_003CSequentiallyShowFacts_003Ed__5))]
	private IEnumerator SequentiallyShowFacts()
	{
		return null;
	}
}
