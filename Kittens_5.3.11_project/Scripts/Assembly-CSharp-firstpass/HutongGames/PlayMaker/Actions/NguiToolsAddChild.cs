namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Add a child to a Ngui Element.")]
	[ActionCategory("NGUI Tools")]
	public class NguiToolsAddChild : FsmStateAction
	{
		[Tooltip("The Parent")]
		[RequiredField]
		public FsmOwnerDefault parent;

		[Tooltip("The GameObject to add")]
		[RequiredField]
		public FsmGameObject childReference;

		[UIHint(UIHint.Variable)]
		public FsmGameObject childInstance;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
