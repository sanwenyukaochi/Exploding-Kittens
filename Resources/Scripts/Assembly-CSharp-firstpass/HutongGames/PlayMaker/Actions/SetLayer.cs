namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets a Game Object's Layer.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class SetLayer : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The Game Object to set.")]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Layer)]
		[Tooltip("The new layer.")]
		public int layer;

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
