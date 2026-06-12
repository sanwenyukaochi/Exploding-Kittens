namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the color of the Fog in the scene.")]
	[ActionCategory(ActionCategory.RenderSettings)]
	public class SetFogColor : FsmStateAction
	{
		[Tooltip("The color of the fog.")]
		[RequiredField]
		public FsmColor fogColor;

		[Tooltip("Update every frame. Useful if the color is animated.")]
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

		private void DoSetFogColor()
		{
		}
	}
}
