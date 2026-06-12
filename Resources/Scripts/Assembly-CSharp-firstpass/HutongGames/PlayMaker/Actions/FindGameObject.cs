namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GameObject)]
	[Tooltip("Finds a Game Object by Name and/or Tag.")]
	public class FindGameObject : FsmStateAction
	{
		[Tooltip("The name of the GameObject to find. You can leave this empty if you specify a Tag.")]
		public FsmString objectName;

		[Tooltip("Find a GameObject with this tag. If Object Name is specified then both name and Tag must match.")]
		[UIHint(UIHint.Tag)]
		public FsmString withTag;

		[RequiredField]
		[Tooltip("Store the result in a GameObject variable.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject store;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void Find()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
