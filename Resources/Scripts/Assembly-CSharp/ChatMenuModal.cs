using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChatMenuModal : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitThenDismiss_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChatMenuModal _003C_003E4__this;

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
		public _003CWaitThenDismiss_003Ed__14(int _003C_003E1__state)
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

	public float AutomaticDismissDelay;

	public WindowTransitioner WindowTransitioner;

	public GenericEvent OnShow;

	public GenericEvent OnHide;

	public ChatMenuGridController ChatMenuGridController;

	public UIScrollView DraggableScrollView;

	public void Start()
	{
	}

	public void OnDestroy()
	{
	}

	public void Toggle()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void OnDragStarted()
	{
	}

	private void OnDragFinished()
	{
	}

	private void OnEmoteSelected(string emoteId)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitThenDismiss_003Ed__14))]
	private IEnumerator WaitThenDismiss()
	{
		return null;
	}
}
