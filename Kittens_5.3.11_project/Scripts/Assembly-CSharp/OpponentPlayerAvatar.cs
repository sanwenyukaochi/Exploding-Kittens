using System.Collections.Generic;
using UnityEngine;

public class OpponentPlayerAvatar : MonoBehaviour
{
	public UILabel NameLabel;

	public UISprite IconSprite;

	public SpringyButton MuteButton;

	public GameObject MuteButtonGroup;

	public PlayerProvider PlayerProvider;

	public DrawPileProvider DrawPileProvider;

	public DiscardPileProvider DiscardPileProvider;

	public PlayerDelegate OnSelected;

	public ActionBase ShowArrowAction;

	public ActionBase HideArrowAction;

	public ActionBase SelectAvatarAction;

	public ActionBase DeselectAvatarAction;

	public SlapAnimationController SlapAnimationController;

	public List<CardCategory> CategoriesThatRequireCleanCards;

	public GameObject Sparks;

	public IconController IconController;

	public GameObject Hand;

	private bool isInSelectionMode;

	private const float DISABLED_ALPHA = 0.2f;

	private const float ENABLED_ALPHA = 1f;

	private Player player;

	public void Initialize(Player player, DiscardPile discardPile, DrawPile drawPile)
	{
	}

	private void OnDestroy()
	{
	}

	private void OnFlaggedStateChange(Player _)
	{
	}

	public void Select()
	{
	}

	public void EnterSelectionMode(Card card)
	{
	}

	public void ExitSelectionMode()
	{
	}
}
