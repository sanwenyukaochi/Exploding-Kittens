namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Removes key and its corresponding value from the preferences.")]
	[ActionCategory("PlayerPrefs")]
	public class PlayerPrefsDeleteKey : FsmStateAction
	{
		[Tooltip("The name of the PlayerPref.")]
		public FsmString key;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
