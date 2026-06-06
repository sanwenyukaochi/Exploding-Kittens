using System.Collections.Generic;
using Spine;
using UnityEngine;

[RequireComponent(typeof(SkeletonRenderer))]
public class SkeletonGhost : MonoBehaviour
{
	public bool ghostingEnabled;

	public float spawnRate;

	public Color32 color;

	[Tooltip("Remember to set color alpha to 0 if Additive is true")]
	public bool additive;

	public int maximumGhosts;

	public float fadeSpeed;

	public Shader ghostShader;

	[Tooltip("0 is Color and Alpha, 1 is Alpha only.")]
	[Range(0f, 1f)]
	public float textureFade;

	private float nextSpawnTime;

	private SkeletonGhostRenderer[] pool;

	private int poolIndex;

	private SkeletonRenderer skeletonRenderer;

	private MeshRenderer meshRenderer;

	private MeshFilter meshFilter;

	private Dictionary<Material, Material> materialTable;

	private void Start()
	{
	}

	private void OnEvent(Spine.AnimationState state, int trackIndex, Spine.Event e)
	{
	}

	private void Ghosting(float val)
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private static Color32 HexToColor(string hex)
	{
		return default(Color32);
	}
}
