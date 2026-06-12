using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Connect a joint to a game object.")]
	public class SetJointConnectedBody : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The joint to connect. Requires a Joint component.")]
		[CheckForComponent(typeof(Joint))]
		public FsmOwnerDefault joint;

		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("The game object to connect to the Joint. Set to none to connect the Joint to the world.")]
		public FsmGameObject rigidBody;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
