namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Makes the Game Object not be destroyed automatically when loading a new scene.\nSee unity docs: <a href=\"http://unity3d.com/support/documentation/ScriptReference/Object.DontDestroyOnLoad.html\">DontDestroyOnLoad</a>.")]
	[ActionCategory(ActionCategory.Level)]
	public class DontDestroyOnLoad : FsmStateAction
	{
		[RequiredField]
		[Tooltip("GameObject to mark as DontDestroyOnLoad.")]
		public FsmOwnerDefault gameObject;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
