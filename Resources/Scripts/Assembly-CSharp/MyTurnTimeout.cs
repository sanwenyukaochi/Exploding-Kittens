using UnityEngine;

public class MyTurnTimeout : MonoBehaviour
{
	public PlayerProvider PlayerProvider;

	public Countdown Countdown;

	public CatPawCountdownFactory CatPawCountdownFactory;

	public GameMessages GameMessages;

	public ModalQueue ModalQueue;

	public NextDrawnCardProvider NextDrawnCardProvider;

	private PlayerPhase[] PlayerPhasesThatStartCountdowns => null;

	private Player Player => null;

	private void Start()
	{
	}

	private void OnPlayerPhaseEnded(Player _, PlayerPhase playerPhase)
	{
	}

	private void OnPlayerPhaseChange(Player _, PlayerPhase playerPhase)
	{
	}

	private void OnShowingFirstModal()
	{
	}

	private void OnAllModalsEnded()
	{
	}

	private void StartCountdown()
	{
	}

	private void OnCountdownEnded()
	{
	}

	private void OnPlayCard(Player _, Card card)
	{
	}

	private void OnPlayerDefuse(Player player)
	{
	}

	private void OnOpponentDefuse(Player player)
	{
	}

	private void OnDrawExplodingKitten(Player player, Card card)
	{
	}

	private void OnEndTurn(Player player)
	{
	}

	private void OnWin(Player player)
	{
	}

	public void CancelCountdown()
	{
	}
}
