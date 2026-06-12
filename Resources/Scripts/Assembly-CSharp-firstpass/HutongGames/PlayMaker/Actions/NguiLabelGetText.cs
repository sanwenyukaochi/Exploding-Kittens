namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the text of a Ngui Label")]
	[ActionCategory("NGUI")]
	public class NguiLabelGetText : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject on which there is a UILabel")]
		[CheckForComponent(typeof(UILabel))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The label")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString text;

		[Tooltip("Repeat every frame while the state is active. Useful to get the text over time")]
		public bool everyFrame;

		private UILabel _label;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void GetText()
		{
		}
	}
}
