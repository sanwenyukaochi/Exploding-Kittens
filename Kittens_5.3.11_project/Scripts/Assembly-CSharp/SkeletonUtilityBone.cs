using System;
using Spine;
using UnityEngine;

[AddComponentMenu("Spine/SkeletonUtilityBone")]
[ExecuteInEditMode]
public class SkeletonUtilityBone : MonoBehaviour
{
	public enum Mode
	{
		Follow = 0,
		Override = 1
	}

	[NonSerialized]
	public bool valid;

	[NonSerialized]
	public SkeletonUtility skeletonUtility;

	[NonSerialized]
	public Bone bone;

	public Mode mode;

	public bool zPosition;

	public bool position;

	public bool rotation;

	public bool scale;

	public bool flip;

	public bool flipX;

	[Range(0f, 1f)]
	public float overrideAlpha;

	public string boneName;

	public Transform parentReference;

	[HideInInspector]
	public bool transformLerpComplete;

	protected Transform cachedTransform;

	protected Transform skeletonTransform;

	private bool nonUniformScaleWarning;

	public bool NonUniformScaleWarning => false;

	public void Reset()
	{
	}

	private void OnEnable()
	{
	}

	private void HandleOnReset()
	{
	}

	private void OnDisable()
	{
	}

	public void DoUpdate()
	{
	}

	public void FlipX(bool state)
	{
	}

	public void AddBoundingBox(string skinName, string slotName, string attachmentName)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
