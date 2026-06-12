using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics2D)]
	[Tooltip("Tests if a Game Object's Rigidbody 2D is sleeping.")]
	public class IsSleeping2d : ComponentAction<Rigidbody2D>
	{
		[RequiredField]
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		[CheckForComponent(typeof(Rigidbody2D))]
		public FsmOwnerDefault gameObject;

		[Tooltip("Event sent if sleeping")]
		public FsmEvent trueEvent;

		[Tooltip("Event sent if not sleeping")]
		public FsmEvent falseEvent;

		[Tooltip("Store the value in a Boolean variable")]
		[UIHint(UIHint.Variable)]
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

		private void DoIsSleeping()
		{
		}
	}
}
