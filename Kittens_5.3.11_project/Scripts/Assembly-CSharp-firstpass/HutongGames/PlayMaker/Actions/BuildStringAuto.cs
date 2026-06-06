namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Builds a String from other variables with color setting in each part.")]
	[ActionCategory("Ngui Actions")]
	public class BuildStringAuto : FsmStateAction
	{
		[CompoundArray("How Many", "From Varriable", "Color")]
		[Tooltip("Array of Strings to combine.")]
		[RequiredField]
		public FsmVar[] stringParts;

		public FsmColor[] stringColor;

		[Tooltip("Separator to insert between each String. E.g. space character.")]
		public FsmString separator;

		[Tooltip("Store the final String in a variable.")]
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmString storeResult;

		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		private string result;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoBuildString()
		{
		}
	}
}
