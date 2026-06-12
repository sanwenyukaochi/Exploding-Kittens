namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Returns the value corresponding to key in the preference file if it exists.")]
	[ActionCategory("PlayerPrefs")]
	public class PlayerPrefsGetInt : FsmStateAction
	{
		[Tooltip("Case sensitive key.")]
		[CompoundArray("Count", "Key", "Variable")]
		public FsmString[] keys;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the integer in an Int Variable.")]
		public FsmInt[] variables;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
