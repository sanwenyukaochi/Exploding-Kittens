using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Tests if a rigid body is sleeping. See Unity docs: <a href=\"http://unity3d.com/support/documentation/Components/RigidbodySleeping.html\">Rigidbody Sleeping</a>.")]
	[ActionCategory(ActionCategory.Physics)]
	public class IsSleeping : ComponentAction<Rigidbody>
	{
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("The game object to test.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Event to send if sleeping.")]
		public FsmEvent trueEvent;

		[Tooltip("Event to send if not sleeping.")]
		public FsmEvent falseEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Bool Variable.")]
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

		private void DoIsSleeping()
		{
		}
	}
}
