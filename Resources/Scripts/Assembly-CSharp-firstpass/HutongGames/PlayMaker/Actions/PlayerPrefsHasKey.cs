namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Returns true if PlayerPref key exists in the preferences.")]
	[ActionCategory("PlayerPrefs")]
	public class PlayerPrefsHasKey : FsmStateAction
	{
		[Tooltip("The name of the PlayerPref to test for.")]
		[RequiredField]
		public FsmString key;

		[UIHint(UIHint.Variable)]
		[Title("Store Result")]
		[Tooltip("Store the result in a bool variable.")]
		public FsmBool variable;

		[Tooltip("Event to send if the key exists.")]
		public FsmEvent trueEvent;

		[Tooltip("Event to send if the key does not exist.")]
		public FsmEvent falseEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
