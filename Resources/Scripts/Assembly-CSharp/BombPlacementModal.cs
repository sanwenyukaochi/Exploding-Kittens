using UnityEngine;

public class BombPlacementModal : MonoBehaviour
{
	public WindowTransitioner WindowTransitioner;

	public CallbackAction CallbackAction;

	public GameMessages GameMessages;

	public BombPlacementButtonList BombPlacementButtonList;

	public BombPlacementOptionsProvider BombPlacementOptionsProvider;

	public UIButton PlaceButton;

	public Countdown Countdown;

	public PlayerProvider PlayerProvider;

	public CatPawCountdownFactory CatPawCountdownFactory;

	public TurnQueue TurnQueue;

	public TurnQueueAuthority TurnQueueAuthority;

	private int lastSelected;

	private Card lastKittenDrawn;

	private bool bombPlaced;

	private int RandomPlacement => 0;

	private Player Player => null;

	public void Initialize()
	{
	}

	public void OnDrawExplodingKitten(Player _, Card card)
	{
	}

	public void JustPutTheBombOnTheTop()
	{
	}

	public void DelayPlaceBombOnTop()
	{
	}

	private void BombPlaced()
	{
	}

	public void PlaceBombAt(int index)
	{
	}

	public void Show()
	{
	}

	private void OnChosen(int numberDown)
	{
	}

	private void OnSubmit()
	{
	}

	private void OnCountdownEnded()
	{
	}

	private void SendBombAndHide(int bombPlacement)
	{
	}
}
