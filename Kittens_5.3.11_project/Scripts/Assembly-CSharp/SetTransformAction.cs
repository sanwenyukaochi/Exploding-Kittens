using UnityEngine;

public class SetTransformAction : ActionBase
{
	public GameObject Target;

	public Vector3 Position;

	public Vector3 Rotation;

	public Vector3 Scale;

	public bool IsLocal;

	public override void Act()
	{
	}
}
