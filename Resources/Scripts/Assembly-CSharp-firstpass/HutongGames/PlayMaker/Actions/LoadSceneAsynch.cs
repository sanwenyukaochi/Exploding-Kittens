using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Loads the scene by its name or index in Build Settings.")]
	[ActionCategory(ActionCategory.Scene)]
	public class LoadSceneAsynch : FsmStateAction
	{
		[Tooltip("The reference options of the Scene")]
		public GetSceneActionBase.SceneSimpleReferenceOptions sceneReference;

		[Tooltip("The name of the scene to load. The given sceneName can either be the last part of the path, without .unity extension or the full path still without the .unity extension")]
		public FsmString sceneByName;

		[Tooltip("The index of the scene to load.")]
		public FsmInt sceneAtIndex;

		[ObjectType(typeof(LoadSceneMode))]
		[Tooltip("Allows you to specify whether or not to load the scene additively. See LoadSceneMode Unity doc for more information about the options.")]
		public FsmEnum loadSceneMode;

		[Tooltip("Allow the scene to be activated as soon as it's ready")]
		public FsmBool allowSceneActivation;

		[Tooltip("lets you tweak in which order async operation calls will be performed. Leave to none for default")]
		public FsmInt operationPriority;

		[Tooltip("Use this hash to activate the Scene if you have set 'AllowSceneActivation' to false, you'll need to use it in the action 'AllowSceneActivation' to effectively load the scene.")]
		[ActionSection("Result")]
		[UIHint(UIHint.Variable)]
		public FsmInt aSyncOperationHashCode;

		[Tooltip("The loading's progress.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat progress;

		[Tooltip("True when loading is done")]
		[UIHint(UIHint.Variable)]
		public FsmBool isDone;

		[Tooltip("True when loading is done but still waiting for scene activation")]
		[UIHint(UIHint.Variable)]
		public FsmBool pendingActivation;

		[Tooltip("Event sent when scene loading is done")]
		public FsmEvent doneEvent;

		[Tooltip("Event sent when scene loading is done but scene not yet activated. Use aSyncOperationHashCode value in 'AllowSceneActivation' to proceed")]
		public FsmEvent pendingActivationEvent;

		[Tooltip("Event sent if the scene to load was not found")]
		public FsmEvent sceneNotFoundEvent;

		private AsyncOperation _asyncOperation;

		private int _asynchOperationUid;

		private bool pendingActivationCallBackDone;

		public static Dictionary<int, AsyncOperation> aSyncOperationLUT;

		private static int aSynchUidCounter;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private bool DoLoadAsynch()
		{
			return false;
		}

		public override void OnUpdate()
		{
		}

		public override void OnExit()
		{
		}
	}
}
