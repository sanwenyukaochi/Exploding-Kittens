using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[StaticAccessor("GetScreenManager()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Graphics/WindowLayout.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/ScreenManager.h")]
	public sealed class Screen
	{
		public static int width
		{
			[NativeMethod(Name = "GetWidth", IsThreadSafe = true)]
			get
			{
				return 0;
			}
		}

		public static int height
		{
			[NativeMethod(Name = "GetHeight", IsThreadSafe = true)]
			get
			{
				return 0;
			}
		}

		public static float dpi
		{
			[NativeName("GetDPI")]
			get
			{
				return 0f;
			}
		}

		public static ScreenOrientation orientation => default(ScreenOrientation);

		[NativeProperty("ScreenTimeout")]
		public static int sleepTimeout
		{
			set
			{
			}
		}

		public static bool fullScreen
		{
			[NativeName("IsFullscreen")]
			get
			{
				return false;
			}
		}

		private static ScreenOrientation GetScreenOrientation()
		{
			return default(ScreenOrientation);
		}

		[NativeName("RequestResolution")]
		public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("SetResolution(int, int, bool, int) is obsolete. Use SetResolution(int, int, FullScreenMode, RefreshRate) instead.")]
		public static void SetResolution(int width, int height, bool fullscreen, [UnityEngine.Internal.DefaultValue("0")] int preferredRefreshRate)
		{
		}

		public static void SetResolution(int width, int height, bool fullscreen)
		{
		}

		private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, ref RefreshRate preferredRefreshRate)
		{
		}
	}
}
