using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Use a low pass filter to reduce the influence of sudden changes in a Vector3 Variable. Useful when working with Get Device Acceleration to isolate gravity.")]
	[ActionCategory(ActionCategory.Vector3)]
	public class Vector3LowPassFilter : FsmStateAction
	{
		[Tooltip("Vector3 Variable to filter. Should generally come from some constantly updated input, e.g., acceleration.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmVector3 vector3Variable;

		[Tooltip("Determines how much influence new changes have. E.g., 0.1 keeps 10 percent of the unfiltered vector and 90 percent of the previously filtered value.")]
		public FsmFloat filteringFactor;

		private Vector3 filteredVector;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
