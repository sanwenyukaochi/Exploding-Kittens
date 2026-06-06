using System;
using UnityEngine;

[ExecuteInEditMode]
public class SkeletonUtilitySubmeshRenderer : MonoBehaviour
{
	[NonSerialized]
	public Mesh mesh;

	public int submeshIndex;

	public Material hiddenPassMaterial;

	private Renderer cachedRenderer;

	private MeshFilter filter;

	private Material[] sharedMaterials;

	private void Awake()
	{
	}

	public void SetMesh(Renderer parentRenderer, Mesh mesh, Material mat)
	{
	}
}
