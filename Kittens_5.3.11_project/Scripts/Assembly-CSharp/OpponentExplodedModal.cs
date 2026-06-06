using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(WindowTransitioner))]
public class OpponentExplodedModal : MonoBehaviour, IModal
{
	[CompilerGenerated]
	private sealed class _003CAnimate_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OpponentExplodedModal _003C_003E4__this;

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
		public _003CAnimate_003Ed__18(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CWaitThenHide_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OpponentExplodedModal _003C_003E4__this;

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
		public _003CWaitThenHide_003Ed__19(int _003C_003E1__state)
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

	public WindowTransitioner WindowTransitioner;

	public AvatarGrid AvatarGrid;

	public Player RecentlyDeceased;

	public OpponentExplodedModalFacts OpponentExplodedModalFacts;

	public float FactsShowDelay;

	public UILabel OpponentNameLabel;

	public RecenterTwoWidgets HeaderWidgets;

	public PlayMakerFSM WhatRemainsFsm;

	private const float HANG_TIME = 10f;

	[Header("Player List")]
	public PlayerProvider PlayerProvider;

	public TurnQueue TurnQueue;

	private Avatar recentlyDeceasedAvatar;

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

	private void CreateAvatars()
	{
	}

	private void Shown()
	{
	}

	[IteratorStateMachine(typeof(_003CAnimate_003Ed__18))]
	private IEnumerator Animate()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitThenHide_003Ed__19))]
	private IEnumerator WaitThenHide()
	{
		return null;
	}

	private void Done()
	{
	}
}
