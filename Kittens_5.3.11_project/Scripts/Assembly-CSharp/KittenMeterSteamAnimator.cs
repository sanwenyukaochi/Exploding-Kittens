using UnityEngine;

public class KittenMeterSteamAnimator : KittenMeterAnimator
{
	private const float threshold = 0.3f;

	public ParticleSystem SmokePuffs;

	public string SteamJukeboxSoundName;

	private ObservableBool isAnimating;

	private void Awake()
	{
	}

	public override void Animate(float chanceToExplode)
	{
	}

	private void OnAnimationToggle(ObservableBool _)
	{
	}

	private void StartSteaming()
	{
	}

	private void StopSteaming()
	{
	}
}
