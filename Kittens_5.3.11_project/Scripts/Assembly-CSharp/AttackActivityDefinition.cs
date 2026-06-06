using System;

[Serializable]
public class AttackActivityDefinition
{
	public CardCategory CardCategory;

	public int TurnsRemaining;

	public ActivityType ActivityTypeToEmit;
}
