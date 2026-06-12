using UnityEngine;

public class SpawnGameObjectAction : ActionBase
{
	public GameObject prefab;

	public bool attachToSelf;

	public bool isTemporary;

	public float lifespan;

	public override void Act()
	{
	}
}
