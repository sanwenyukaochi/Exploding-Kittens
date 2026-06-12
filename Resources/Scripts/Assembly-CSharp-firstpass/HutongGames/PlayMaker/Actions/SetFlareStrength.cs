namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the intensity of all Flares in the scene.")]
	[ActionCategory(ActionCategory.RenderSettings)]
	public class SetFlareStrength : FsmStateAction
	{
		[Tooltip("The intensity of flares in the scene.")]
		[RequiredField]
		public FsmFloat flareStrength;

		[Tooltip("Update every frame. Useful if the intensity is animated.")]
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

		private void DoSetFlareStrength()
		{
		}
	}
}
