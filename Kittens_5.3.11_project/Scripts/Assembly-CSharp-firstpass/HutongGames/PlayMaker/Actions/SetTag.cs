namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets a Game Object's Tag.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class SetTag : FsmStateAction
	{
		[Tooltip("The Game Object to set.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Tag)]
		[Tooltip("The tag. Note: Use Unity's <a href=\"http://unity3d.com/support/documentation/Components/class-TagManager.html\">Tag Manager</a> to add/edit tags.")]
		public FsmString tag;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
