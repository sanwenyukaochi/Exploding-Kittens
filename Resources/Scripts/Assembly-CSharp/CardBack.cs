using UnityEngine;

public class CardBack : MonoBehaviour
{
	public GameObject CardBackTexture;

	public GameObject MarkCardTexture;

	[Header("Widgets")]
	public UIWidget[] ReorderableWidgets;

	public UIWidget[] WidgetsOnTopOfCard;

	public UIWidget GlowWidget;

	public UIWidget[] ResizableWidgets;

	[Header("Delegated Actions")]
	public ResizeWidgetAction[] ResizeWidgetActions;

	public MovementAction MoveAction;

	public RotationAction RotationAction;

	public ScaleAction ScaleAction;

	public BoxCollider CardBoxCollider;

	public ActionBase StartDragAction;

	public ActionBase EndDragAction;

	public CardBackEvent OnTapped;

	public PlayMakerFSM DiarrheaFsm;

	public PlayMakerFSM DisguisingFsm;

	public Card Card;

	public int LayerCount;

	private Player player;

	private int storeddepth;

	public void Initialize(Vector2 initialCardSize)
	{
	}

	public void AttachToCard(Player _player, Card card)
	{
	}

	public void OnDestroy()
	{
	}

	public void OnMarked(Card _)
	{
	}

	public void OnUnMarked(Card _)
	{
	}

	private void MarkScaleUpComplete()
	{
	}

	private void MarkScaleDownComplete()
	{
	}

	public void OnSprayedWithDiarrhea(Card _)
	{
	}

	public void OnDiarrheaWiped(Card _)
	{
	}

	private void Disguise(Card card)
	{
	}

	private void ShedDisguise(Card card)
	{
	}

	public void ScaleTo(Vector3 scale)
	{
	}

	public void MoveTo(Vector3 localPosition, Vector3 localRotation)
	{
	}

	public void ResizeCard(Vector2 cardSize)
	{
	}

	public void SetDepth(int depth)
	{
	}

	public void Remove()
	{
	}

	public void MakeDrawable()
	{
	}

	public void MakeUndrawable()
	{
	}

	private void OnDragStart()
	{
	}

	private void OnPress(bool isDown)
	{
	}

	private void OnClick()
	{
	}
}
