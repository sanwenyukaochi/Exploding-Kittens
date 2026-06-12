using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Runtime/Export/Handheld/Handheld.bindings.h")]
	[NativeHeader("PlatformDependent/AndroidPlayer/Source/EntryPoint.h")]
	[NativeHeader("Runtime/Input/GetInput.h")]
	[NativeHeader("Runtime/Video/MoviePlayback.h")]
	public class Handheld
	{
		public static bool PlayFullScreenMovie(string path, [DefaultValue("Color.black")] Color bgColor, [DefaultValue("FullScreenMovieControlMode.Full")] FullScreenMovieControlMode controlMode, [DefaultValue("FullScreenMovieScalingMode.AspectFit")] FullScreenMovieScalingMode scalingMode)
		{
			return false;
		}

		[FreeFunction("PlayFullScreenMovie")]
		private static bool PlayFullScreenMovie_Bindings(string path, Color bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode)
		{
			return false;
		}

		[FreeFunction("Vibrate")]
		public static void Vibrate()
		{
		}

		private static bool PlayFullScreenMovie_Bindings_Injected(string path, ref Color bgColor, FullScreenMovieControlMode controlMode, FullScreenMovieScalingMode scalingMode)
		{
			return false;
		}
	}
}
