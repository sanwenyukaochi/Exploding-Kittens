using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeClass("TextRendering::Font")]
	[StaticAccessor("TextRenderingPrivate", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/TextRendering/Public/FontImpl.h")]
	[NativeHeader("Modules/TextRendering/Public/Font.h")]
	public sealed class Font : Object
	{
		public delegate void FontTextureRebuildCallback();

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private FontTextureRebuildCallback m_FontTextureRebuildCallback;

		public Material material => null;

		public string[] fontNames => null;

		public bool dynamic => false;

		public int fontSize => 0;

		public static event Action<Font> textureRebuilt
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[RequiredByNativeCode]
		internal static void InvokeTextureRebuilt_Internal(Font font)
		{
		}

		public bool HasCharacter(char c)
		{
			return false;
		}

		private bool HasCharacter(int c)
		{
			return false;
		}

		private static void Internal_CreateFont([Writable] Font self, string name)
		{
		}

		[FreeFunction("TextRenderingPrivate::GetCharacterInfo", HasExplicitThis = true)]
		public bool GetCharacterInfo(char ch, out CharacterInfo info, [DefaultValue("0")] int size, [DefaultValue("FontStyle.Normal")] FontStyle style)
		{
			info = default(CharacterInfo);
			return false;
		}

		public void RequestCharactersInTexture(string characters, [DefaultValue("0")] int size, [DefaultValue("FontStyle.Normal")] FontStyle style)
		{
		}
	}
}
