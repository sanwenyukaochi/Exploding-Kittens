using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Use a low pass filter to reduce the influence of sudden changes in a quaternion Variable.")]
	[ActionCategory(ActionCategory.Quaternion)]
	public class QuaternionLowPassFilter : QuaternionBaseAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("quaternion Variable to filter. Should generally come from some constantly updated input")]
		[RequiredField]
		public FsmQuaternion quaternionVariable;

		[Tooltip("Determines how much influence new changes have. E.g., 0.1 keeps 10 percent of the unfiltered quaternion and 90 percent of the previously filtered value.")]
		public FsmFloat filteringFactor;

		private Quaternion filteredQuaternion;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnLateUpdate()
		{
		}

		public override void OnFixedUpdate()
		{
		}

		private void DoQuatLowPassFilter()
		{
		}
	}
}
