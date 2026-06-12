namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("PlayerPrefs")]
	[Tooltip("Returns the value corresponding to key in the preference file if it exists.")]
	public class PlayerPrefsGetString : FsmStateAction
	{
		[CompoundArray("Count", "Key", "Variable")]
		[Tooltip("Case sensitive key.")]
		public FsmString[] keys;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the string in a String Variable.")]
		public FsmString[] variables;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
