using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnterCodeInputController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CVerifyCode_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnterCodeInputController _003C_003E4__this;

		public string code;

		public Action<bool> Result;

		private WWW _003Cwww_003E5__2;

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
		public _003CVerifyCode_003Ed__7(int _003C_003E1__state)
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

	public UIInput CodeInput;

	public List<UserInputTransformer> UserInputTransformers;

	private bool VerifyingCode;

	private Action<bool> OnCodeVerifiedResult;

	public void Setup(Action<bool> OnCodeVerifiedResult)
	{
	}

	public void OnEnable()
	{
	}

	public void OnSelect(bool isSelected)
	{
	}

	[IteratorStateMachine(typeof(_003CVerifyCode_003Ed__7))]
	private IEnumerator VerifyCode(string code, Action<bool> Result)
	{
		return null;
	}
}
