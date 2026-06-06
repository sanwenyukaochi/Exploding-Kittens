using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets The degree to which this object is affected by gravity.  NOTE: Game object must have a rigidbody 2D.")]
	[ActionCategory(ActionCategory.Physics2D)]
	public class SetGravity2dScale : ComponentAction<Rigidbody2D>
	{
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with a Rigidbody 2d attached")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The gravity scale effect")]
		public FsmFloat gravityScale;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetGravityScale()
		{
		}
	}
}
