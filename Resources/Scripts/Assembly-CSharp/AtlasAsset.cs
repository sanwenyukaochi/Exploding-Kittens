using Spine;
using UnityEngine;

public class AtlasAsset : ScriptableObject
{
	public TextAsset atlasFile;

	public Material[] materials;

	private Atlas atlas;

	public void Reset()
	{
	}

	public Atlas GetAtlas()
	{
		return null;
	}

	public Sprite GenerateSprite(string name, out Material material)
	{
		material = null;
		return null;
	}

	public Mesh GenerateMesh(string name, Mesh mesh, out Material material, float scale = 0.01f)
	{
		material = null;
		return null;
	}
}
