namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets a Game Object's Name.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class SetName : FsmStateAction
	{
		[Tooltip("The Game Object to name.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The new name.")]
		public FsmString name;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetLayer()
		{
		}
	}
}
