namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Select a random Int from an array of Ints.")]
	public class SelectRandomInt : FsmStateAction
	{
		[CompoundArray("Ints", "Int", "Weight")]
		[Tooltip("A possible int choice.")]
		public FsmInt[] ints;

		[Tooltip("The relative probability of this int being picked. E.g. a weight of 0.5 is half as likely to be picked as a weight of 1.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the selected int in an Int Variable.")]
		public FsmInt storeInt;

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
