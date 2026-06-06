using UnityEngine;

public class ResizeWidgetAction : ActionBase
{
	public UIWidget Widget;

	public Vector2 TargetSize;

	public float AnimationTime;

	public float Delay;

	public iTween.EaseType EaseType;

	private Vector2 WidgetSize => default(Vector2);

	public override void Act()
	{
	}

	private void TweenSize(Vector2 size)
	{
	}
}
