using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/DisplayManager.h")]
	public class Display
	{
		public delegate void DisplaysUpdatedDelegate();

		internal IntPtr nativeDisplay;

		public static Display[] displays;

		private static Display _mainDisplay;

		private static int m_ActiveEditorGameViewTarget;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static DisplaysUpdatedDelegate onDisplaysUpdated;

		public int renderingWidth => 0;

		public int renderingHeight => 0;

		public int systemWidth => 0;

		public int systemHeight => 0;

		public static Display main => null;

		internal Display()
		{
		}

		internal Display(IntPtr nativeDisplay)
		{
		}

		public static Vector3 RelativeMouseAt(Vector3 inputMouseCoordinates)
		{
			return default(Vector3);
		}

		[RequiredByNativeCode]
		internal static void RecreateDisplayList(IntPtr[] nativeDisplay)
		{
		}

		[RequiredByNativeCode]
		internal static void FireDisplaysUpdated()
		{
		}

		[FreeFunction("UnityDisplayManager_DisplaySystemResolution")]
		private static void GetSystemExtImpl(IntPtr nativeDisplay, out int w, out int h)
		{
			w = default(int);
			h = default(int);
		}

		[FreeFunction("UnityDisplayManager_DisplayRenderingResolution")]
		private static void GetRenderingExtImpl(IntPtr nativeDisplay, out int w, out int h)
		{
			w = default(int);
			h = default(int);
		}

		[FreeFunction("UnityDisplayManager_RelativeMouseAt")]
		private static int RelativeMouseAtImpl(int x, int y, out int rx, out int ry)
		{
			rx = default(int);
			ry = default(int);
			return 0;
		}
	}
}
