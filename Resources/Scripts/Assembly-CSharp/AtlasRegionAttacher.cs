using System;
using Spine;
using UnityEngine;

public class AtlasRegionAttacher : MonoBehaviour
{
	[Serializable]
	public class SlotRegionPair
	{
		[SpineSlot(null, null, false)]
		public string slot;

		[SpineAtlasRegion]
		public string region;
	}

	public AtlasAsset atlasAsset;

	public SlotRegionPair[] attachments;

	private Atlas atlas;

	private void Awake()
	{
	}

	private void Apply(SkeletonRenderer skeletonRenderer)
	{
	}
}
