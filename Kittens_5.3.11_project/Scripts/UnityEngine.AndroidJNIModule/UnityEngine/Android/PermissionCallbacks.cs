using System;
using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.Android
{
	public class PermissionCallbacks : AndroidJavaProxy
	{
		public event Action<string> PermissionGranted
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

		public event Action<string> PermissionDenied
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

		public event Action<string> PermissionDeniedAndDontAskAgain
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

		public PermissionCallbacks()
			: base((string)null)
		{
		}

		[Preserve]
		private void onPermissionGranted(string permissionName)
		{
		}

		[Preserve]
		private void onPermissionDenied(string permissionName)
		{
		}

		[Preserve]
		private void onPermissionDeniedAndDontAskAgain(string permissionName)
		{
		}
	}
}
