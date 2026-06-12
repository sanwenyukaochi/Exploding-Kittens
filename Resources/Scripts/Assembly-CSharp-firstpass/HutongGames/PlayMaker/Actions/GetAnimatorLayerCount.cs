using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Returns the Animator controller layer count")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorLayerCount : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The Animator controller layer count")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		[ActionSection("Results")]
		public FsmInt layerCount;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
