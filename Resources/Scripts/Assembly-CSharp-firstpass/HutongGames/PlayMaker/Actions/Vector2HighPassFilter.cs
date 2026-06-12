using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector2)]
	[Tooltip("Use a high pass filter to isolate sudden changes in a Vector2 Variable.")]
	public class Vector2HighPassFilter : FsmStateAction
	{
		[Tooltip("Vector2 Variable to filter. Should generally come from some constantly updated input.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmVector2 vector2Variable;

		[Tooltip("Determines how much influence new changes have.")]
		public FsmFloat filteringFactor;

		private Vector2 filteredVector;

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
