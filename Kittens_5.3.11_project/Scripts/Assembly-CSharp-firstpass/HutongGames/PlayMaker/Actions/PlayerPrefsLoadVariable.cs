namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("PlayerPrefs")]
	[Tooltip("Load variable value saved with {{PlayerPrefs Save Variable}}. The Key should be a unique identifier for the variable.")]
	public class PlayerPrefsLoadVariable : FsmStateAction
	{
		[Tooltip("Case sensitive key.")]
		public FsmString key;

		[UIHint(UIHint.Variable)]
		[Tooltip("The variable to load.")]
		public FsmVar variable;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
