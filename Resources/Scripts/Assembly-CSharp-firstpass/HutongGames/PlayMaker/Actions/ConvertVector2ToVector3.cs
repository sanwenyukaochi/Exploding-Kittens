namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Convert)]
	[Tooltip("Store a Vector2 XY components into a Vector3 XY component. The Vector3 z component is also accessible for convenience")]
	public class ConvertVector2ToVector3 : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The vector2")]
		public FsmVector2 vector2;

		[UIHint(UIHint.Variable)]
		[Tooltip("The vector3")]
		public FsmVector3 vector3;

		[Tooltip("The vector3 z value")]
		public FsmFloat zValue;

		[Tooltip("Repeat every frame. Useful if the Vector2 value is changing.")]
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
	}
}
