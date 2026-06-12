namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Allow scenes to be activated. Use this after {{LoadSceneAsynch}} if you did not set the scene to activate after loading")]
	[ActionCategory(ActionCategory.Scene)]
	public class AllowSceneActivation : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The name of the new scene. It cannot be empty, null, or same as existing scenes.")]
		[UIHint(UIHint.Variable)]
		public FsmInt aSynchOperationHashCode;

		[Tooltip("Allow the scene to be activated")]
		public FsmBool allowSceneActivation;

		[UIHint(UIHint.Variable)]
		[Tooltip("The loading's progress.")]
		[ActionSection("Result")]
		public FsmFloat progress;

		[UIHint(UIHint.Variable)]
		[Tooltip("True when loading is done")]
		public FsmBool isDone;

		[Tooltip("Event sent when scene loading is done")]
		public FsmEvent doneEvent;

		[Tooltip("Event sent when action could not be performed. Check Log for more information")]
		public FsmEvent failureEvent;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoAllowSceneActivation()
		{
		}
	}
}
