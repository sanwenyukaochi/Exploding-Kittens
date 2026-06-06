using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Returns true if a parameter is controlled by an additional curve on an animation")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorIsParameterControlledByCurve : ComponentAction<Animator>
	{
		[CheckForComponent(typeof(Animator))]
		[RequiredField]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The parameter's name")]
		public FsmString parameterName;

		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("True if controlled by curve")]
		public FsmBool isControlledByCurve;

		[Tooltip("Event send if controlled by curve")]
		public FsmEvent isControlledByCurveEvent;

		[Tooltip("Event send if not controlled by curve")]
		public FsmEvent isNotControlledByCurveEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
