using System.Collections.Generic;
using Spine;
using UnityEngine;

public class SpriteAttachmentLoader : AttachmentLoader
{
	public static Dictionary<int, AtlasRegion> atlasTable;

	public static List<int> premultipliedAtlasIds;

	private Sprite sprite;

	private Shader shader;

	public SpriteAttachmentLoader(Sprite sprite, Shader shader)
	{
	}

	public RegionAttachment NewRegionAttachment(Skin skin, string name, string path)
	{
		return null;
	}

	public MeshAttachment NewMeshAttachment(Skin skin, string name, string path)
	{
		return null;
	}

	public SkinnedMeshAttachment NewSkinnedMeshAttachment(Skin skin, string name, string path)
	{
		return null;
	}

	public BoundingBoxAttachment NewBoundingBoxAttachment(Skin skin, string name)
	{
		return null;
	}
}
