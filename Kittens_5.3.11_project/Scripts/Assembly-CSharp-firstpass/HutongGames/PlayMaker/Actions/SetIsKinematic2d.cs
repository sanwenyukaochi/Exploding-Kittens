using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Controls whether 2D physics affects the Game Object.")]
	[ActionCategory(ActionCategory.Physics2D)]
	public class SetIsKinematic2d : ComponentAction<Rigidbody2D>
	{
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody2D))]
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The isKinematic value")]
		public FsmBool isKinematic;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetIsKinematic()
		{
		}
	}
}
