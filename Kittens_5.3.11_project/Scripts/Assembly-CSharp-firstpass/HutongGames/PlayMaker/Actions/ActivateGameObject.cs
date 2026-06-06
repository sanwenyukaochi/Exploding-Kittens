using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Activates/deactivates a Game Object. Use this to hide/show areas, or enable/disable many Behaviours at once.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class ActivateGameObject : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Game Object to activate/deactivate.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("Check to activate, uncheck to deactivate Game Object.")]
		public FsmBool activate;

		[Tooltip("Recursively activate/deactivate all children.")]
		public FsmBool recursive;

		[Tooltip("Reset the Game Object's active state when exiting this state. Useful if you want an object to be active only while this state is active.\nNote: Only applies to the last Game Object activated/deactivated (won't work if Game Object changes).")]
		public bool resetOnExit;

		[Tooltip("Repeat this action every frame. Useful if using a variable for Activate that can change over time.")]
		public bool everyFrame;

		private GameObject activatedGameObject;

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

		private void DoActivateGameObject()
		{
		}

		public void SetActiveRecursively(GameObject go, bool state)
		{
		}
	}
}
