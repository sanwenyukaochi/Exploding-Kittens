using UnityEngine;

public class RandomRotationAction : ActionBase
{
	public Vector3 MinRotation;

	public Vector3 MaxRotation;

	private Vector3 RandomRotation => default(Vector3);

	public override void Act()
	{
	}
}
