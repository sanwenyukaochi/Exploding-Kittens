namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.RenderSettings)]
	[Tooltip("Sets the density of the Fog in the scene.")]
	public class SetFogDensity : FsmStateAction
	{
		[Tooltip("The density of the fog.")]
		[RequiredField]
		public FsmFloat fogDensity;

		[Tooltip("Update every frame. Useful if the fog density is animated.")]
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

		private void DoSetFogDensity()
		{
		}
	}
}
