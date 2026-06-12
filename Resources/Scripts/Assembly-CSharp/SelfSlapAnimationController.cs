using UnityEngine;

public class SelfSlapAnimationController : MonoBehaviour
{
	public SlapAnimationController SlapAnimationController;

	public string SelfSlapSoundName;

	private bool shouldPlaySelfSlapSound;

	public void Start()
	{
	}

	private void OnPlayCard(Player _, Card card)
	{
	}

	private void OnSlapAnimationComplete()
	{
	}
}
