using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[StaticAccessor("GetGfxDevice()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/GfxDevice/GfxDevice.h")]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[NativeHeader("Runtime/Camera/CameraUtil.h")]
	public sealed class GL
	{
		public static Matrix4x4 modelview
		{
			set
			{
			}
		}

		[NativeName("ImmediateVertex")]
		public static void Vertex3(float x, float y, float z)
		{
		}

		[NativeName("ImmediateTexCoordAll")]
		public static void TexCoord3(float x, float y, float z)
		{
		}

		public static void TexCoord2(float x, float y)
		{
		}

		[NativeName("ImmediateColor")]
		private static void ImmediateColor(float r, float g, float b, float a)
		{
		}

		public static void Color(Color c)
		{
		}

		private static void SetViewMatrix(Matrix4x4 m)
		{
		}

		[FreeFunction("GLPushMatrixScript")]
		public static void PushMatrix()
		{
		}

		[FreeFunction("GLPopMatrixScript")]
		public static void PopMatrix()
		{
		}

		[FreeFunction("GLLoadOrthoScript")]
		public static void LoadOrtho()
		{
		}

		[FreeFunction("GLLoadProjectionMatrixScript")]
		public static void LoadProjectionMatrix(Matrix4x4 mat)
		{
		}

		[FreeFunction]
		private static void GLLoadPixelMatrixScript(float left, float right, float bottom, float top)
		{
		}

		public static void LoadPixelMatrix(float left, float right, float bottom, float top)
		{
		}

		[FreeFunction("GLBegin", ThrowsException = true)]
		public static void Begin(int mode)
		{
		}

		[FreeFunction("GLEnd")]
		public static void End()
		{
		}

		[FreeFunction]
		private static void GLClear(bool clearDepth, bool clearColor, Color backgroundColor, float depth)
		{
		}

		public static void Clear(bool clearDepth, bool clearColor, Color backgroundColor, [DefaultValue("1.0f")] float depth)
		{
		}

		[FreeFunction("SetGLViewport")]
		public static void Viewport(Rect pixelRect)
		{
		}

		private static void SetViewMatrix_Injected(ref Matrix4x4 m)
		{
		}

		private static void LoadProjectionMatrix_Injected(ref Matrix4x4 mat)
		{
		}

		private static void GLClear_Injected(bool clearDepth, bool clearColor, ref Color backgroundColor, float depth)
		{
		}

		private static void Viewport_Injected(ref Rect pixelRect)
		{
		}
	}
}
