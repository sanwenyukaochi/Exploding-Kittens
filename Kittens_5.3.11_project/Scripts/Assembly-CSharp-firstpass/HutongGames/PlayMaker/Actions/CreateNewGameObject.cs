namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Creates a new GameObject.\nUse a GameObject and/or Position/Rotation for the Spawn Point. If you specify a Game Object, Position is used as a local offset, and Rotation will override the object's rotation.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class CreateNewGameObject : FsmStateAction
	{
		[Tooltip("Name of the new GameObject")]
		public FsmString name;

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
