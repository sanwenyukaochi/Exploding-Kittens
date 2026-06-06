using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class CFX_Demo_New : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCheckForDeletedParticles_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CFX_Demo_New _003C_003E4__this;

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
		public _003CCheckForDeletedParticles_003Ed__19(int _003C_003E1__state)
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

	public Text EffectLabel;

	public Text EffectIndexLabel;

	public Renderer groundRenderer;

	public Collider groundCollider;

	private GameObject[] ParticleExamples;

	private int exampleIndex;

	private bool slowMo;

	private Vector3 defaultCamPosition;

	private Quaternion defaultCamRotation;

	private List<GameObject> onScreenParticles;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnToggleGround()
	{
	}

	private void OnToggleCamera()
	{
	}

	private void OnToggleSlowMo()
	{
	}

	private void OnPreviousEffect()
	{
	}

	private void OnNextEffect()
	{
	}

	private void UpdateUI()
	{
	}

	private GameObject spawnParticle()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCheckForDeletedParticles_003Ed__19))]
	private IEnumerator CheckForDeletedParticles()
	{
		return null;
	}

	private void prevParticle()
	{
	}

	private void nextParticle()
	{
	}

	private void destroyParticles()
	{
	}
}
