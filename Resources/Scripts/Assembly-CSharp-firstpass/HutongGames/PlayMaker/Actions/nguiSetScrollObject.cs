namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Sets NGUI object to be draggable or not. This will automatically set up a drag object for you.")]
	public class nguiSetScrollObject : FsmStateAction
	{
		[UIHint(UIHint.Description)]
		public string des;

		[Tooltip("NGUI object to be draggable or not")]
		[RequiredField]
		public FsmOwnerDefault NguiObject;

		private bool isSet;

		private UIDragScrollView theScrollView;

		public UIScrollView.Movement moveSetting;

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
