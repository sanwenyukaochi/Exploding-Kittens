using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Is the rigidbody2D constrained from rotating? Note: Prefer SetRigidBody2dConstraints when working in Unity 5 or higher.")]
	[ActionCategory(ActionCategory.Physics2D)]
	public class IsFixedAngle2d : ComponentAction<Rigidbody2D>
	{
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Event sent if the Rigidbody2D does have fixed angle")]
		public FsmEvent trueEvent;

		[Tooltip("Event sent if the Rigidbody2D doesn't have fixed angle")]
		public FsmEvent falseEvent;

		[Tooltip("Store the fixedAngle flag")]
		[UIHint(UIHint.Variable)]
		public FsmBool store;

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

		private void DoIsFixedAngle()
		{
		}
	}
}
