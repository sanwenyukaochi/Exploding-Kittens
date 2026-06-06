using UnityEngine;

public class ScrollMaterialOffsetAction : ActionBase
{
	public Renderer Renderer;

	public Vector2 Offset;

	public float AnimationTime;

	public iTween.EaseType EaseType;

	public iTween.LoopType LoopType;

	public override void Act()
	{
	}

	private void Animate()
	{
	}

	private void TweenOffset(Vector2 offset)
	{
	}
}
