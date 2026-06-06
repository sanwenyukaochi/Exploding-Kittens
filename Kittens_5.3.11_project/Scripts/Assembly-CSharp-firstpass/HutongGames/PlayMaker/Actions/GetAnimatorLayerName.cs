using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Returns the name of a layer from its index")]
	[ActionCategory(ActionCategory.Animator)]
	public class GetAnimatorLayerName : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The layer index")]
		public FsmInt layerIndex;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The layer name")]
		[ActionSection("Results")]
		public FsmString layerName;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
