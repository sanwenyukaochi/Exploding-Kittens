namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the value of the preference identified by key. Lets you save a float value that you can load later with {{PlayerPrefs Get Float}}.")]
	[ActionCategory("PlayerPrefs")]
	public class PlayerPrefsSetFloat : FsmStateAction
	{
		[CompoundArray("Count", "Key", "Value")]
		[Tooltip("Case sensitive key.")]
		public FsmString[] keys;

		[Tooltip("The value to save.")]
		public FsmFloat[] values;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
