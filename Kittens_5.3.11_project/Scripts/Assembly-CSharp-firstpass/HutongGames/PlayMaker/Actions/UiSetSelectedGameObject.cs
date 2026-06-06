namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the EventSystem's currently select GameObject.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiSetSelectedGameObject : FsmStateAction
	{
		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("The GameObject to select.")]
		public FsmGameObject gameObject;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetSelectedGameObject()
		{
		}
	}
}
