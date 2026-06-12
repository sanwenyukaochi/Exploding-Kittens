public class KittenMeterReadoutAnimator : KittenMeterAnimator
{
	public DeckStats DeckStats;

	public VisibleKittenDetector VisibleKittenDetector;

	public NumberAnimationAction NumberAnimationAction;

	private int lastPercentage;

	public override void Animate(float chanceToExplode)
	{
	}

	private void AnimatePercentage(int startValue, int endValue)
	{
	}
}
