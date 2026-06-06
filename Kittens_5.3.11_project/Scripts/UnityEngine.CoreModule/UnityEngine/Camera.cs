using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	[NativeHeader("Runtime/Camera/RenderManager.h")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
	[NativeHeader("Runtime/Shaders/Shader.h")]
	[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	public sealed class Camera : Behaviour
	{
		public enum MonoOrStereoscopicEye
		{
			Left = 0,
			Right = 1,
			Mono = 2
		}

		public delegate void CameraCallback(Camera cam);

		public const float kMinAperture = 0.7f;

		public const float kMaxAperture = 32f;

		public const int kMinBladeCount = 3;

		public const int kMaxBladeCount = 11;

		public static CameraCallback onPreCull;

		public static CameraCallback onPreRender;

		public static CameraCallback onPostRender;

		[NativeProperty("Near")]
		public float nearClipPlane
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("Far")]
		public float farClipPlane
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("VerticalFieldOfView")]
		public float fieldOfView
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float orthographicSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool orthographic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public TransparencySortMode transparencySortMode
		{
			get
			{
				return default(TransparencySortMode);
			}
			set
			{
			}
		}

		public float depth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float aspect
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int cullingMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int eventMask
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Color backgroundColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public CameraClearFlags clearFlags
		{
			get
			{
				return default(CameraClearFlags);
			}
			set
			{
			}
		}

		[NativeProperty("NormalizedViewportRect")]
		public Rect rect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		[NativeProperty("ScreenViewportRect")]
		public Rect pixelRect
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		public int pixelWidth
		{
			[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = true)]
			get
			{
				return 0;
			}
		}

		public int pixelHeight
		{
			[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = true)]
			get
			{
				return 0;
			}
		}

		public RenderTexture targetTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int targetDisplay => 0;

		public Matrix4x4 worldToCameraMatrix => default(Matrix4x4);

		public Matrix4x4 projectionMatrix => default(Matrix4x4);

		public static Camera main
		{
			[FreeFunction("FindMainCamera")]
			get
			{
				return null;
			}
		}

		public static Camera current
		{
			[FreeFunction("GetCurrentCameraPPtr")]
			get
			{
				return null;
			}
		}

		public static int allCamerasCount => 0;

		public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye)
		{
			return default(Vector3);
		}

		public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye)
		{
			return default(Vector3);
		}

		public Vector3 ViewportToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye)
		{
			return default(Vector3);
		}

		public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye)
		{
			return default(Vector3);
		}

		public Vector3 WorldToScreenPoint(Vector3 position)
		{
			return default(Vector3);
		}

		public Vector3 WorldToViewportPoint(Vector3 position)
		{
			return default(Vector3);
		}

		public Vector3 ViewportToWorldPoint(Vector3 position)
		{
			return default(Vector3);
		}

		public Vector3 ScreenToWorldPoint(Vector3 position)
		{
			return default(Vector3);
		}

		public Vector3 ScreenToViewportPoint(Vector3 position)
		{
			return default(Vector3);
		}

		private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye)
		{
			return default(Ray);
		}

		public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye)
		{
			return default(Ray);
		}

		public Ray ScreenPointToRay(Vector3 pos)
		{
			return default(Ray);
		}

		[FreeFunction("CameraScripting::GetAllCamerasCount")]
		private static int GetAllCamerasCount()
		{
			return 0;
		}

		[FreeFunction("CameraScripting::GetAllCameras")]
		private static int GetAllCamerasImpl([Out][NotNull("ArgumentNullException")] Camera[] cam)
		{
			return 0;
		}

		public static int GetAllCameras(Camera[] cameras)
		{
			return 0;
		}

		[FreeFunction("CameraScripting::Render", HasExplicitThis = true)]
		public void Render()
		{
		}

		[FreeFunction("CameraScripting::SetupCurrent")]
		public static void SetupCurrent(Camera cur)
		{
		}

		[RequiredByNativeCode]
		private static void FireOnPreCull(Camera cam)
		{
		}

		[RequiredByNativeCode]
		private static void FireOnPreRender(Camera cam)
		{
		}

		[RequiredByNativeCode]
		private static void FireOnPostRender(Camera cam)
		{
		}

		[SpecialName]
		private void get_backgroundColor_Injected(out Color ret)
		{
			ret = default(Color);
		}

		[SpecialName]
		private void set_backgroundColor_Injected(ref Color value)
		{
		}

		[SpecialName]
		private void get_rect_Injected(out Rect ret)
		{
			ret = default(Rect);
		}

		[SpecialName]
		private void set_rect_Injected(ref Rect value)
		{
		}

		[SpecialName]
		private void get_pixelRect_Injected(out Rect ret)
		{
			ret = default(Rect);
		}

		[SpecialName]
		private void set_pixelRect_Injected(ref Rect value)
		{
		}

		[SpecialName]
		private void get_worldToCameraMatrix_Injected(out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		[SpecialName]
		private void get_projectionMatrix_Injected(out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private void WorldToScreenPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private void WorldToViewportPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private void ViewportToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private void ScreenToWorldPoint_Injected(ref Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private void ScreenToViewportPoint_Injected(ref Vector3 position, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private void ScreenPointToRay_Injected(ref Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret)
		{
			ret = default(Ray);
		}
	}
}
