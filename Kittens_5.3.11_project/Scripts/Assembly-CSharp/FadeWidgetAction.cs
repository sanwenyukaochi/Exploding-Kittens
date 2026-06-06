public class FadeWidgetAction : ActionBase
{
	public UIWidget Widget;

	public float StartAlpha;

	public float EndAlpha;

	public float AnimationTime;

	public float Delay;

	public iTween.EaseType EaseType;

	public override void Act()
	{
	}

	private void TweenAlpha(float alpha)
	{
	}
}
