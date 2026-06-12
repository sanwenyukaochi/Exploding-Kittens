using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the color of a sprite renderer")]
	[ActionCategory(ActionCategory.SpriteRenderer)]
	public class GetSpriteColor : ComponentAction<SpriteRenderer>
	{
		[Tooltip("The GameObject with the SpriteRenderer component.")]
		[CheckForComponent(typeof(SpriteRenderer))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Get The Color of the SpriteRenderer component")]
		public FsmColor color;

		[Tooltip("Store the red channel in a float variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat red;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the green channel in a float variable.")]
		public FsmFloat green;

		[Tooltip("Store the blue channel in a float variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat blue;

		[Tooltip("Store the alpha channel in a float variable.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat alpha;

		[Tooltip("Repeat every frame. Useful if the color variable is changing.")]
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

		private void GetColor()
		{
		}
	}
}
