namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("PlayerPrefs")]
	[Tooltip("Save a variable value in PlayerPrefs. You can load the value later with {{PlayerPrefs Load Variable}}.")]
	public class PlayerPrefsSaveVariable : FsmStateAction
	{
		[Tooltip("Case sensitive key.")]
		public FsmString key;

		[UIHint(UIHint.Variable)]
		[Tooltip("The variable to save.")]
		public FsmVar variable;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
