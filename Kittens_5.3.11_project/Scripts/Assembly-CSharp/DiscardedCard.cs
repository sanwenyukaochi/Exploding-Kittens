using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DiscardedCard : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitForDefaultThenPlayJukeboxCardSound_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DiscardedCard _003C_003E4__this;

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
		public _003CWaitForDefaultThenPlayJukeboxCardSound_003Ed__19(int _003C_003E1__state)
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

	public SimpleCardFactory SimpleCardFactory;

	public BubbleCaptionFactory BubbleCaptionFactory;

	public GameObject BubbleCaptionContainer;

	public AudioSource DefaultSoundEffect;

	public TooltipCaptionFactory TooltipCaptionFactory;

	public UIWidget UIWidget;

	private TooltipCaption tooltipCaption;

	[Range(0f, 1.5f)]
	public float DefaultSoundPadding;

	[Header("Delegated Actions")]
	public MovementAction MovementAction;

	public RotationAction RotationAction;

	public ScaleFromAction ScaleFromAction;

	public GameObject CardLost;

	public Card card;

	public void Initialize(Card card, int depth)
	{
	}

	public void PlayEffect()
	{
	}

	public void MoveTo(Vector3 position)
	{
	}

	public void RotateTo(Quaternion rotation)
	{
	}

	public void ScaleFrom(Vector3 scale)
	{
	}

	private void OnClick()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForDefaultThenPlayJukeboxCardSound_003Ed__19))]
	private IEnumerator WaitForDefaultThenPlayJukeboxCardSound()
	{
		return null;
	}
}
