using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Checks if an Object has a Component. Optionally remove the Component on exiting the state.")]
	public class HasComponent : FsmStateAction
	{
		[Tooltip("The Game Object to check.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[UIHint(UIHint.ScriptComponent)]
		[Tooltip("The name of the component to check for.")]
		public FsmString component;

		[Tooltip("Remove the component on exiting the state.")]
		public FsmBool removeOnExit;

		[Tooltip("Event to send if the Game Object has the component.")]
		public FsmEvent trueEvent;

		[Tooltip("Event to send if the Game Object does not have the component.")]
		public FsmEvent falseEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a bool variable.")]
		public FsmBool store;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private Component aComponent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnExit()
		{
		}

		private void DoHasComponent(GameObject go)
		{
		}
	}
}
