using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Returns the scale of the current Avatar for a humanoid rig, (1 by default if the rig is generic).\n The scale is relative to Unity's Default Avatar")]
	public class GetAnimatorHumanScale : ComponentAction<Animator>
	{
		[RequiredField]
		[Tooltip("The GameObject with an Animator Component.")]
		[CheckForComponent(typeof(Animator))]
		public FsmOwnerDefault gameObject;

		[ActionSection("Result")]
		[Tooltip("the scale of the current Avatar")]
		[UIHint(UIHint.Variable)]
		public FsmFloat humanScale;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
