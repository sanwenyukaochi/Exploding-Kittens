using System;
using System.Collections.Generic;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmEvent : IComparable, INameable
	{
		private static Dictionary<string, FsmEvent> _eventLookup;

		private static readonly object syncObj;

		[SerializeField]
		private string name;

		[SerializeField]
		private bool isSystemEvent;

		[SerializeField]
		private bool isGlobal;

		[NonSerialized]
		private string _path;

		public static PlayMakerGlobals GlobalsComponent => null;

		public static List<string> globalEvents => null;

		private static Dictionary<string, FsmEvent> eventLookup => null;

		public static List<FsmEvent> EventList => null;

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

		public bool IsUnityEvent => false;

		public bool IsSystemEvent
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsMouseEvent => false;

		public bool IsApplicationEvent => false;

		public bool IsLegacyNetworkEvent => false;

		public bool IsCollisionEvent => false;

		public bool IsTriggerEvent => false;

		public bool IsCollision2DEvent => false;

		public bool IsTrigger2DEvent => false;

		public bool IsUIEvent => false;

		public bool IsGlobal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string Path
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static FsmEvent BecameInvisible { get; private set; }

		public static FsmEvent BecameVisible { get; private set; }

		public static FsmEvent CollisionEnter { get; private set; }

		public static FsmEvent CollisionExit { get; private set; }

		public static FsmEvent CollisionStay { get; private set; }

		public static FsmEvent CollisionEnter2D { get; private set; }

		public static FsmEvent CollisionExit2D { get; private set; }

		public static FsmEvent CollisionStay2D { get; private set; }

		public static FsmEvent ControllerColliderHit { get; private set; }

		public static FsmEvent Finished { get; private set; }

		public static FsmEvent LevelLoaded { get; private set; }

		public static FsmEvent MouseDown { get; private set; }

		public static FsmEvent MouseDrag { get; private set; }

		public static FsmEvent MouseEnter { get; private set; }

		public static FsmEvent MouseExit { get; private set; }

		public static FsmEvent MouseOver { get; private set; }

		public static FsmEvent MouseUp { get; private set; }

		public static FsmEvent MouseUpAsButton { get; private set; }

		public static FsmEvent TriggerEnter { get; private set; }

		public static FsmEvent TriggerExit { get; private set; }

		public static FsmEvent TriggerStay { get; private set; }

		public static FsmEvent TriggerEnter2D { get; private set; }

		public static FsmEvent TriggerExit2D { get; private set; }

		public static FsmEvent TriggerStay2D { get; private set; }

		public static FsmEvent ApplicationFocus { get; private set; }

		public static FsmEvent ApplicationPause { get; private set; }

		public static FsmEvent ApplicationQuit { get; private set; }

		public static FsmEvent ParticleCollision { get; private set; }

		public static FsmEvent JointBreak { get; private set; }

		public static FsmEvent JointBreak2D { get; private set; }

		public static FsmEvent Disable { get; private set; }

		public static FsmEvent PlayerConnected { get; private set; }

		public static FsmEvent ServerInitialized { get; private set; }

		public static FsmEvent ConnectedToServer { get; private set; }

		public static FsmEvent PlayerDisconnected { get; private set; }

		public static FsmEvent DisconnectedFromServer { get; private set; }

		public static FsmEvent FailedToConnect { get; private set; }

		public static FsmEvent FailedToConnectToMasterServer { get; private set; }

		public static FsmEvent MasterServerEvent { get; private set; }

		public static FsmEvent NetworkInstantiate { get; private set; }

		public static FsmEvent UiBeginDrag { get; private set; }

		public static FsmEvent UiDrag { get; private set; }

		public static FsmEvent UiEndDrag { get; private set; }

		public static FsmEvent UiClick { get; private set; }

		public static FsmEvent UiDrop { get; private set; }

		public static FsmEvent UiPointerClick { get; private set; }

		public static FsmEvent UiPointerDown { get; private set; }

		public static FsmEvent UiPointerEnter { get; private set; }

		public static FsmEvent UiPointerExit { get; private set; }

		public static FsmEvent UiPointerUp { get; private set; }

		public static FsmEvent UiBoolValueChanged { get; private set; }

		public static FsmEvent UiFloatValueChanged { get; private set; }

		public static FsmEvent UiIntValueChanged { get; private set; }

		public static FsmEvent UiVector2ValueChanged { get; private set; }

		public static FsmEvent UiEndEdit { get; private set; }

		public static void InitInEditor()
		{
		}

		private static void Initialize()
		{
		}

		public static bool IsNullOrEmpty(FsmEvent fsmEvent)
		{
			return false;
		}

		public FsmEvent(string name)
		{
		}

		public FsmEvent(FsmEvent source)
		{
		}

		int IComparable.CompareTo(object obj)
		{
			return 0;
		}

		public static bool EventListContainsEvent(List<FsmEvent> fsmEventList, string fsmEventName)
		{
			return false;
		}

		public static void RemoveEventFromEventList(FsmEvent fsmEvent)
		{
		}

		public static FsmEvent FindEvent(string eventName)
		{
			return null;
		}

		public static bool IsEventGlobal(string eventName)
		{
			return false;
		}

		public static void SetEventIsGlobal(string eventName)
		{
		}

		public static bool EventListContains(string eventName)
		{
			return false;
		}

		public static FsmEvent GetFsmEvent(string eventName)
		{
			return null;
		}

		public static FsmEvent GetFsmEvent(FsmEvent fsmEvent)
		{
			return null;
		}

		public static FsmEvent AddFsmEvent(FsmEvent fsmEvent)
		{
			return null;
		}

		private static void AddSystemEvents()
		{
		}

		private static FsmEvent AddSystemEvent(string eventName, string path = "")
		{
			return null;
		}

		private static void AddGlobalEvents()
		{
		}

		public static void SanityCheckEventList()
		{
		}
	}
}
