using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Creates a Game Object, usually using a Prefab.")]
	[ActionTarget(typeof(GameObject), "gameObject", true)]
	[ActionCategory(ActionCategory.GameObject)]
	public class CreateObject : FsmStateAction
	{
		[RequiredField]
		[Tooltip("GameObject to create. Usually a Prefab.")]
		public FsmGameObject gameObject;

		[Tooltip("Optional Parent.")]
		public FsmGameObject parent;

		[Tooltip("Optional Spawn Point.")]
		public FsmGameObject spawnPoint;

		[Tooltip("Position. If a Spawn Point is defined, this is used as a local offset from the Spawn Point position.")]
		public FsmVector3 position;

		[Tooltip("Rotation. NOTE: Overrides the rotation of the Spawn Point.")]
		public FsmVector3 rotation;

		[UIHint(UIHint.Variable)]
		[Tooltip("Optionally store the created object.")]
		public FsmGameObject storeObject;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
