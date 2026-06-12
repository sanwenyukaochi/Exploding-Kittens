using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform))]
	[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
	public sealed class SpriteRenderer : Renderer
	{
		private UnityEvent<SpriteRenderer> m_SpriteChangeEvent;

		public Sprite sprite
		{
			get
			{
				return null;
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

		public SpriteMaskInteraction maskInteraction
		{
			get
			{
				return default(SpriteMaskInteraction);
			}
			set
			{
			}
		}

		public bool flipX
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool flipY
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public SpriteSortPoint spriteSortPoint
		{
			get
			{
				return default(SpriteSortPoint);
			}
			set
			{
			}
		}

		[RequiredByNativeCode]
		private void InvokeSpriteChanged()
		{
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
	}
}
