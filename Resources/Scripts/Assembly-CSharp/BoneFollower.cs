using System;
using Spine;
using UnityEngine;

[AddComponentMenu("Spine/BoneFollower")]
[ExecuteInEditMode]
public class BoneFollower : MonoBehaviour
{
	[NonSerialized]
	public bool valid;

	public SkeletonRenderer skeletonRenderer;

	public Bone bone;

	public bool followZPosition;

	public bool followBoneRotation;

	[SpineBone(null, "skeletonRenderer")]
	public string boneName;

	public bool resetOnAwake;

	protected Transform cachedTransform;

	protected Transform skeletonTransform;

	public SkeletonRenderer SkeletonRenderer
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void HandleResetRenderer(SkeletonRenderer skeletonRenderer)
	{
	}

	public void Reset()
	{
	}

	private void OnDestroy()
	{
	}

	public void Awake()
	{
	}

	private void LateUpdate()
	{
	}

	public void DoUpdate()
	{
	}
}
