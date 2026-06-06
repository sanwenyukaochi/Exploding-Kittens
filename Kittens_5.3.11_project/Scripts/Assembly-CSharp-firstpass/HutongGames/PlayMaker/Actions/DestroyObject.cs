namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Destroys a Game Object.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class DestroyObject : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject to destroy.")]
		public FsmGameObject gameObject;

		[HasFloatSlider(0f, 5f)]
		[Tooltip("Optional delay before destroying the Game Object.")]
		public FsmFloat delay;

		[Tooltip("Detach children before destroying the Game Object.")]
		public FsmBool detachChildren;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
