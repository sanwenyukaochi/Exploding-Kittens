using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/Renderer.h")]
	public class Renderer : Component
	{
		public Bounds bounds
		{
			[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = true)]
			get
			{
				return default(Bounds);
			}
		}

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isVisible
		{
			[NativeName("IsVisibleInScene")]
			get
			{
				return false;
			}
		}

		public ShadowCastingMode shadowCastingMode
		{
			set
			{
			}
		}

		public bool receiveShadows
		{
			set
			{
			}
		}

		public string sortingLayerName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int sortingLayerID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int sortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal int sortingGroupID => 0;

		internal int sortingGroupOrder => 0;

		public Material[] materials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material sharedMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Material[] sharedMaterials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = true)]
		private Material GetMaterial()
		{
			return null;
		}

		[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = true)]
		private Material GetSharedMaterial()
		{
			return null;
		}

		[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = true)]
		private void SetMaterial(Material m)
		{
		}

		[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = true)]
		private Material[] GetMaterialArray()
		{
			return null;
		}

		[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = true)]
		private void SetMaterialArray([NotNull("ArgumentNullException")] Material[] m, int length)
		{
		}

		private void SetMaterialArray(Material[] m)
		{
		}

		[NativeName("GetMaterialArray")]
		private Material[] GetSharedMaterialArray()
		{
			return null;
		}

		[SpecialName]
		private void get_bounds_Injected(out Bounds ret)
		{
			ret = default(Bounds);
		}
	}
}
