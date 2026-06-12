using UnityEngine;

public class MoveToTransformAction : ActionBase
{
	public GameObject Target;

	public Transform Transform;

	public iTween.EaseType EaseType;

	public iTween.LoopType LoopType;

	public float Delay;

	public float AnimationTime;

	public bool IsLocal;

	public override void Act()
	{
	}
}
