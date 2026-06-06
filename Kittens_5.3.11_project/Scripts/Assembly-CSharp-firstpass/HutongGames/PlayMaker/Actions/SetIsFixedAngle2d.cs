using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Controls whether the rigidbody 2D should be prevented from rotating")]
	[ActionCategory(ActionCategory.Physics2D)]
	[Obsolete("This action is obsolete; use Constraints instead.")]
	public class SetIsFixedAngle2d : ComponentAction<Rigidbody2D>
	{
		[Tooltip("The GameObject with the Rigidbody2D attached")]
		[CheckForComponent(typeof(Rigidbody2D))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The flag value")]
		public FsmBool isFixedAngle;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoSetIsFixedAngle()
		{
		}
	}
}
