using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Gets the 2D Position of a GameObject and stores it in a Vector2 Variable or each Axis in a Float Variable")]
	public class GetPosition2d : ComponentAction<Transform>
	{
		[Tooltip("The game object to examine.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Title("Vector2")]
		[Tooltip("Store the position in a Vector2 Variable.")]
		public FsmVector2 vector_2d;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the X coordinate in a Float Variable.")]
		public FsmFloat x;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the Y coordinate in a Float Variable.")]
		public FsmFloat y;

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
