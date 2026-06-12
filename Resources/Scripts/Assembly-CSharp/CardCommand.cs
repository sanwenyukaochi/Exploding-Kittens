using System;

[Serializable]
public class CardCommand
{
	public CardCategory CardCategory;

	public Card Card;

	public Player Player;

	public Player Target;

	public CardCommandDelegate OnFailure;

	public CategoryMetadata CategoryMetadata => null;

	public string PlayerId => null;

	public string TargetId => null;

	public CardCommand(Player player, Card card)
	{
	}

	public void NotifyFailure()
	{
	}
}
