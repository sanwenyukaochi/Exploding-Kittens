using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/CopyTexture.h")]
	[NativeHeader("Runtime/Graphics/ColorGamut.h")]
	[NativeHeader("Runtime/Misc/PlayerSettings.h")]
	[NativeHeader("Runtime/Camera/LightProbeProxyVolume.h")]
	public class Graphics
	{
		internal static readonly int kMaxDrawMeshInstanceCount;

		internal static Dictionary<int, RenderInstancedDataLayout> s_RenderInstancedDataLayouts;

		[FreeFunction("GraphicsScripting::GetMaxDrawMeshInstanceCount", IsThreadSafe = true)]
		private static int Internal_GetMaxDrawMeshInstanceCount()
		{
			return 0;
		}

		[FreeFunction("GraphicsScripting::SetNullRT")]
		private static void Internal_SetNullRT()
		{
		}

		[NativeMethod(Name = "GraphicsScripting::SetRTSimple", IsFreeFunction = true, ThrowsException = true)]
		private static void Internal_SetRTSimple(RenderBuffer color, RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule" })]
		[FreeFunction("GraphicsScripting::DrawTexture")]
		internal static void Internal_DrawTexture(ref Internal_DrawTextureArguments args)
		{
		}

		internal static void SetRenderTargetImpl(RenderBuffer colorBuffer, RenderBuffer depthBuffer, int mipLevel, CubemapFace face, int depthSlice)
		{
		}

		internal static void SetRenderTargetImpl(RenderTexture rt, int mipLevel, CubemapFace face, int depthSlice)
		{
		}

		public static void SetRenderTarget(RenderTexture rt, [DefaultValue("0")] int mipLevel, [DefaultValue("CubemapFace.Unknown")] CubemapFace face, [DefaultValue("0")] int depthSlice)
		{
		}

		[ExcludeFromDocs]
		public static void SetRenderTarget(RenderTexture rt)
		{
		}

		private static void Internal_SetRTSimple_Injected(ref RenderBuffer color, ref RenderBuffer depth, int mip, CubemapFace face, int depthSlice)
		{
		}
	}
}
