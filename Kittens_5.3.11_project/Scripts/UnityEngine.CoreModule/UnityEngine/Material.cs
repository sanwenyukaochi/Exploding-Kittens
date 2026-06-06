using System;
using System.ComponentModel;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Shaders/Material.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	public class Material : Object
	{
		public Shader shader
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

		public Texture mainTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2 mainTextureOffset
		{
			set
			{
			}
		}

		public Vector2 mainTextureScale
		{
			set
			{
			}
		}

		public int renderQueue
		{
			[NativeName("GetActualRenderQueue")]
			get
			{
				return 0;
			}
			[NativeName("SetCustomRenderQueue")]
			set
			{
			}
		}

		public int passCount
		{
			[NativeName("GetShader()->GetPassCount")]
			get
			{
				return 0;
			}
		}

		public string[] shaderKeywords
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[FreeFunction("MaterialScripting::CreateWithShader")]
		private static void CreateWithShader([Writable] Material self, [NotNull("ArgumentNullException")] Shader shader)
		{
		}

		[FreeFunction("MaterialScripting::CreateWithMaterial")]
		private static void CreateWithMaterial([Writable] Material self, [NotNull("ArgumentNullException")] Material source)
		{
		}

		[FreeFunction("MaterialScripting::CreateWithString")]
		private static void CreateWithString([Writable] Material self)
		{
		}

		public Material(Shader shader)
		{
		}

		[RequiredByNativeCode]
		public Material(Material source)
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", false)]
		public Material(string contents)
		{
		}

		[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
		private int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag)
		{
			return 0;
		}

		[NativeName("HasPropertyFromScript")]
		public bool HasProperty(int nameID)
		{
			return false;
		}

		public bool HasProperty(string name)
		{
			return false;
		}

		public void EnableKeyword(string keyword)
		{
		}

		public void DisableKeyword(string keyword)
		{
		}

		[NativeName("GetTag")]
		private string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue)
		{
			return null;
		}

		public string GetTag(string tag, bool searchFallbacks)
		{
			return null;
		}

		[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = true)]
		public bool SetPass(int pass)
		{
			return false;
		}

		[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = true)]
		public void CopyPropertiesFromMaterial(Material mat)
		{
		}

		[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = true)]
		private string[] GetShaderKeywords()
		{
			return null;
		}

		[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = true)]
		private void SetShaderKeywords(string[] names)
		{
		}

		public int ComputeCRC()
		{
			return 0;
		}

		[NativeName("SetFloatFromScript")]
		private void SetFloatImpl(int name, float value)
		{
		}

		[NativeName("SetColorFromScript")]
		private void SetColorImpl(int name, Color value)
		{
		}

		[NativeName("SetMatrixFromScript")]
		private void SetMatrixImpl(int name, Matrix4x4 value)
		{
		}

		[NativeName("SetTextureFromScript")]
		private void SetTextureImpl(int name, Texture value)
		{
		}

		[NativeName("GetFloatFromScript")]
		private float GetFloatImpl(int name)
		{
			return 0f;
		}

		[NativeName("GetColorFromScript")]
		private Color GetColorImpl(int name)
		{
			return default(Color);
		}

		[NativeName("GetTextureFromScript")]
		private Texture GetTextureImpl(int name)
		{
			return null;
		}

		[NativeName("SetTextureOffsetFromScript")]
		private void SetTextureOffsetImpl(int name, Vector2 offset)
		{
		}

		[NativeName("SetTextureScaleFromScript")]
		private void SetTextureScaleImpl(int name, Vector2 scale)
		{
		}

		public void SetFloat(string name, float value)
		{
		}

		public void SetFloat(int nameID, float value)
		{
		}

		public void SetColor(string name, Color value)
		{
		}

		public void SetColor(int nameID, Color value)
		{
		}

		public void SetVector(string name, Vector4 value)
		{
		}

		public void SetVector(int nameID, Vector4 value)
		{
		}

		public void SetMatrix(int nameID, Matrix4x4 value)
		{
		}

		public void SetTexture(string name, Texture value)
		{
		}

		public void SetTexture(int nameID, Texture value)
		{
		}

		public float GetFloat(string name)
		{
			return 0f;
		}

		public float GetFloat(int nameID)
		{
			return 0f;
		}

		public Color GetColor(string name)
		{
			return default(Color);
		}

		public Color GetColor(int nameID)
		{
			return default(Color);
		}

		public Vector4 GetVector(int nameID)
		{
			return default(Vector4);
		}

		public Texture GetTexture(string name)
		{
			return null;
		}

		public Texture GetTexture(int nameID)
		{
			return null;
		}

		public void SetTextureOffset(string name, Vector2 value)
		{
		}

		public void SetTextureOffset(int nameID, Vector2 value)
		{
		}

		public void SetTextureScale(string name, Vector2 value)
		{
		}

		public void SetTextureScale(int nameID, Vector2 value)
		{
		}

		private void SetColorImpl_Injected(int name, ref Color value)
		{
		}

		private void SetMatrixImpl_Injected(int name, ref Matrix4x4 value)
		{
		}

		private void GetColorImpl_Injected(int name, out Color ret)
		{
			ret = default(Color);
		}

		private void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset)
		{
		}

		private void SetTextureScaleImpl_Injected(int name, ref Vector2 scale)
		{
		}
	}
}
