using UnityEngine;

public class TutorialDrawPileCard : UIDragDropItem
{
	public MovementAction MovementAction;

	public UIGrid HandGrid;

	public GameObject NewCard;

	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	private void CancelDrag()
	{
	}
}
