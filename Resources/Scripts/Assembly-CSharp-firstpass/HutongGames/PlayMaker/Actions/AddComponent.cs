using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Adds a Component to a Game Object. Use this to change the behaviour of objects on the fly. Optionally remove the Component on exiting the state.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class AddComponent : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject to add the Component to.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Title("Component Type")]
		[Tooltip("The type of Component to add to the Game Object.")]
		[UIHint(UIHint.ScriptComponent)]
		public FsmString component;

		[UIHint(UIHint.Variable)]
		[ObjectType(typeof(Component))]
		[Tooltip("Store the component in an Object variable. E.g., to use with Set Property.")]
		public FsmObject storeComponent;

		[Tooltip("Remove the Component when this State is exited.")]
		public FsmBool removeOnExit;

		private Component addedComponent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnExit()
		{
		}

		private void DoAddComponent()
		{
		}
	}
}
