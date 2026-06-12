using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Scene)]
	[Tooltip("This will merge the source scene into the destinationScene. This function merges the contents of the source scene into the destination scene, and deletes the source scene. All GameObjects at the root of the source scene are moved to the root of the destination scene. NOTE: This function is destructive: The source scene will be destroyed once the merge has been completed.")]
	public class MergeScenes : FsmStateAction
	{
		[ActionSection("Source")]
		[Tooltip("The reference options of the source Scene")]
		public GetSceneActionBase.SceneAllReferenceOptions sourceReference;

		[Tooltip("The source scene Index.")]
		public FsmInt sourceAtIndex;

		[Tooltip("The source scene Name.")]
		public FsmString sourceByName;

		[Tooltip("The source scene Path.")]
		public FsmString sourceByPath;

		[Tooltip("The source scene from GameObject")]
		public FsmOwnerDefault sourceByGameObject;

		[ActionSection("Destination")]
		[Tooltip("The reference options of the destination Scene")]
		public GetSceneActionBase.SceneAllReferenceOptions destinationReference;

		[Tooltip("The destination scene Index.")]
		public FsmInt destinationAtIndex;

		[Tooltip("The destination scene Name.")]
		public FsmString destinationByName;

		[Tooltip("The destination scene Path.")]
		public FsmString destinationByPath;

		[Tooltip("The destination scene from GameObject")]
		public FsmOwnerDefault destinationByGameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("True if the merge succeeded")]
		[ActionSection("Result")]
		public FsmBool success;

		[Tooltip("Event sent if merge succeeded")]
		public FsmEvent successEvent;

		[Tooltip("Event sent if merge failed")]
		public FsmEvent failureEvent;

		private Scene _sourceScene;

		private bool _sourceFound;

		private Scene _destinationScene;

		private bool _destinationFound;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void GetSourceScene()
		{
		}

		private void GetDestinationScene()
		{
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
