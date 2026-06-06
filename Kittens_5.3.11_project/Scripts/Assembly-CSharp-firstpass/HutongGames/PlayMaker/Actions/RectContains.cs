namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Tests if a point is inside a rectangle.")]
	[ActionCategory(ActionCategory.Rect)]
	public class RectContains : FsmStateAction
	{
		[Tooltip("Rectangle to test.")]
		[RequiredField]
		public FsmRect rectangle;

		[Tooltip("Point to test.")]
		public FsmVector3 point;

		[Tooltip("Specify/override X value.")]
		public FsmFloat x;

		[Tooltip("Specify/override Y value.")]
		public FsmFloat y;

		[Tooltip("Event to send if the Point is inside the Rectangle.")]
		public FsmEvent trueEvent;

		[Tooltip("Event to send if the Point is outside the Rectangle.")]
		public FsmEvent falseEvent;

		[Tooltip("Store the result in a variable.")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;

		[Tooltip("Repeat every frame.")]
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

		private void DoRectContains()
		{
		}
	}
}
