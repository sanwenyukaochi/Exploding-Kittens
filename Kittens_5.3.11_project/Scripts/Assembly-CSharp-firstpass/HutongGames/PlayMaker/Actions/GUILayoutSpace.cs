namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Inserts a space in the current layout group.")]
	[ActionCategory(ActionCategory.GUILayout)]
	public class GUILayoutSpace : FsmStateAction
	{
		[Tooltip("Size of space in pixels.")]
		public FsmFloat space;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
