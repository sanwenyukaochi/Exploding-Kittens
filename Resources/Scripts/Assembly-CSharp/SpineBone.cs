using Spine;
using UnityEngine;

public class SpineBone : PropertyAttribute
{
	public string startsWith;

	public string dataField;

	public SpineBone(string startsWith = "", string dataField = "")
	{
	}

	public static Bone GetBone(string boneName, SkeletonRenderer renderer)
	{
		return null;
	}

	public static BoneData GetBoneData(string boneName, SkeletonDataAsset skeletonDataAsset)
	{
		return null;
	}
}
