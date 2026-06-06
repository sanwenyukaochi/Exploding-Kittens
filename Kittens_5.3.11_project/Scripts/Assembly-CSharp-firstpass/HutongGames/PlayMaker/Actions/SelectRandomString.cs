namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Select a Random String from an array of Strings.")]
	[ActionCategory(ActionCategory.String)]
	public class SelectRandomString : FsmStateAction
	{
		[CompoundArray("Strings", "String", "Weight")]
		[Tooltip("A possible String choice.")]
		public FsmString[] strings;

		[Tooltip("The relative probability of this string being picked. E.g. a weight of 0.5 is half as likely to be picked as a weight of 1.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat[] weights;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the chosen String in a String Variable.")]
		public FsmString storeString;

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
