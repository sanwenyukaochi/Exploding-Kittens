using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Returns the feet pivot. At 0% blending point is body mass center. At 100% blending point is feet pivot")]
	public class GetAnimatorFeetPivotActive : ComponentAction<Animator>
	{
		[Tooltip("The GameObject with an Animator Component.")]
		[CheckForComponent(typeof(Animator))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The feet pivot Blending. At 0% blending point is body mass center. At 100% blending point is feet pivot")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmFloat feetPivotActive;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
