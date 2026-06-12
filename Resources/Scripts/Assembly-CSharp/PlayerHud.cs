using System.Collections.Generic;
using ExplodingKittensAI;
using UnityEngine;

public class PlayerHud : MonoBehaviour, IPlayerInterface
{
	public UIButton EndButton;

	public PlayerHudDisabler PlayerHudDisabler;

	public KittenMeter KittenMeter;

	public DrawFromBottomCardRemover DrawFromBottomCardRemover;

	public TurnDirectionIndicator TurnDirectionIndicator;

	public GameplayAnnouncer GameplayAnnouncer;

	public PlayerProvider PlayerProvider;

	public BombPlacementModal BombPlacementModal;

	public BuryPlacementModal BuryPlacementModal;

	public GameObject ChatButtonPanel;

	public AvatarGrid VictoryModalAvatarGrid;

	public GameObject RematchButton;

	public GameObject PlayerHandContainer;

	public NextDrawnCardProvider NextDrawnCardProvider;

	public GameMessages GameMessages;

	public GameObject AlertPanel;

	public PlayerHand PlayerHand;

	public UICamera UICamera;

	public GameObject TakeThatShowCard;

	public GameObject TakeThatShowDrawCard;

	public GameObject ShowBarking2Cards;

	public GameObject BuryShowCard;

	public GameObject TopCrown;

	public GameObject OpponentList;

	public List<CardAction> AIActions;

	private float AIDelayTimer;

	private float PressedTimer;

	public Player Player { get; set; }

	public void Initialize(Player player)
	{
	}

	public void Activate()
	{
	}

	public void Deactivate()
	{
	}

	private void OnPhaseChange(Player _, PlayerPhase phase)
	{
	}

	private HandCard FindCard(string name)
	{
		return null;
	}

	public void DoAI(bool clean = false)
	{
	}

	private void Update()
	{
	}
}
