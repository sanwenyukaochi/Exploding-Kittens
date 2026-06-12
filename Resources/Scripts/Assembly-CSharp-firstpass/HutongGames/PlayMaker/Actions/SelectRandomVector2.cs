namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Vector2)]
	[Tooltip("Select a Random Vector2 from a Vector2 array.")]
	public class SelectRandomVector2 : FsmStateAction
	{
		[CompoundArray("Vectors", "Vector", "Weight")]
		[Tooltip("A possible Vector2 choice.")]
		public FsmVector2[] vector2Array;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("The relative probability of this Vector2 being picked. E.g. a weight of 0.5 is half as likely to be picked as a weight of 1.")]
		public FsmFloat[] weights;

		[RequiredField]
		[Tooltip("Store the selected Vector2 in a Vector2 Variable.")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 storeVector2;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSelectRandom()
		{
		}
	}
}
