namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Destroys GameObjects in an array.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class DestroyObjects : FsmStateAction
	{
		[RequiredField]
		[ArrayEditor(VariableType.GameObject, null, 0, 0, 65536)]
		[Tooltip("The GameObjects to destroy.")]
		public FsmArray gameObjects;

		[Tooltip("Optional delay before destroying the Game Objects.")]
		[HasFloatSlider(0f, 5f)]
		public FsmFloat delay;

		[Tooltip("Detach children before destroying the Game Objects.")]
		public FsmBool detachChildren;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
