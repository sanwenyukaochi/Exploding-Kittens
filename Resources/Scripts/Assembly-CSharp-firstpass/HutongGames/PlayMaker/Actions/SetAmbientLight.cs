namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.RenderSettings)]
	[Tooltip("Sets the Ambient Light Color for the scene.")]
	public class SetAmbientLight : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Color of the ambient light.")]
		public FsmColor ambientColor;

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

		private void DoSetAmbientColor()
		{
		}
	}
}
