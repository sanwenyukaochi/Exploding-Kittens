using UnityEngine;

public class ScaleAction : ActionBase
{
	public GameObject Target;

	public Vector3 TargetScale;

	public iTween.EaseType EaseType;

	public iTween.LoopType LoopType;

	public float Delay;

	public float AnimationTime;

	public override void Act()
	{
	}
}
