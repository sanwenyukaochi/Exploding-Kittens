using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Forces a Game Object's Rigid Body 2D to wake up.")]
	[ActionCategory(ActionCategory.Physics2D)]
	public class WakeUp2d : ComponentAction<Rigidbody2D>
	{
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with a Rigidbody2d attached")]
		public FsmOwnerDefault gameObject;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoWakeUp()
		{
		}
	}
}
