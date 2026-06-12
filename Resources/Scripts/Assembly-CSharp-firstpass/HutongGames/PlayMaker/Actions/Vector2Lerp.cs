namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Linearly interpolates between 2 vectors.")]
	[ActionCategory(ActionCategory.Vector2)]
	public class Vector2Lerp : FsmStateAction
	{
		[Tooltip("First Vector.")]
		[RequiredField]
		public FsmVector2 fromVector;

		[Tooltip("Second Vector.")]
		[RequiredField]
		public FsmVector2 toVector;

		[RequiredField]
		[Tooltip("Interpolate between From Vector and ToVector by this amount. Value is clamped to 0-1 range. 0 = From Vector; 1 = To Vector; 0.5 = half way between.")]
		public FsmFloat amount;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the result in this vector variable.")]
		[RequiredField]
		public FsmVector2 storeResult;

		[Tooltip("Repeat every frame. Useful if any of the values are changing.")]
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

		private void DoVector2Lerp()
		{
		}
	}
}
