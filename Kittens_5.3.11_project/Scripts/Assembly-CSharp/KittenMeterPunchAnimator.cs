public class KittenMeterPunchAnimator : KittenMeterAnimator
{
	public PunchAction RegularPunchAction;

	public PunchAction ExtremePunchAction;

	private const float extremePunchThreshold = 0.2f;

	public override void Animate(float chanceToExplode)
	{
	}
}
