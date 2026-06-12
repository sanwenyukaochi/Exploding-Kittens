namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Select a random float from an array of floats.")]
	public class SelectRandomFloat : FsmStateAction
	{
		[Tooltip("A possible float choice.")]
		[CompoundArray("Floats", "Float", "Weight")]
		public FsmFloat[] floats;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("The relative probability of this float being picked. E.g. a weight of 0.5 is half as likely to be picked as a weight of 1.")]
		public FsmFloat[] weights;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the selected float in a Float Variable.")]
		public FsmFloat storeFloat;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSelectRandomString()
		{
		}
	}
}
