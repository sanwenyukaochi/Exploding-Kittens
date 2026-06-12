using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Adds a 2d torque (rotational force) to a Game Object.")]
	[ActionCategory(ActionCategory.Physics2D)]
	public class AddTorque2d : ComponentAction<Rigidbody2D>
	{
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject to add torque to.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Option for applying the force")]
		public ForceMode2D forceMode;

		[Tooltip("Torque")]
		public FsmFloat torque;

		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		public override void OnPreprocess()
		{
		}

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnFixedUpdate()
		{
		}

		private void DoAddTorque()
		{
		}
	}
}
