using System;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
	[NativeHeader("Runtime/Shaders/GraphicsCapsScriptBindings.h")]
	[NativeHeader("Runtime/Input/GetInput.h")]
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[NativeHeader("Runtime/Camera/RenderLoops/MotionVectorRenderLoop.h")]
	[NativeHeader("Runtime/Misc/SystemInfo.h")]
	public sealed class SystemInfo
	{
		[NativeProperty]
		public static float batteryLevel => 0f;

		public static BatteryStatus batteryStatus => default(BatteryStatus);

		public static string operatingSystem => null;

		public static OperatingSystemFamily operatingSystemFamily => default(OperatingSystemFamily);

		public static string deviceUniqueIdentifier => null;

		public static string deviceName => null;

		public static string deviceModel => null;

		public static DeviceType deviceType => default(DeviceType);

		public static string graphicsDeviceName => null;

		public static string graphicsDeviceVersion => null;

		public static int graphicsShaderLevel => 0;

		public static int maxTextureSize => 0;

		internal static int maxRenderTextureSize => 0;

		private static bool IsValidEnumValue(Enum value)
		{
			return false;
		}

		public static bool SupportsTextureFormat(TextureFormat format)
		{
			return false;
		}

		[FreeFunction("systeminfo::GetBatteryLevel")]
		private static float GetBatteryLevel()
		{
			return 0f;
		}

		[FreeFunction("systeminfo::GetBatteryStatus")]
		private static BatteryStatus GetBatteryStatus()
		{
			return default(BatteryStatus);
		}

		[FreeFunction("systeminfo::GetOperatingSystem")]
		private static string GetOperatingSystem()
		{
			return null;
		}

		[FreeFunction("systeminfo::GetOperatingSystemFamily")]
		private static OperatingSystemFamily GetOperatingSystemFamily()
		{
			return default(OperatingSystemFamily);
		}

		[FreeFunction("systeminfo::GetDeviceUniqueIdentifier")]
		private static string GetDeviceUniqueIdentifier()
		{
			return null;
		}

		[FreeFunction("systeminfo::GetDeviceName")]
		private static string GetDeviceName()
		{
			return null;
		}

		[FreeFunction("systeminfo::GetDeviceModel")]
		private static string GetDeviceModel()
		{
			return null;
		}

		[FreeFunction("systeminfo::GetDeviceType")]
		private static DeviceType GetDeviceType()
		{
			return default(DeviceType);
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceName")]
		private static string GetGraphicsDeviceName()
		{
			return null;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsDeviceVersion")]
		private static string GetGraphicsDeviceVersion()
		{
			return null;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsShaderLevel")]
		private static int GetGraphicsShaderLevel()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::SupportsTextureFormat")]
		private static bool SupportsTextureFormatNative(TextureFormat format)
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetMaxTextureSize")]
		private static int GetMaxTextureSize()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetMaxRenderTextureSize")]
		private static int GetMaxRenderTextureSize()
		{
			return 0;
		}

		[FreeFunction("ScriptingGraphicsCaps::IsFormatSupported")]
		public static bool IsFormatSupported(GraphicsFormat format, FormatUsage usage)
		{
			return false;
		}

		[FreeFunction("ScriptingGraphicsCaps::GetCompatibleFormat")]
		public static GraphicsFormat GetCompatibleFormat(GraphicsFormat format, FormatUsage usage)
		{
			return default(GraphicsFormat);
		}

		[FreeFunction("ScriptingGraphicsCaps::GetGraphicsFormat")]
		public static GraphicsFormat GetGraphicsFormat(DefaultFormat format)
		{
			return default(GraphicsFormat);
		}
	}
}
