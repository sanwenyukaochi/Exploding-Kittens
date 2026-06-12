using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Destroys a Component of an Object.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class DestroyComponent : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject that owns the Component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[UIHint(UIHint.ScriptComponent)]
		[Tooltip("The name of the Component to destroy.")]
		public FsmString component;

		private Component aComponent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoDestroyComponent(GameObject go)
		{
		}
	}
}
