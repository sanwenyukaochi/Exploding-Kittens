using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Camera/Light.h")]
	[RequireComponent(typeof(Transform))]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
	public sealed class Light : Behaviour
	{
		private int m_BakedIndex;

		[NativeProperty("LightType")]
		public LightType type
		{
			get
			{
				return default(LightType);
			}
			set
			{
			}
		}

		public float spotAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float colorTemperature => 0f;

		public bool useColorTemperature => false;

		public float intensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float bounceIntensity => 0f;

		public float range
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Flare flare
		{
			set
			{
			}
		}

		public LightBakingOutput bakingOutput => default(LightBakingOutput);

		public LightShadows shadows
		{
			[NativeMethod("GetShadowType")]
			get
			{
				return default(LightShadows);
			}
		}

		public float shadowStrength
		{
			[FreeFunction("Light_Bindings::SetShadowStrength", HasExplicitThis = true)]
			set
			{
			}
		}

		public float cookieSize => 0f;

		public Texture cookie
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[SpecialName]
		private void get_color_Injected(out Color ret)
		{
			ret = default(Color);
		}

		[SpecialName]
		private void set_color_Injected(ref Color value)
		{
		}

		[SpecialName]
		private void get_bakingOutput_Injected(out LightBakingOutput ret)
		{
			ret = default(LightBakingOutput);
		}
	}
}
