using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CFX_Demo : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CRandomSpawnsCoroutine_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CFX_Demo _003C_003E4__this;

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
		public _003CRandomSpawnsCoroutine_003Ed__15(int _003C_003E1__state)
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

	public bool orderedSpawns;

	public float step;

	public float range;

	private float order;

	public Material groundMat;

	public Material waterMat;

	public GameObject[] ParticleExamples;

	private Dictionary<string, float> ParticlesYOffsetD;

	private int exampleIndex;

	private string randomSpawnsDelay;

	private bool randomSpawns;

	private bool slowMo;

	private void OnMouseDown()
	{
	}

	private GameObject spawnParticle()
	{
		return null;
	}

	private void OnGUI()
	{
	}

	[IteratorStateMachine(typeof(_003CRandomSpawnsCoroutine_003Ed__15))]
	private IEnumerator RandomSpawnsCoroutine()
	{
		return null;
	}

	private void Update()
	{
	}

	private void prevParticle()
	{
	}

	private void nextParticle()
	{
	}
}
