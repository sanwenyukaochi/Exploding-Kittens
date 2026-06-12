using System.Collections.Generic;
using Spine;
using UnityEngine;

[ExecuteInEditMode]
public class BoundingBoxFollower : MonoBehaviour
{
	public SkeletonRenderer skeletonRenderer;

	[SpineSlot(null, "skeletonRenderer", true)]
	public string slotName;

	[Tooltip("LOL JK, Someone else do it!")]
	public bool use3DMeshCollider;

	private Slot slot;

	private BoundingBoxAttachment currentAttachment;

	private PolygonCollider2D currentCollider;

	private string currentAttachmentName;

	private bool valid;

	private bool hasReset;

	public Dictionary<BoundingBoxAttachment, PolygonCollider2D> colliderTable;

	public Dictionary<BoundingBoxAttachment, string> attachmentNameTable;

	public string CurrentAttachmentName => null;

	public BoundingBoxAttachment CurrentAttachment => null;

	public PolygonCollider2D CurrentCollider => null;

	public Slot Slot => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
	}

	public void HandleReset(SkeletonRenderer renderer)
	{
	}

	private void ClearColliders()
	{
	}

	private void LateUpdate()
	{
	}

	private void SetCurrent(BoundingBoxAttachment attachment)
	{
	}
}
