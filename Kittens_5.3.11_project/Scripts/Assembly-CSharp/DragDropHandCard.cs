using UnityEngine;

public class DragDropHandCard : UIDragDropItem
{
	private const string DiscardPileTag = "Discard Pile";

	public Vector3 DragScale;

	public HandCard HandCard;

	public Restriction OriginalRestriction;

	protected override void OnDragDropStart()
	{
	}

	private void OnSelected()
	{
	}

	private void OnDeselected()
	{
	}

	public void RemoveFromHand()
	{
	}

	public void ReturnToHand(GameObject surface)
	{
	}

	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	protected override void OnDragDropEnd()
	{
	}

	public void SnapHandCardToTouch()
	{
	}

	private Vector3 TouchPositionInWorldSpace()
	{
		return default(Vector3);
	}
}
