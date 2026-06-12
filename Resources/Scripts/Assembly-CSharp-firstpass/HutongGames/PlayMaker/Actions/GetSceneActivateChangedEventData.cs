using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the last activateChanged Scene Event data when event was sent from the action 'SendSceneActiveChangedEvent")]
	[ActionCategory(ActionCategory.Scene)]
	public class GetSceneActivateChangedEventData : FsmStateAction
	{
		[ActionSection("New Active Scene")]
		[UIHint(UIHint.Variable)]
		[Tooltip("The new active scene name")]
		public FsmString newName;

		[Tooltip("The new active scene path")]
		[UIHint(UIHint.Variable)]
		public FsmString newPath;

		[Tooltip("true if the new active scene is valid.")]
		[UIHint(UIHint.Variable)]
		public FsmBool newIsValid;

		[Tooltip("The new active scene Build Index")]
		[UIHint(UIHint.Variable)]
		public FsmInt newBuildIndex;

		[Tooltip("true if the new active scene is loaded.")]
		[UIHint(UIHint.Variable)]
		public FsmBool newIsLoaded;

		[Tooltip("true if the new active scene is modified.")]
		[UIHint(UIHint.Variable)]
		public FsmBool newIsDirty;

		[UIHint(UIHint.Variable)]
		[Tooltip("The new active scene RootCount")]
		public FsmInt newRootCount;

		[ArrayEditor(VariableType.GameObject, null, 0, 0, 65536)]
		[Tooltip("The new active scene Root GameObjects")]
		[UIHint(UIHint.Variable)]
		public FsmArray newRootGameObjects;

		[Tooltip("The previous active scene name")]
		[ActionSection("Previous Active Scene")]
		[UIHint(UIHint.Variable)]
		public FsmString previousName;

		[Tooltip("The previous active scene path")]
		[UIHint(UIHint.Variable)]
		public FsmString previousPath;

		[Tooltip("true if the previous active scene is valid.")]
		[UIHint(UIHint.Variable)]
		public FsmBool previousIsValid;

		[Tooltip("The previous active scene Build Index")]
		[UIHint(UIHint.Variable)]
		public FsmInt previousBuildIndex;

		[Tooltip("true if the previous active scene is loaded.")]
		[UIHint(UIHint.Variable)]
		public FsmBool previousIsLoaded;

		[UIHint(UIHint.Variable)]
		[Tooltip("true if the previous active scene is modified.")]
		public FsmBool previousIsDirty;

		[Tooltip("The previous active scene RootCount")]
		[UIHint(UIHint.Variable)]
		public FsmInt previousRootCount;

		[Tooltip("The previous active scene Root GameObjects")]
		[UIHint(UIHint.Variable)]
		[ArrayEditor(VariableType.GameObject, null, 0, 0, 65536)]
		public FsmArray previousRootGameObjects;

		private Scene _scene;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetSceneProperties()
		{
		}
	}
}
