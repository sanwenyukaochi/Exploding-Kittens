using UnityEngine;

public class DragDropDrawableCard : UIDragDropItem
{
	public CardBackSounds CardBackSounds;

	private CardBack cardBack;

	private Vector3 originalPositionBeforeDrag;

	private CardBack CardBack => null;

	protected override void Start()
	{
	}

	protected override void OnDragDropStart()
	{
	}

	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	protected override void OnDragEnd()
	{
	}

	private void CommitDrag(PlayerHandDropTarget cardDropTarget)
	{
	}

	private void CancelDrag()
	{
	}
}
