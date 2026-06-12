using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(ISkeletonAnimation))]
public class SkeletonUtility : MonoBehaviour
{
	public delegate void SkeletonUtilityDelegate();

	public Transform boneRoot;

	[HideInInspector]
	public SkeletonRenderer skeletonRenderer;

	[HideInInspector]
	public ISkeletonAnimation skeletonAnimation;

	[NonSerialized]
	public List<SkeletonUtilityBone> utilityBones;

	[NonSerialized]
	public List<SkeletonUtilityConstraint> utilityConstraints;

	protected bool hasTransformBones;

	protected bool hasUtilityConstraints;

	protected bool needToReprocessBones;

	public event SkeletonUtilityDelegate OnReset
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static T GetInParent<T>(Transform origin) where T : Component
	{
		return null;
	}

	public static PolygonCollider2D AddBoundingBox(Skeleton skeleton, string skinName, string slotName, string attachmentName, Transform parent, bool isTrigger = true)
	{
		return null;
	}

	public static PolygonCollider2D AddBoundingBoxAsComponent(BoundingBoxAttachment boundingBox, GameObject gameObject, bool isTrigger = true)
	{
		return null;
	}

	public static Bounds GetBoundingBoxBounds(BoundingBoxAttachment boundingBox, float depth = 0f)
	{
		return default(Bounds);
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	private void HandleRendererReset(SkeletonRenderer r)
	{
	}

	public void RegisterBone(SkeletonUtilityBone bone)
	{
	}

	public void UnregisterBone(SkeletonUtilityBone bone)
	{
	}

	public void RegisterConstraint(SkeletonUtilityConstraint constraint)
	{
	}

	public void UnregisterConstraint(SkeletonUtilityConstraint constraint)
	{
	}

	public void CollectBones()
	{
	}

	private void UpdateLocal(SkeletonRenderer anim)
	{
	}

	private void UpdateWorld(SkeletonRenderer anim)
	{
	}

	private void UpdateComplete(SkeletonRenderer anim)
	{
	}

	private void UpdateAllBones()
	{
	}

	public Transform GetBoneRoot()
	{
		return null;
	}

	public GameObject SpawnRoot(SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
	{
		return null;
	}

	public GameObject SpawnHierarchy(SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
	{
		return null;
	}

	public GameObject SpawnBoneRecursively(Bone bone, Transform parent, SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
	{
		return null;
	}

	public GameObject SpawnBone(Bone bone, Transform parent, SkeletonUtilityBone.Mode mode, bool pos, bool rot, bool sca)
	{
		return null;
	}

	public void SpawnSubRenderers(bool disablePrimaryRenderer)
	{
	}
}
