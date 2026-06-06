using System;

public class StealDropTarget : CardDropTarget
{
	public Action<HandCard> Callback;

	public override void DropCard(HandCard handCard, Action onFailure)
	{
	}
}
