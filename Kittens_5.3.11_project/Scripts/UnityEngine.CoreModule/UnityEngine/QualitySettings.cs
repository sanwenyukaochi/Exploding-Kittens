using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/QualitySettings.h")]
	[StaticAccessor("GetQualitySettings()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	public sealed class QualitySettings : Object
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<int, int> activeQualityLevelChanged;

		public static int vSyncCount
		{
			set
			{
			}
		}

		public static ColorSpace activeColorSpace
		{
			[NativeName("GetColorSpace")]
			[StaticAccessor("GetPlayerSettings()", StaticAccessorType.Dot)]
			get
			{
				return default(ColorSpace);
			}
		}

		[RequiredByNativeCode]
		internal static void OnActiveQualityLevelChanged(int previousQualityLevel, int currentQualityLevel)
		{
		}
	}
}
