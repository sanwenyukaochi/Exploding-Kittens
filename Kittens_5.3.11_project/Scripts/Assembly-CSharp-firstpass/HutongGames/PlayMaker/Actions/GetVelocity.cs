using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Gets the Velocity of a Game Object and stores it in a Vector3 Variable or each Axis in a Float Variable. NOTE: The Game Object must have a Rigid Body.")]
	public class GetVelocity : ComponentAction<Rigidbody>
	{
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("The Game Object.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the velocity in a Vector3 Variable.")]
		public FsmVector3 vector;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the X component of the velocity in a Float Variable.")]
		public FsmFloat x;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the Y component of the velocity in a Float Variable.")]
		public FsmFloat y;

		[Tooltip("Store the Z component of the velocity in a Float Variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat z;

		[Tooltip("The coordinate space to get the velocity in.")]
		public Space space;

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

		private void DoGetVelocity()
		{
		}
	}
}
