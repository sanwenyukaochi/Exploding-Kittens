using UnityEngine;

public class MoveThroughWaypointsAction : ActionBase
{
	public GameObject Target;

	public Transform[] Waypoints;

	public iTween.EaseType EaseType;

	public iTween.LoopType LoopType;

	public float Delay;

	public float AnimationTime;

	public bool IsLocal;

	public bool MoveToPath;

	public bool OrientToPath;

	public float LookAheadPercentage;

	public override void Act()
	{
	}
}
