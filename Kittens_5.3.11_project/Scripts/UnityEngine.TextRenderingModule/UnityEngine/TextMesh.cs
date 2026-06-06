using UnityEngine.Bindings;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform), typeof(MeshRenderer))]
	[NativeClass("TextRenderingPrivate::TextMesh")]
	[NativeHeader("Modules/TextRendering/Public/TextMesh.h")]
	public sealed class TextMesh : Component
	{
		public string text
		{
			set
			{
			}
		}

		public Font font
		{
			set
			{
			}
		}

		public TextAnchor anchor
		{
			set
			{
			}
		}

		public float characterSize
		{
			set
			{
			}
		}
	}
}
