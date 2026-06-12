namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the value of the preference identified by key. Lets you save a string that you can load later with {{PlayerPrefs Get String}}.")]
	[ActionCategory("PlayerPrefs")]
	public class PlayerPrefsSetString : FsmStateAction
	{
		[CompoundArray("Count", "Key", "Value")]
		[Tooltip("Case sensitive key.")]
		public FsmString[] keys;

		[Tooltip("The value to save.")]
		public FsmString[] values;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
