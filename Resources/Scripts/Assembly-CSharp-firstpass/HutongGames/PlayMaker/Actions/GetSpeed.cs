using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the Speed of a Game Object and stores it in a Float Variable. NOTE: The Game Object must have a RigidBody component.")]
	[ActionCategory(ActionCategory.Physics)]
	public class GetSpeed : ComponentAction<Rigidbody>
	{
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("The GameObject with a RigidBody component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("Store the speed in a float variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeResult;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetSpeed()
		{
		}
	}
}
