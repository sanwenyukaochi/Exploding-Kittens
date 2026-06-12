namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the number of Touches.")]
	[ActionCategory(ActionCategory.Device)]
	public class GetTouchCount : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the current number of touches in an Int Variable.")]
		public FsmInt storeCount;

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

		private void DoGetTouchCount()
		{
		}
	}
}
