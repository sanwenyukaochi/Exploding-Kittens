using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Gets the Position of a Game Object and stores it in a Vector3 Variable or each Axis in a Float Variable")]
	public class GetPosition : ComponentAction<Transform>
	{
		[RequiredField]
		[Tooltip("The game object to examine.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Store the position in a Vector3 Variable.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 vector;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the X coordinate in a Float Variable.")]
		public FsmFloat x;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the Y coordinate in a Float Variable.")]
		public FsmFloat y;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the Z coordinate in a Float Variable.")]
		public FsmFloat z;

		[Tooltip("Use world or local coordinates.")]
		public Space space;

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

		private void DoGetPosition()
		{
		}
	}
}
