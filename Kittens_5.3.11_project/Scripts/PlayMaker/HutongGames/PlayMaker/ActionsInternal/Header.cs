namespace HutongGames.PlayMaker.ActionsInternal
{
	[Tooltip("Large header used to organize actions list. Double-click to edit.")]
	[ActionCategory(ActionCategory.PlayMakerInternal)]
	public class Header : FsmStateAction
	{
		[UIHint(UIHint.Comment)]
		public string comment;

		public int colorId;

		public override void Reset()
		{
		}

		public override void Awake()
		{
		}
	}
}
