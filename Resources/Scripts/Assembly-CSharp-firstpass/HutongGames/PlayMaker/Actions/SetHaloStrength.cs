namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.RenderSettings)]
	[Tooltip("Sets the size of light halos.")]
	public class SetHaloStrength : FsmStateAction
	{
		[Tooltip("The size of light halos.")]
		[RequiredField]
		public FsmFloat haloStrength;

		[Tooltip("Update every frame. Useful if the size is animated.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoSetHaloStrength()
		{
		}
	}
}
