using UnityEngine;

public class GameStats : MonoBehaviour
{
	public PlayerRepository PlayerRepository;

	public int MaxDefuseCount => 0;

	public int MaxAttackedCount => 0;

	public Player MaxHandSizePlayer => null;

	public Player MaxDefusePlayer => null;

	public Player MostAttackedPlayer => null;

	public int DeckType => 0;

	public int NumPlayers => 0;

	public int SecondsInGame => 0;

	public int CardsDrawn => 0;

	public int CardsPlayed => 0;

	private Player FirstLocalPlayer => null;
}
