using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Sets the Position of a Game Object. To leave any axis unchanged, set variable to 'None'.")]
	public class SetPosition : ComponentAction<Transform>
	{
		[RequiredField]
		[Tooltip("The Game Object to position.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Use a stored Vector3 position, and/or set individual axis below.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector;

		[Tooltip("Set the X position.")]
		public FsmFloat x;

		[Tooltip("Set the Y position.")]
		public FsmFloat y;

		[Tooltip("Set the Z position.")]
		public FsmFloat z;

		[Tooltip("Set position in local (relative to parent) or world space.")]
		public Space space;

		[Tooltip("Perform this action every frame. Useful if position is changing.")]
		public bool everyFrame;

		[Tooltip("Perform in LateUpdate. This is useful if you want to override the position of objects that are animated or otherwise positioned in Update.")]
		public bool lateUpdate;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnLateUpdate()
		{
		}

		private void DoSetPosition()
		{
		}
	}
}
