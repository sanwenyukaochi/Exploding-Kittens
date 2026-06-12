using System;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Serialization;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmTemplateControl
	{
		public enum TargetType
		{
			FsmTemplate = 0,
			PlayMakerFSM = 1,
			FsmGameObject = 2
		}

		public TargetType targetType;

		[FormerlySerializedAs("fsmTemplate")]
		public UnityEngine.Object target;

		[FormerlySerializedAs("fsmVarOverrides")]
		public FsmVarOverride[] inputVariables;

		public FsmVarOverride[] outputVariables;

		public FsmEventMapping[] outputEvents;

		[NonSerialized]
		private int id;

		[NonSerialized]
		private bool initialized;

		[NonSerialized]
		private bool updateInputs;

		[NonSerialized]
		private bool updateOutputs;

		[NonSerialized]
		private bool updateEvents;

		[NonSerialized]
		private Fsm runFsm;

		public FsmTemplate fsmTemplate
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public PlayMakerFSM fsmComponent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject fsmGameObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Fsm targetFsm => null;

		public FsmVariables fsmVariables => null;

		public FsmVariables updateVariables => null;

		public int ID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool ShowInputs => false;

		public bool ShowOutputs => false;

		public bool ShowEvents => false;

		public Fsm RunFsm
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		private FsmTemplateControl()
		{
		}

		public FsmTemplateControl(TargetType targetType = TargetType.FsmTemplate)
		{
		}

		public FsmTemplateControl(FsmTemplateControl source)
		{
		}

		public void SetFsmTemplate(FsmTemplate template)
		{
		}

		public void SetFsmComponent(PlayMakerFSM fsm)
		{
		}

		public void SetUpdates(bool inputs, bool outputs, bool events)
		{
		}

		public void Reinitialize()
		{
		}

		public Fsm InstantiateFsm()
		{
			return null;
		}

		public void InitFsm()
		{
		}

		public void UpdateInputs()
		{
		}

		private static FsmVarOverride[] CopyOverrides(FsmTemplateControl source)
		{
			return null;
		}

		private static FsmVarOverride[] CopyOutputVariables(FsmTemplateControl source)
		{
			return null;
		}

		private static FsmEventMapping[] CopyOutputEvents(FsmTemplateControl source)
		{
			return null;
		}

		private void ResetOverrides()
		{
		}

		public void Init()
		{
		}

		private void InitOverrides()
		{
		}

		public void UpdateValues()
		{
		}

		public void ApplyOverrides(Fsm overrideFsm)
		{
		}

		public void UpdateOutput(Fsm fsm)
		{
		}

		public FsmEvent MapEvent(FsmEvent fsmEvent)
		{
			return null;
		}

		[Conditional("DEBUG_LOG")]
		private void DebugLog(object message, LogColor logColor = LogColor.None)
		{
		}
	}
}
