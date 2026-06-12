using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
	[NativeHeader("Runtime/Graphics/Texture2D.h")]
	[UsedByNativeCode]
	[ExcludeFromPreset]
	public sealed class Texture2D : Texture
	{
		internal const int streamingMipmapsPriorityMin = -128;

		internal const int streamingMipmapsPriorityMax = 127;

		public TextureFormat format
		{
			[NativeName("GetTextureFormat")]
			get
			{
				return default(TextureFormat);
			}
		}

		[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
		public static Texture2D whiteTexture => null;

		public override bool isReadable => false;

		[FreeFunction("Texture2DScripting::Create")]
		private static bool Internal_CreateImpl([Writable] Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName)
		{
			return false;
		}

		private static void Internal_Create([Writable] Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName)
		{
		}

		[NativeName("Apply")]
		private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable)
		{
		}

		[NativeName("Reinitialize")]
		private bool ReinitializeImpl(int width, int height)
		{
			return false;
		}

		[NativeName("SetPixel")]
		private void SetPixelImpl(int image, int mip, int x, int y, Color color)
		{
		}

		[NativeName("GetPixelBilinear")]
		private Color GetPixelBilinearImpl(int image, int mip, float u, float v)
		{
			return default(Color);
		}

		[FreeFunction(Name = "Texture2DScripting::ReinitializeWithTextureFormat", HasExplicitThis = true)]
		private bool ReinitializeWithTextureFormatImpl(int width, int height, TextureFormat textureFormat, bool hasMipMap)
		{
			return false;
		}

		[FreeFunction(Name = "Texture2DScripting::ReadPixels", HasExplicitThis = true)]
		private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps)
		{
		}

		[FreeFunction(Name = "Texture2DScripting::SetPixels", HasExplicitThis = true, ThrowsException = true)]
		private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame)
		{
		}

		private IntPtr GetWritableImageData(int frame)
		{
			return (IntPtr)0;
		}

		private ulong GetRawImageDataSize()
		{
			return 0uL;
		}

		[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = true, ThrowsException = true)]
		private void SetAllPixels32([Unmarshalled] Color32[] colors, int miplevel)
		{
		}

		[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = true, ThrowsException = true)]
		public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, [DefaultValue("0")] int miplevel)
		{
			return null;
		}

		[FreeFunction("Texture2DScripting::GetPixels32", HasExplicitThis = true, ThrowsException = true)]
		public Color32[] GetPixels32([DefaultValue("0")] int miplevel)
		{
			return null;
		}

		[ExcludeFromDocs]
		public Color32[] GetPixels32()
		{
			return null;
		}

		internal bool ValidateFormat(TextureFormat format, int width, int height)
		{
			return false;
		}

		internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName)
		{
		}

		public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("-1")] int mipCount, [DefaultValue("false")] bool linear)
		{
		}

		[ExcludeFromDocs]
		public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain)
		{
		}

		[ExcludeFromDocs]
		public Texture2D(int width, int height)
		{
		}

		[ExcludeFromDocs]
		public void SetPixel(int x, int y, Color color)
		{
		}

		public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, [DefaultValue("0")] int miplevel)
		{
		}

		[ExcludeFromDocs]
		public void SetPixels(Color[] colors)
		{
		}

		[ExcludeFromDocs]
		public Color GetPixelBilinear(float u, float v)
		{
			return default(Color);
		}

		public NativeArray<T> GetRawTextureData<T>() where T : struct
		{
			return default(NativeArray<T>);
		}

		public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable)
		{
		}

		[ExcludeFromDocs]
		public void Apply()
		{
		}

		public bool Reinitialize(int width, int height)
		{
			return false;
		}

		public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap)
		{
			return false;
		}

		[Obsolete("Texture2D.Resize(int, int) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32)", false)]
		public bool Resize(int width, int height)
		{
			return false;
		}

		[Obsolete("Texture2D.Resize(int, int, TextureFormat, bool) has been deprecated because it actually reinitializes the texture. Use Texture2D.Reinitialize(int, int, TextureFormat, bool) instead (UnityUpgradable) -> Reinitialize([*] System.Int32, [*] System.Int32, UnityEngine.TextureFormat, [*] System.Boolean)", false)]
		public bool Resize(int width, int height, TextureFormat format, bool hasMipMap)
		{
			return false;
		}

		public void ReadPixels(Rect source, int destX, int destY, [DefaultValue("true")] bool recalculateMipMaps)
		{
		}

		[ExcludeFromDocs]
		public void ReadPixels(Rect source, int destX, int destY)
		{
		}

		public void SetPixels32(Color32[] colors, [DefaultValue("0")] int miplevel)
		{
		}

		[ExcludeFromDocs]
		public void SetPixels32(Color32[] colors)
		{
		}

		public Color[] GetPixels([DefaultValue("0")] int miplevel)
		{
			return null;
		}

		[ExcludeFromDocs]
		public Color[] GetPixels()
		{
			return null;
		}

		private void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color)
		{
		}

		private void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, out Color ret)
		{
			ret = default(Color);
		}

		private void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps)
		{
		}
	}
}
