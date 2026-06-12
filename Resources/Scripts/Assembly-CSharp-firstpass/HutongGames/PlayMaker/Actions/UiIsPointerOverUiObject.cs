namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Checks if Pointer is over a UI object, optionally takes a pointer ID, otherwise uses the current event.")]
	public class UiIsPointerOverUiObject : FsmStateAction
	{
		[Tooltip("Optional PointerId. Leave as None to use the current event")]
		public FsmInt pointerId;

		[Tooltip("Event to send when the Pointer is over an UI object.")]
		public FsmEvent pointerOverUI;

		[Tooltip("Event to send when the Pointer is NOT over an UI object.")]
		public FsmEvent pointerNotOverUI;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store if the pointer is over a UI object in a Bool variable.")]
		public FsmBool isPointerOverUI;

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

		private void DoCheckPointer()
		{
		}
	}
}
