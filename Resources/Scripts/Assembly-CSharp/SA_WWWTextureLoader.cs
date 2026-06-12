using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SA_WWWTextureLoader : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CLoadCoroutin_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SA_WWWTextureLoader _003C_003E4__this;

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
		public _003CLoadCoroutin_003Ed__7(int _003C_003E1__state)
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

	public static Dictionary<string, Texture2D> LocalCache;

	private string _url;

	public event Action<Texture2D> OnLoad
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

	public static SA_WWWTextureLoader Create()
	{
		return null;
	}

	public void LoadTexture(string url)
	{
	}

	[IteratorStateMachine(typeof(_003CLoadCoroutin_003Ed__7))]
	private IEnumerator LoadCoroutin()
	{
		return null;
	}

	private static void UpdateLocalCache(string url, Texture2D image)
	{
	}
}
