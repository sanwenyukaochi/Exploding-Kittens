using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using HutongGames;
using HutongGames.PlayMaker;
using JetBrains.Annotations;
using UnityEngine;

[AddComponentMenu("PlayMaker/PlayMakerFSM")]
[HelpURL("https://hutonggames.fogbugz.com/f/page?W1224")]
public class PlayMakerFSM : MonoBehaviour, ISerializationCallbackReceiver
{
	private delegate void AddEventHandlerDelegate(PlayMakerFSM fsm);

	public static Action<string> OnSettingChanged;

	private static readonly List<PlayMakerFSM> fsmList;

	public static bool ApplicationIsQuitting;

	[SerializeField]
	private Fsm fsm;

	[SerializeField]
	private FsmTemplate fsmTemplate;

	[SerializeField]
	private bool eventHandlerComponentsAdded;

	public Action OnReset;

	public Action OnValidated;

	private static Thread mainThread;

	private AddEventHandlerDelegate addEventHandlers;

	public static string VersionNotes => null;

	public static string VersionLabel => null;

	public static List<PlayMakerFSM> FsmList => null;

	public static bool IsMainThread => false;

	public static bool NotMainThread => false;

	public FsmTemplate FsmTemplate => null;

	public static bool DrawGizmos { get; set; }

	private AddEventHandlerDelegate AddEventHandlers => null;

	public Fsm Fsm
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string FsmName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string FsmDescription
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool Active => false;

	public string ActiveStateName => null;

	public FsmState[] FsmStates => null;

	public FsmEvent[] FsmEvents => null;

	public FsmTransition[] FsmGlobalTransitions => null;

	public FsmVariables FsmVariables => null;

	public bool UsesTemplate => false;

	[ContextMenu("Show Full FSM Inspector")]
	[UsedImplicitly]
	public void ShowFullFsmInspector()
	{
	}

	public static PlayMakerFSM FindFsmOnGameObject(GameObject go, string fsmName)
	{
		return null;
	}

	public static void InitInEditor()
	{
	}

	public void Reset()
	{
	}

	private void OnValidate()
	{
	}

	private void Awake()
	{
	}

	public void Preprocess()
	{
	}

	private void Init()
	{
	}

	private void InitTemplate()
	{
	}

	private void InitFsm()
	{
	}

	public void AddEventHandlerComponents()
	{
	}

	private void AddEventHandlerComponent<T>() where T : PlayMakerProxyBase
	{
	}

	public static T GetEventHandlerComponent<T>(GameObject go) where T : PlayMakerProxyBase
	{
		return null;
	}

	public void SetFsmTemplate(FsmTemplate template)
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	public IEnumerator DoCoroutine(IEnumerator routine)
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void OnDrawGizmos()
	{
	}

	public void SetState(string stateName)
	{
	}

	public void ChangeState(FsmEvent fsmEvent)
	{
	}

	[Obsolete("Use SendEvent(string) instead.")]
	public void ChangeState(string eventName)
	{
	}

	public void SendEvent(string eventName)
	{
	}

	[Obsolete("Use PlayMakerRPCProxy component with SendRemote actions.")]
	public void SendRemoteFsmEvent(string eventName)
	{
	}

	[Obsolete("Use PlayMakerRPCProxy component with SendRemote actions.")]
	public void SendRemoteFsmEventWithData(string eventName, string eventData)
	{
	}

	public static void BroadcastEvent(string fsmEventName)
	{
	}

	public static void BroadcastEvent(FsmEvent fsmEvent)
	{
	}

	private void OnBecameVisible()
	{
	}

	private void OnBecameInvisible()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}

	[Conditional("DEBUG_LOG")]
	private static void DebugLog(object message, LogColor logColor = LogColor.None)
	{
	}
}
