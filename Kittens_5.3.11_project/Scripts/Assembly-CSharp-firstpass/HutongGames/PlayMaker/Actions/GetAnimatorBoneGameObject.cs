using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Animator)]
	[Tooltip("Gets the GameObject mapped to this human bone id")]
	public class GetAnimatorBoneGameObject : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[ObjectType(typeof(HumanBodyBones))]
		[Tooltip("The bone reference")]
		public FsmEnum bone;

		[ActionSection("Results")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The Bone's GameObject")]
		public FsmGameObject boneGameObject;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
