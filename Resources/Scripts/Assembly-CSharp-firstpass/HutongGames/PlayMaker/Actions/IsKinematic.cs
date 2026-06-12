using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Tests if a rigid body is controlled by physics. See unity docs: <a href=\"http://unity3d.com/support/documentation/ScriptReference/Rigidbody-isKinematic.html\">IsKinematic</a>.")]
	[ActionCategory(ActionCategory.Physics)]
	public class IsKinematic : ComponentAction<Rigidbody>
	{
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("The game object to test.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Event sent if it is kinematic (not controlled by physics).")]
		public FsmEvent trueEvent;

		[Tooltip("Event sent if it is not kinematic (controlled by physics).")]
		public FsmEvent falseEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in a Bool Variable")]
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

		private void DoIsKinematic()
		{
		}
	}
}
