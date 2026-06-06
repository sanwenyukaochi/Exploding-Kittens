using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the position, rotation and weights of an IK goal. A GameObject can be set to control the position and rotation, or it can be manually expressed.")]
	[ActionCategory(ActionCategory.Animator)]
	public class SetAnimatorIKGoal : ComponentAction<Animator>
	{
		[RequiredField]
		[CheckForComponent(typeof(Animator))]
		[Tooltip("The target.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The IK goal")]
		public AvatarIKGoal iKGoal;

		[Tooltip("The gameObject target of the ik goal")]
		public FsmGameObject goal;

		[Tooltip("The position of the ik goal. If Goal GameObject set, position is used as an offset from Goal")]
		public FsmVector3 position;

		[Tooltip("The rotation of the ik goal.If Goal GameObject set, rotation is used as an offset from Goal")]
		public FsmQuaternion rotation;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("The translative weight of an IK goal (0 = at the original animation before IK, 1 = at the goal)")]
		public FsmFloat positionWeight;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("Sets the rotational weight of an IK goal (0 = rotation before IK, 1 = rotation at the IK goal)")]
		public FsmFloat rotationWeight;

		[Tooltip("Repeat every frame. Useful when changing over time.")]
		public bool everyFrame;

		private GameObject cachedGoal;

		private Transform _transform;

		private Animator animator => null;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnEnter()
		{
		}

		public override void DoAnimatorIK(int layerIndex)
		{
		}

		private void DoSetIKGoal()
		{
		}
	}
}
