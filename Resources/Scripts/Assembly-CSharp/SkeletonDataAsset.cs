using Spine;
using UnityEngine;

public class SkeletonDataAsset : ScriptableObject
{
	public AtlasAsset[] atlasAssets;

	public TextAsset skeletonJSON;

	public float scale;

	public string[] fromAnimation;

	public string[] toAnimation;

	public float[] duration;

	public float defaultMix;

	public RuntimeAnimatorController controller;

	private SkeletonData skeletonData;

	private AnimationStateData stateData;

	public void Reset()
	{
	}

	public SkeletonData GetSkeletonData(bool quiet)
	{
		return null;
	}

	public void FillStateData()
	{
	}

	public AnimationStateData GetAnimationStateData()
	{
		return null;
	}
}
