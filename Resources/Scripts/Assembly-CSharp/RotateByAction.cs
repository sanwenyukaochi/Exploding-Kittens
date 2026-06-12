using UnityEngine;

public class RotateByAction : ActionBase
{
	public GameObject Target;

	public Vector3 TargetRotation;

	public iTween.EaseType EaseType;

	public iTween.LoopType LoopType;

	public bool IsLocal;

	public float Delay;

	public float AnimationTime;

	public override void Act()
	{
	}
}
