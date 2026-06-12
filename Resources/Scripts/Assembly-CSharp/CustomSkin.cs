using System;
using Spine;
using UnityEngine;

public class CustomSkin : MonoBehaviour
{
	[Serializable]
	public class SkinPair
	{
		[SpineAttachment(false, true, false, null, "skinSource")]
		public string sourceAttachment;

		[SpineSlot(null, null, false)]
		public string targetSlot;

		[SpineAttachment(true, false, true, null, null)]
		public string targetAttachment;
	}

	public SkeletonDataAsset skinSource;

	public SkinPair[] skinning;

	public Skin customSkin;

	private SkeletonRenderer skeletonRenderer;

	private void Start()
	{
	}
}
