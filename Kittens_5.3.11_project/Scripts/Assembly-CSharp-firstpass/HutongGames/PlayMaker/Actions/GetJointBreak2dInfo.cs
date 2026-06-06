using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets info on the last joint break 2D event.")]
	[ActionCategory(ActionCategory.Physics2D)]
	public class GetJointBreak2dInfo : FsmStateAction
	{
		[Tooltip("Get the broken joint.")]
		[ObjectType(typeof(Joint2D))]
		[UIHint(UIHint.Variable)]
		public FsmObject brokenJoint;

		[UIHint(UIHint.Variable)]
		[Tooltip("Get the reaction force exerted by the broken joint. Unity 5.3+")]
		public FsmVector2 reactionForce;

		[UIHint(UIHint.Variable)]
		[Tooltip("Get the magnitude of the reaction force exerted by the broken joint. Unity 5.3+")]
		public FsmFloat reactionForceMagnitude;

		[Tooltip("Get the reaction torque exerted by the broken joint. Unity 5.3+")]
		[UIHint(UIHint.Variable)]
		public FsmFloat reactionTorque;

		public override void Reset()
		{
		}

		private void StoreInfo()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
