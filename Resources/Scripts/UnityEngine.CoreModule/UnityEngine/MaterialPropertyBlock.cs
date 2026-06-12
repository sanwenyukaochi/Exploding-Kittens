using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Math/SphericalHarmonicsL2.h")]
	[NativeHeader("Runtime/Shaders/ComputeShader.h")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/ShaderPropertySheet.h")]
	public sealed class MaterialPropertyBlock
	{
		internal IntPtr m_Ptr;

		[NativeName("SetTextureFromScript")]
		[ThreadSafe]
		private void SetTextureImpl(int name, [NotNull("ArgumentNullException")] Texture value)
		{
		}

		[ThreadSafe]
		[NativeName("SetVectorArrayFromScript")]
		private void SetVectorArrayImpl(int name, Vector4[] values, int count)
		{
		}

		[NativeMethod(Name = "MaterialPropertyBlockScripting::Create", IsFreeFunction = true)]
		private static IntPtr CreateImpl()
		{
			return (IntPtr)0;
		}

		[NativeMethod(Name = "MaterialPropertyBlockScripting::Destroy", IsFreeFunction = true, IsThreadSafe = true)]
		private static void DestroyImpl(IntPtr mpb)
		{
		}

		[ThreadSafe]
		private void Clear(bool keepMemory)
		{
		}

		public void Clear()
		{
		}

		private void SetVectorArray(int name, Vector4[] values, int count)
		{
		}

		~MaterialPropertyBlock()
		{
		}

		private void Dispose()
		{
		}

		public void SetTexture(int nameID, Texture value)
		{
		}

		public void SetVectorArray(int nameID, Vector4[] values)
		{
		}
	}
}
