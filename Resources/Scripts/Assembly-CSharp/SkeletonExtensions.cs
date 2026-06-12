using Spine;
using UnityEngine;

public static class SkeletonExtensions
{
	public static void SetColor(this Skeleton skeleton, Color color)
	{
	}

	public static void SetColor(this Skeleton skeleton, Color32 color)
	{
	}

	public static void SetColor(this Slot slot, Color color)
	{
	}

	public static void SetColor(this Slot slot, Color32 color)
	{
	}

	public static void SetColor(this RegionAttachment attachment, Color color)
	{
	}

	public static void SetColor(this RegionAttachment attachment, Color32 color)
	{
	}

	public static void SetColor(this MeshAttachment attachment, Color color)
	{
	}

	public static void SetColor(this MeshAttachment attachment, Color32 color)
	{
	}

	public static void SetColor(this SkinnedMeshAttachment attachment, Color color)
	{
	}

	public static void SetColor(this SkinnedMeshAttachment attachment, Color32 color)
	{
	}

	public static void SetPosition(this Bone bone, Vector2 position)
	{
	}

	public static void SetPosition(this Bone bone, Vector3 position)
	{
	}

	public static Attachment AttachUnitySprite(this Skeleton skeleton, string slotName, Sprite sprite, string shaderName = "Spine/Skeleton")
	{
		return null;
	}

	public static Attachment AddUnitySprite(this SkeletonData skeletonData, string slotName, Sprite sprite, string skinName = "", string shaderName = "Spine/Skeleton")
	{
		return null;
	}

	public static RegionAttachment ToRegionAttachment(this Sprite sprite, string shaderName = "Spine/Skeleton")
	{
		return null;
	}
}
