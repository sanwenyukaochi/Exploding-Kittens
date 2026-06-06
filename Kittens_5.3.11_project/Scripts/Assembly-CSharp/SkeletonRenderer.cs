using System;
using System.Collections.Generic;
using Spine;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
[ExecuteInEditMode]
public class SkeletonRenderer : MonoBehaviour
{
	public delegate void SkeletonRendererDelegate(SkeletonRenderer skeletonRenderer);

	private class LastState
	{
		public struct AddSubmeshArguments
		{
			public Material material;

			public int startSlot;

			public int endSlot;

			public int triangleCount;

			public int firstVertex;

			public bool lastSubmesh;

			public AddSubmeshArguments(Material material, int startSlot, int endSlot, int triangleCount, int firstVertex, bool lastSubmesh)
			{
				this.material = null;
				this.startSlot = 0;
				this.endSlot = 0;
				this.triangleCount = 0;
				this.firstVertex = 0;
				this.lastSubmesh = false;
			}

			public bool Equals(ref AddSubmeshArguments other)
			{
				return false;
			}
		}

		public bool immutableTrianglesMesh1;

		public bool immutableTrianglesMesh2;

		public int vertexCount;

		public readonly ExposedList<bool> attachmentsFlipStateTemp;

		public readonly ExposedList<bool> attachmentsFlipStateMesh1;

		public readonly ExposedList<bool> attachmentsFlipStateMesh2;

		public readonly ExposedList<int> attachmentsTriangleCountTemp;

		public readonly ExposedList<int> attachmentsTriangleCountMesh1;

		public readonly ExposedList<int> attachmentsTriangleCountMesh2;

		public readonly ExposedList<AddSubmeshArguments> addSubmeshArgumentsTemp;

		public readonly ExposedList<AddSubmeshArguments> addSubmeshArgumentsMesh1;

		public readonly ExposedList<AddSubmeshArguments> addSubmeshArgumentsMesh2;
	}

	public SkeletonRendererDelegate OnReset;

	[NonSerialized]
	public bool valid;

	[NonSerialized]
	public Skeleton skeleton;

	public SkeletonDataAsset skeletonDataAsset;

	public string initialSkinName;

	public bool calculateNormals;

	public bool calculateTangents;

	public float zSpacing;

	public bool renderMeshes;

	public bool immutableTriangles;

	public bool frontFacing;

	public bool logErrors;

	[SpineSlot(null, null, false)]
	public string[] submeshSeparators;

	[HideInInspector]
	public List<Slot> submeshSeparatorSlots;

	private MeshRenderer meshRenderer;

	private MeshFilter meshFilter;

	private Mesh mesh1;

	private Mesh mesh2;

	private bool useMesh1;

	private float[] tempVertices;

	private Vector3[] vertices;

	private Color32[] colors;

	private Vector2[] uvs;

	private Material[] sharedMaterials;

	private readonly ExposedList<Material> submeshMaterials;

	private readonly ExposedList<Submesh> submeshes;

	private SkeletonUtilitySubmeshRenderer[] submeshRenderers;

	private LastState lastState;

	public virtual void Reset()
	{
	}

	public void CollectSubmeshRenderers()
	{
	}

	public virtual void Awake()
	{
	}

	public virtual void OnDestroy()
	{
	}

	private Mesh newMesh()
	{
		return null;
	}

	public virtual void LateUpdate()
	{
	}

	private bool CheckIfMustUpdateMeshStructure(ExposedList<int> attachmentsTriangleCountTemp, ExposedList<bool> attachmentsFlipStateTemp, ExposedList<LastState.AddSubmeshArguments> addSubmeshArgumentsTemp)
	{
		return false;
	}

	private void AddSubmesh(Material material, int startSlot, int endSlot, int triangleCount, int firstVertex, bool lastSubmesh, ExposedList<bool> flipStates)
	{
	}
}
