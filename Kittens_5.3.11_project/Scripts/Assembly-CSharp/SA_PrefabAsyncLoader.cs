using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SA_PrefabAsyncLoader : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoad_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SA_PrefabAsyncLoader _003C_003E4__this;

		private ResourceRequest _003Crequest_003E5__2;

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
		public _003CLoad_003Ed__6(int _003C_003E1__state)
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

	private string PrefabPath;

	public event Action<GameObject> ObjectLoadedAction
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

	public static SA_PrefabAsyncLoader Create(string name)
	{
		return null;
	}

	public void LoadAsync(string name)
	{
	}

	[IteratorStateMachine(typeof(_003CLoad_003Ed__6))]
	public IEnumerator Load()
	{
		return null;
	}
}
