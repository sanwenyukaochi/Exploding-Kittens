using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Scene)]
	[Tooltip("Move a GameObject from its current scene to a new scene. It is required that the GameObject is at the root of its current scene.")]
	public class MoveGameObjectToScene : GetSceneActionBase
	{
		[Tooltip("The Root GameObject to move to the referenced scene")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("Only root GameObject can be moved, set to true to get the root of the gameobject if necessary, else watch for failure events.")]
		public FsmBool findRootIfNecessary;

		[Tooltip("True if the merge succeeded")]
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmBool success;

		[Tooltip("Event sent if merge succeeded")]
		public FsmEvent successEvent;

		[Tooltip("Event sent if merge failed. Check log for information")]
		public FsmEvent failureEvent;

		private GameObject _go;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
