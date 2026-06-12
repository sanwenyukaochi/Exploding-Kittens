using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[ExcludeFromPreset]
	[RequiredByNativeCode]
	public sealed class Mesh : Object
	{
		[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
		[StaticAccessor("MeshDataBindings", StaticAccessorType.DoubleColon)]
		public struct MeshData
		{
			[NativeDisableUnsafePtrRestriction]
			internal IntPtr m_Ptr;
		}

		internal bool canAccess
		{
			[NativeMethod("CanAccessFromScript")]
			get
			{
				return false;
			}
		}

		public int vertexCount
		{
			[NativeMethod("GetVertexCount")]
			get
			{
				return 0;
			}
		}

		public int subMeshCount
		{
			[NativeMethod(Name = "GetSubMeshCount")]
			get
			{
				return 0;
			}
			[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = true)]
			set
			{
			}
		}

		public Bounds bounds
		{
			get
			{
				return default(Bounds);
			}
			set
			{
			}
		}

		public Vector3[] vertices
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3[] normals
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector4[] tangents
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2[] uv
		{
			set
			{
			}
		}

		public Vector2[] uv2
		{
			set
			{
			}
		}

		public Color[] colors
		{
			set
			{
			}
		}

		public Color32[] colors32
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int[] triangles
		{
			set
			{
			}
		}

		[FreeFunction("MeshScripting::CreateMesh")]
		private static void Internal_Create([Writable] Mesh mono)
		{
		}

		[RequiredByNativeCode]
		public Mesh()
		{
		}

		[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = true)]
		private int[] GetIndicesImpl(int submesh, bool applyBaseVertex)
		{
			return null;
		}

		[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = true, ThrowsException = true)]
		private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex)
		{
		}

		[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = true)]
		private void PrintErrorCantAccessChannel(VertexAttribute ch)
		{
		}

		[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = true)]
		public bool HasVertexAttribute(VertexAttribute attr)
		{
			return false;
		}

		[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = true)]
		private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags)
		{
		}

		[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = true)]
		private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim)
		{
			return null;
		}

		[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = true)]
		private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values)
		{
		}

		[NativeMethod("Clear")]
		private void ClearImpl(bool keepVertexLayout)
		{
		}

		[NativeMethod("RecalculateBounds")]
		private void RecalculateBoundsImpl(MeshUpdateFlags flags)
		{
		}

		[NativeMethod("RecalculateNormals")]
		private void RecalculateNormalsImpl(MeshUpdateFlags flags)
		{
		}

		[NativeMethod("MarkDynamic")]
		private void MarkDynamicImpl()
		{
		}

		internal static VertexAttribute GetUVChannel(int uvIndex)
		{
			return default(VertexAttribute);
		}

		internal static int DefaultDimensionForChannel(VertexAttribute channel)
		{
			return 0;
		}

		private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim)
		{
			return null;
		}

		private T[] GetAllocArrayFromChannel<T>(VertexAttribute channel)
		{
			return null;
		}

		private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags)
		{
		}

		private void SetArrayForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = MeshUpdateFlags.Default)
		{
		}

		private void SetArrayForChannel<T>(VertexAttribute channel, T[] values, MeshUpdateFlags flags = MeshUpdateFlags.Default)
		{
		}

		private void SetListForChannel<T>(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags)
		{
		}

		private void SetListForChannel<T>(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags)
		{
		}

		private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim)
		{
		}

		private void GetListForChannel<T>(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType)
		{
		}

		public void SetVertices(List<Vector3> inVertices)
		{
		}

		[ExcludeFromDocs]
		public void SetVertices(List<Vector3> inVertices, int start, int length)
		{
		}

		public void SetVertices(List<Vector3> inVertices, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		public void SetNormals(List<Vector3> inNormals)
		{
		}

		[ExcludeFromDocs]
		public void SetNormals(List<Vector3> inNormals, int start, int length)
		{
		}

		public void SetNormals(List<Vector3> inNormals, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		public void SetTangents(List<Vector4> inTangents)
		{
		}

		[ExcludeFromDocs]
		public void SetTangents(List<Vector4> inTangents, int start, int length)
		{
		}

		public void SetTangents(List<Vector4> inTangents, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		public void SetColors(List<Color32> inColors)
		{
		}

		[ExcludeFromDocs]
		public void SetColors(List<Color32> inColors, int start, int length)
		{
		}

		public void SetColors(List<Color32> inColors, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		private void SetUvsImpl<T>(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags)
		{
		}

		public void SetUVs(int channel, List<Vector4> uvs)
		{
		}

		[ExcludeFromDocs]
		public void SetUVs(int channel, List<Vector4> uvs, int start, int length)
		{
		}

		public void SetUVs(int channel, List<Vector4> uvs, int start, int length, [DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		private void GetUVsImpl<T>(int uvIndex, List<T> uvs, int dim)
		{
		}

		public void GetUVs(int channel, List<Vector4> uvs)
		{
		}

		private void PrintErrorCantAccessIndices()
		{
		}

		private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles)
		{
			return false;
		}

		private bool CheckCanAccessSubmeshTriangles(int submesh)
		{
			return false;
		}

		private bool CheckCanAccessSubmeshIndices(int submesh)
		{
			return false;
		}

		[ExcludeFromDocs]
		public int[] GetIndices(int submesh)
		{
			return null;
		}

		public int[] GetIndices(int submesh, [DefaultValue("true")] bool applyBaseVertex)
		{
			return null;
		}

		private void CheckIndicesArrayRange(int valuesLength, int start, int length)
		{
		}

		private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex)
		{
		}

		[ExcludeFromDocs]
		public void SetTriangles(int[] triangles, int submesh)
		{
		}

		public void SetTriangles(int[] triangles, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex)
		{
		}

		public void SetTriangles(int[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		[ExcludeFromDocs]
		public void SetTriangles(List<int> triangles, int submesh)
		{
		}

		public void SetTriangles(List<int> triangles, int submesh, [DefaultValue("true")] bool calculateBounds, [DefaultValue("0")] int baseVertex)
		{
		}

		public void SetTriangles(List<int> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0)
		{
		}

		[ExcludeFromDocs]
		public void Clear()
		{
		}

		[ExcludeFromDocs]
		public void RecalculateBounds()
		{
		}

		[ExcludeFromDocs]
		public void RecalculateNormals()
		{
		}

		public void RecalculateBounds([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		public void RecalculateNormals([DefaultValue("MeshUpdateFlags.Default")] MeshUpdateFlags flags)
		{
		}

		public void MarkDynamic()
		{
		}

		[SpecialName]
		private void get_bounds_Injected(out Bounds ret)
		{
			ret = default(Bounds);
		}

		[SpecialName]
		private void set_bounds_Injected(ref Bounds value)
		{
		}
	}
}
