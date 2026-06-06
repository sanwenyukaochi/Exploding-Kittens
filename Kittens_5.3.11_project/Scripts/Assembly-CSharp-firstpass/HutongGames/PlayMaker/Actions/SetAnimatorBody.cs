using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the position and rotation of the body. A GameObject can be set to control the position and rotation, or it can be manually expressed.")]
	[ActionCategory(ActionCategory.Animator)]
	public class SetAnimatorBody : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The GameObject with an Animator Component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The gameObject target of the ik goal")]
		public FsmGameObject target;

		[Tooltip("The position of the ik goal. If Goal GameObject set, position is used as an offset from Goal")]
		public FsmVector3 position;

		[Tooltip("The rotation of the ik goal.If Goal GameObject set, rotation is used as an offset from Goal")]
		public FsmQuaternion rotation;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private GameObject cachedTarget;

		private Transform _transform;

		private Animator animator => null;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void DoAnimatorIK(int layerIndex)
		{
		}

		private void DoSetBody()
		{
		}
	}
}
