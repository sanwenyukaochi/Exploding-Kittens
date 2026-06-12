using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class Fsm : INameable, IComparable
	{
		[Serializable]
		[Flags]
		private enum EditorFlags
		{
			none = 0,
			nameIsExpanded = 1,
			controlsIsExpanded = 2,
			debugIsExpanded = 4,
			experimentalIsExpanded = 8,
			infoIsExpanded = 0x10,
			inputsIsExpanded = 0x20,
			outputsIsExpanded = 0x40,
			eventsIsExpanded = 0x80,
			settingsIsExpanded = 0x100
		}

		public const int CurrentDataVersion = 2;

		public const int DefaultMaxLoops = 1000;

		private MethodInfo updateHelperSetDirty;

		private const string StartStateName = "State 1";

		public static FsmEventData EventData;

		public Action<FsmEvent> OnOutputEvent;

		[SerializeField]
		private int dataVersion;

		[NonSerialized]
		private MonoBehaviour owner;

		[SerializeField]
		private FsmTemplate usedInTemplate;

		[SerializeField]
		private string name;

		[SerializeField]
		private string startState;

		[SerializeField]
		private FsmState[] states;

		[SerializeField]
		private FsmEvent[] events;

		[SerializeField]
		private FsmTransition[] globalTransitions;

		[SerializeField]
		private FsmVariables variables;

		[TextArea(0, 10)]
		[SerializeField]
		private string description;

		[SerializeField]
		private string docUrl;

		[SerializeField]
		private bool showStateLabel;

		[SerializeField]
		private int maxLoopCount;

		[SerializeField]
		private string watermark;

		[SerializeField]
		private string password;

		[SerializeField]
		private bool locked;

		[SerializeField]
		private bool manualUpdate;

		[SerializeField]
		private int[] outVariableIndices;

		[NonSerialized]
		private NamedVariable[] outputVariables;

		[SerializeField]
		private bool keepDelayedEventsOnStateExit;

		[SerializeField]
		private bool preprocessed;

		[NonSerialized]
		private Fsm host;

		[NonSerialized]
		private Fsm rootFsm;

		[NonSerialized]
		private List<Fsm> subFsmList;

		[NonSerialized]
		public bool setDirty;

		private bool activeStateEntered;

		public List<FsmEvent> ExposedEvents;

		public List<FsmEvent> OutputEvents;

		private FsmLog myLog;

		public bool RestartOnEnable;

		public bool ResetVariablesOnEnable;

		[NonSerialized]
		private FsmVariables _defaultVariableValues;

		[NonSerialized]
		private bool hasErrors;

		public bool EnableDebugFlow;

		public bool EnableBreakpoints;

		[NonSerialized]
		public bool StepFrame;

		[NonSerialized]
		private readonly List<DelayedEvent> delayedEvents;

		[NonSerialized]
		private readonly List<DelayedEvent> updateEvents;

		[NonSerialized]
		private readonly List<DelayedEvent> removeEvents;

		[SerializeField]
		private EditorFlags editorFlags;

		[NonSerialized]
		private bool initialized;

		[SerializeField]
		private string activeStateName;

		[NonSerialized]
		private FsmState activeState;

		[NonSerialized]
		private FsmState switchToState;

		[NonSerialized]
		private FsmState previousActiveState;

		public Action<FsmState> StateChanged;

		[NonSerialized]
		private FsmState editState;

		[SerializeField]
		private bool mouseEvents;

		[SerializeField]
		private bool handleLevelLoaded;

		[SerializeField]
		private bool handleTriggerEnter2D;

		[SerializeField]
		private bool handleTriggerExit2D;

		[SerializeField]
		private bool handleTriggerStay2D;

		[SerializeField]
		private bool handleCollisionEnter2D;

		[SerializeField]
		private bool handleCollisionExit2D;

		[SerializeField]
		private bool handleCollisionStay2D;

		[SerializeField]
		private bool handleTriggerEnter;

		[SerializeField]
		private bool handleTriggerExit;

		[SerializeField]
		private bool handleTriggerStay;

		[SerializeField]
		private bool handleCollisionEnter;

		[SerializeField]
		private bool handleCollisionExit;

		[SerializeField]
		private bool handleCollisionStay;

		[SerializeField]
		private bool handleParticleCollision;

		[SerializeField]
		private bool handleControllerColliderHit;

		[SerializeField]
		private bool handleJointBreak;

		[SerializeField]
		private bool handleJointBreak2D;

		[SerializeField]
		private bool handleOnGUI;

		[SerializeField]
		private bool handleFixedUpdate;

		[SerializeField]
		private bool handleLateUpdate;

		[SerializeField]
		private bool handleApplicationEvents;

		[SerializeField]
		private UiEvents handleUiEvents;

		[SerializeField]
		private bool handleLegacyNetworking;

		private static Dictionary<Fsm, RaycastHit2D> lastRaycastHit2DInfoLUT;

		[SerializeField]
		private bool handleAnimatorMove;

		[SerializeField]
		private bool handleAnimatorIK;

		private bool disableSent;

		private static readonly FsmEventTarget targetSelf;

		[Obsolete("Use PlayMakerPrefs.Colors instead.")]
		public static readonly Color[] StateColors;

		public static List<Fsm> FsmList => null;

		public static List<Fsm> SortedFsmList => null;

		private MethodInfo UpdateHelperSetDirty => null;

		public bool ManualUpdate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool KeepDelayedEventsOnStateExit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Preprocessed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Fsm Host
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public string Password => null;

		public bool Locked => false;

		public FsmTemplate Template => null;

		public bool IsSubFsm => false;

		public Fsm RootFsm => null;

		public List<Fsm> SubFsmList => null;

		public FsmVariables DefaultVariableValues
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public bool HasErrors
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Started { get; private set; }

		public List<DelayedEvent> DelayedEvents => null;

		public int DataVersion
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public MonoBehaviour Owner
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool NameIsExpanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ControlsIsExpanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool DebugIsExpanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ExperimentalIsExpanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool InfoIsExpanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool InputsIsExpanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool OutputsIsExpanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool EventsIsExpanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool SettingsIsExpanded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmTemplate UsedInTemplate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string StartState
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmState[] States
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmEvent[] Events
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmTransition[] GlobalTransitions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmVariables Variables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmEventTarget EventTarget { get; set; }

		public bool Initialized => false;

		public bool Active => false;

		public bool Finished { get; private set; }

		public bool IsSwitchingState => false;

		public FsmState ActiveState
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public string ActiveStateName => null;

		public FsmState PreviousActiveState
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public FsmTransition LastTransition { get; private set; }

		public int MaxLoopCount => 0;

		public int MaxLoopCountOverride
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string OwnerName => null;

		public string OwnerDebugName => null;

		public GameObject GameObject => null;

		public string GameObjectName => null;

		public UnityEngine.Object OwnerObject => null;

		public PlayMakerFSM FsmComponent => null;

		public FsmLog MyLog => null;

		public bool IsModifiedPrefabInstance { get; set; }

		public string Description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Watermark
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ShowStateLabel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private string GuiLabel => null;

		public string DocUrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmState EditState
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static GameObject LastClickedObject { get; set; }

		public static bool BreakpointsEnabled { get; set; }

		public static bool HitBreakpoint { get; set; }

		public static Fsm BreakAtFsm { get; private set; }

		public static FsmState BreakAtState { get; private set; }

		public static bool IsBreak { get; private set; }

		public static bool IsErrorBreak { get; private set; }

		public static string LastError { get; private set; }

		public static bool StepToStateChange { get; set; }

		public static Fsm StepFsm { get; set; }

		public bool SwitchedState { get; set; }

		public bool MouseEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleLevelLoaded
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleTriggerEnter2D
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleTriggerExit2D
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleTriggerStay2D
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleCollisionEnter2D
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleCollisionExit2D
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleCollisionStay2D
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleTriggerEnter
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleTriggerExit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleTriggerStay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleCollisionEnter
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleCollisionExit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleCollisionStay
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleParticleCollision
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleControllerColliderHit
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleJointBreak
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleJointBreak2D
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleOnGUI
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleFixedUpdate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleLateUpdate
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleApplicationEvents
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public UiEvents HandleUiEvents
		{
			get
			{
				return default(UiEvents);
			}
			set
			{
			}
		}

		public bool HandleLegacyNetworking
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Collision CollisionInfo { get; set; }

		public Collider TriggerCollider { get; set; }

		public Collision2D Collision2DInfo { get; set; }

		public Collider2D TriggerCollider2D { get; set; }

		public float JointBreakForce { get; private set; }

		public Joint2D BrokenJoint2D { get; private set; }

		public GameObject ParticleCollisionGO { get; set; }

		public GameObject CollisionGO => null;

		public GameObject Collision2dGO => null;

		public GameObject TriggerGO => null;

		public GameObject Trigger2dGO => null;

		public string TriggerName { get; private set; }

		public string CollisionName { get; private set; }

		public string Trigger2dName { get; private set; }

		public string Collision2dName { get; private set; }

		public ControllerColliderHit ControllerCollider { get; set; }

		public RaycastHit RaycastHitInfo { get; set; }

		public bool HandleAnimatorMove
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandleAnimatorIK
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[Obsolete("Use PlayMakerPrefs.ArrowColor")]
		public static Color DebugLookAtColor { get; set; }

		[Obsolete("Use PlayMakerPrefs.ArrowColor")]
		public static Color DebugRaycastColor { get; set; }

		public void ClearOutputFlags()
		{
		}

		public NamedVariable[] GetOutputVariables(bool refresh = true)
		{
			return null;
		}

		public string[] GetOutputVariableNames()
		{
			return null;
		}

		public void SetOutputVariables(string[] outputVarNames)
		{
		}

		public string SanityCheckOutputIndices()
		{
			return null;
		}

		private bool OutVariableIndicesNeedFixing()
		{
			return false;
		}

		public void Lock(string pass)
		{
		}

		public void Unlock(string pass)
		{
		}

		public void KillDelayedEvents()
		{
		}

		public void ForcePreprocess()
		{
		}

		private void ResetEventHandlerFlags()
		{
		}

		public static void RecordLastRaycastHit2DInfo(Fsm fsm, RaycastHit2D info)
		{
		}

		public static RaycastHit2D GetLastRaycastHit2DInfo(Fsm fsm)
		{
			return default(RaycastHit2D);
		}

		public static Fsm NewTempFsm()
		{
			return null;
		}

		public Fsm()
		{
		}

		public Fsm(Fsm source, FsmVariables overrideVariables = null)
		{
		}

		public Fsm CreateSubFsm(FsmTemplateControl templateControl)
		{
			return null;
		}

		private Fsm GetRootFsm()
		{
			return null;
		}

		public void CheckIfDirty()
		{
		}

		public void Reset(MonoBehaviour component)
		{
		}

		public void UpdateDataVersion()
		{
		}

		public void SaveActions()
		{
		}

		public void Clear(MonoBehaviour component)
		{
		}

		private void FixDataVersion()
		{
		}

		private int DeduceDataVersion()
		{
			return 0;
		}

		public void Preprocess(MonoBehaviour component)
		{
		}

		private void Preprocess()
		{
		}

		private void Awake()
		{
		}

		public void Init(MonoBehaviour component)
		{
		}

		public void Reinitialize()
		{
		}

		public void InitStates()
		{
		}

		public void InitData()
		{
		}

		public void InitEvents()
		{
		}

		private void CheckFsmEventsForEventHandlers()
		{
		}

		public void InitInEditor()
		{
		}

		public void OnEnable()
		{
		}

		public void SaveDefaultVariableValues()
		{
		}

		public void ResetVariableValues()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
		{
		}

		public void Start()
		{
		}

		public void Update()
		{
		}

		public void UpdateDelayedEvents()
		{
		}

		public void ClearDelayedEvents()
		{
		}

		public void FixedUpdate()
		{
		}

		public void LateUpdate()
		{
		}

		public void OnDisable()
		{
		}

		public void SendDisableEvent()
		{
		}

		public void Stop()
		{
		}

		private void StopAndReset()
		{
		}

		public bool HasEvent(string eventName)
		{
			return false;
		}

		public void ProcessEvent(FsmEvent fsmEvent, FsmEventData eventData = null)
		{
		}

		public static void SetEventDataSentByInfo()
		{
		}

		private static void SetEventDataSentByInfo(FsmEventData eventData)
		{
		}

		private static FsmEventData GetEventDataSentByInfo()
		{
			return null;
		}

		public void Event(FsmEventTarget eventTarget, string fsmEventName)
		{
		}

		public void Event(GameObject fromGameObject, FsmEventTarget eventTarget, FsmEvent fsmEvent)
		{
		}

		public void Event(GameObject fromGameObject, FsmEvent fsmEvent)
		{
		}

		public void Event(FsmEventTarget eventTarget, FsmEvent fsmEvent)
		{
		}

		public void Event(string fsmEventName)
		{
		}

		public void Event(FsmEvent fsmEvent)
		{
		}

		public DelayedEvent DelayedEvent(FsmEvent fsmEvent, float delay)
		{
			return null;
		}

		public DelayedEvent DelayedEvent(FsmEventTarget eventTarget, FsmEvent fsmEvent, float delay)
		{
			return null;
		}

		public void BroadcastEvent(string fsmEventName, bool excludeSelf = false)
		{
		}

		public void BroadcastEvent(FsmEvent fsmEvent, bool excludeSelf = false)
		{
		}

		public void BroadcastEventToGameObject(GameObject go, string fsmEventName, bool sendToChildren, bool excludeSelf = false)
		{
		}

		public void BroadcastEventToGameObject(GameObject go, FsmEvent fsmEvent, FsmEventData eventData, bool sendToChildren, bool excludeSelf = false)
		{
		}

		private bool IsFsmChildOfGameObject(PlayMakerFSM fsm, Transform root)
		{
			return false;
		}

		public void SendEventToFsmOnGameObject(GameObject gameObject, string fsmName, string fsmEventName)
		{
		}

		public void SendEventToFsmOnGameObject(GameObject gameObject, string fsmName, FsmEvent fsmEvent)
		{
		}

		public bool HasState(string stateName)
		{
			return false;
		}

		public void SetState(string stateName)
		{
		}

		public void UpdateStateChanges()
		{
		}

		private bool DoTransition(FsmTransition transition, bool isGlobal)
		{
			return false;
		}

		public void SwitchState(FsmState toState)
		{
		}

		public void GotoPreviousState()
		{
		}

		public void ReEnterState()
		{
		}

		private void EnterState(FsmState state)
		{
		}

		private void FixedUpdateState(FsmState state)
		{
		}

		private void UpdateState(FsmState state)
		{
		}

		private void LateUpdateState(FsmState state)
		{
		}

		private void ExitState(FsmState state)
		{
		}

		public Fsm GetSubFsm(string subFsmName)
		{
			return null;
		}

		public static string GetFullFsmLabel(Fsm fsm)
		{
			return null;
		}

		public GameObject GetOwnerDefaultTarget(FsmOwnerDefault ownerDefault)
		{
			return null;
		}

		public FsmState GetState(string stateName)
		{
			return null;
		}

		public static int GetStateIndex(Fsm fsm, FsmState state)
		{
			return 0;
		}

		[Obsolete("Use FsmEvent.GetFsmEvent(eventName) instead.")]
		public FsmEvent GetEvent(string eventName)
		{
			return null;
		}

		public FsmEvent FindEvent(string eventName)
		{
			return null;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		public List<FsmTransition> GetGlobalTransitionsToState(FsmState state)
		{
			return null;
		}

		public FsmObject GetFsmObject(string varName)
		{
			return null;
		}

		public FsmMaterial GetFsmMaterial(string varName)
		{
			return null;
		}

		public FsmTexture GetFsmTexture(string varName)
		{
			return null;
		}

		public FsmFloat GetFsmFloat(string varName)
		{
			return null;
		}

		public FsmInt GetFsmInt(string varName)
		{
			return null;
		}

		public FsmBool GetFsmBool(string varName)
		{
			return null;
		}

		public FsmString GetFsmString(string varName)
		{
			return null;
		}

		public FsmVector2 GetFsmVector2(string varName)
		{
			return null;
		}

		public FsmVector3 GetFsmVector3(string varName)
		{
			return null;
		}

		public FsmRect GetFsmRect(string varName)
		{
			return null;
		}

		public FsmQuaternion GetFsmQuaternion(string varName)
		{
			return null;
		}

		public FsmColor GetFsmColor(string varName)
		{
			return null;
		}

		public FsmGameObject GetFsmGameObject(string varName)
		{
			return null;
		}

		public FsmArray GetFsmArray(string varName)
		{
			return null;
		}

		public FsmEnum GetFsmEnum(string varName)
		{
			return null;
		}

		public void OnDrawGizmos()
		{
		}

		public void OnDrawGizmosSelected()
		{
		}

		public void OnCollisionEnter(Collision collisionInfo)
		{
		}

		public void OnCollisionStay(Collision collisionInfo)
		{
		}

		public void OnCollisionExit(Collision collisionInfo)
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		public void OnTriggerStay(Collider other)
		{
		}

		public void OnTriggerExit(Collider other)
		{
		}

		public void OnParticleCollision(GameObject other)
		{
		}

		public void OnCollisionEnter2D(Collision2D collisionInfo)
		{
		}

		public void OnCollisionStay2D(Collision2D collisionInfo)
		{
		}

		public void OnCollisionExit2D(Collision2D collisionInfo)
		{
		}

		public void OnTriggerEnter2D(Collider2D other)
		{
		}

		public void OnTriggerStay2D(Collider2D other)
		{
		}

		public void OnTriggerExit2D(Collider2D other)
		{
		}

		public void OnControllerColliderHit(ControllerColliderHit collider)
		{
		}

		public void OnJointBreak(float breakForce)
		{
		}

		public void OnJointBreak2D(Joint2D brokenJoint)
		{
		}

		public void OnAnimatorMove()
		{
		}

		public void OnAnimatorIK(int layerIndex)
		{
		}

		public void OnGUI()
		{
		}

		private void DoBreakpoint()
		{
		}

		public void DoBreakError(string error)
		{
		}

		private void DoBreak()
		{
		}

		private void Continue()
		{
		}

		public void OnDestroy()
		{
		}

		[Conditional("DEBUG_LOG")]
		private void DebugLog(object message, LogColor logColor = LogColor.None)
		{
		}

		[Conditional("DEBUG_EVENTS")]
		private void DebugEvent(object message, LogColor logColor = LogColor.None)
		{
		}

		[Conditional("DEBUG_LIFETIME")]
		private void DebugLifetime(object message, LogColor logColor = LogColor.None)
		{
		}

		[Conditional("DEBUG_DEBUGGER")]
		private void DebugDebugger(object message, LogColor logColor = LogColor.None)
		{
		}
	}
}
