using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Tests if a Game Object's Rigid Body 2D is Kinematic.")]
	public class IsKinematic2d : ComponentAction<Rigidbody2D>
	{
		[Tooltip("the GameObject with a Rigidbody2D attached")]
		[CheckForComponent(typeof(Rigidbody2D))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Event Sent if Kinematic")]
		public FsmEvent trueEvent;

		[Tooltip("Event sent if not Kinematic")]
		public FsmEvent falseEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the Kinematic state")]
		public FsmBool store;

		[Tooltip("Repeat every frame")]
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

		private void DoIsKinematic()
		{
		}
	}
}
