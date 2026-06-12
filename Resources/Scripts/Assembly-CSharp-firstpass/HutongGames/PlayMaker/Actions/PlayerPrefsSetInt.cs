namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("PlayerPrefs")]
	[Tooltip("Sets the value of the preference identified by key. Lets you save an int value that you can load later with {{PlayerPrefs Get Int}}.")]
	public class PlayerPrefsSetInt : FsmStateAction
	{
		[CompoundArray("Count", "Key", "Value")]
		[Tooltip("Case sensitive key.")]
		public FsmString[] keys;

		[Tooltip("The value to save.")]
		public FsmInt[] values;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
