using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Sets whether a Game Object's Rigidbody is affected by Gravity.")]
	public class UseGravity : ComponentAction<Rigidbody>
	{
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("A Game Object with a RigidBody component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("Enable/disable gravity for the Game Object.")]
		public FsmBool useGravity;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoUseGravity()
		{
		}
	}
}
