using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
	[NativeHeader("Runtime/Camera/RenderSettings.h")]
	[StaticAccessor("GetRenderSettings()", StaticAccessorType.Dot)]
	public sealed class RenderSettings : Object
	{
		[NativeProperty("UseFog")]
		public static bool fog
		{
			set
			{
			}
		}

		public static Color fogColor
		{
			set
			{
			}
		}

		public static float fogDensity
		{
			set
			{
			}
		}

		[NativeProperty("AmbientSkyColor")]
		public static Color ambientLight
		{
			set
			{
			}
		}

		[NativeProperty("SkyboxMaterial")]
		public static Material skybox
		{
			set
			{
			}
		}

		public static float haloStrength
		{
			set
			{
			}
		}

		public static float flareStrength
		{
			set
			{
			}
		}

		[SpecialName]
		private static void set_fogColor_Injected(ref Color value)
		{
		}

		[SpecialName]
		private static void set_ambientLight_Injected(ref Color value)
		{
		}
	}
}
