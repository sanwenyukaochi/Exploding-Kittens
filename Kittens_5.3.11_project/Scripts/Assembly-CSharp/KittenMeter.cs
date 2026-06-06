using UnityEngine;

public class KittenMeter : MonoBehaviour
{
	[Header("Data Sources")]
	public DeckStats DeckStats;

	public VisibleKittenDetector VisibleKittenDetector;

	[Header("Animators")]
	public KittenMeterBeanAnimator KittenMeterBeanAnimator;

	public KittenMeterAnimator[] KittenMeterAnimators;

	public void Initialize()
	{
	}

	private void OnChangeDeckStats(DeckStats deckStats)
	{
	}

	private void OnKittenVisibiltyChanged(bool isVisible)
	{
	}

	private void AnimateMeter()
	{
	}
}
