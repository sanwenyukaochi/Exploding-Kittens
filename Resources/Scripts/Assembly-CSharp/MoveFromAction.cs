using UnityEngine;

public class MoveFromAction : ActionBase
{
	public GameObject Target;

	public Vector3 TargetPosition;

	public iTween.EaseType EaseType;

	public iTween.LoopType LoopType;

	public float Delay;

	public float AnimationTime;

	public bool isLocal;

	public override void Act()
	{
	}
}
