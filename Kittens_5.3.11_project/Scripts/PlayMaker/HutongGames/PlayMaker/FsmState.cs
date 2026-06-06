using System;
using System.Collections.Generic;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	[Serializable]
	public class FsmState : INameable
	{
		private bool active;

		private bool finished;

		private FsmStateAction activeAction;

		private int activeActionIndex;

		[NonSerialized]
		private Fsm fsm;

		[SerializeField]
		private string name;

		[SerializeField]
		[TextArea(0, 5)]
		private string description;

		[SerializeField]
		private byte colorIndex;

		[SerializeField]
		private Rect position;

		[SerializeField]
		private bool isBreakpoint;

		[SerializeField]
		private bool isSequence;

		[SerializeField]
		private bool hideUnused;

		[SerializeField]
		private FsmTransition[] transitions;

		[NonSerialized]
		private FsmStateAction[] actions;

		[SerializeField]
		private ActionData actionData;

		[NonSerialized]
		public bool HandlesOnEvent;

		[NonSerialized]
		private List<FsmStateAction> activeActions;

		[NonSerialized]
		private List<FsmStateAction> _finishedActions;

		public float StateTime { get; private set; }

		public float StateRealTime => 0f;

		public float RealStartTime { get; private set; }

		public int loopCount { get; private set; }

		public int maxLoopCount { get; private set; }

		public bool HasErrors { get; set; }

		public List<FsmStateAction> ActiveActions => null;

		private List<FsmStateAction> finishedActions => null;

		public bool Active => false;

		public FsmStateAction ActiveAction => null;

		public bool IsInitialized => false;

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

		public bool IsSequence
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int ActiveActionIndex => 0;

		public Rect Position
		{
			get
			{
				return default(Rect);
			}
			set
			{
			}
		}

		public bool IsBreakpoint
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HideUnused
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public FsmStateAction[] Actions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ActionsLoaded => false;

		public ActionData ActionData => null;

		public FsmTransition[] Transitions
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public int ColorIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static string GetFullStateLabel(FsmState state)
		{
			return null;
		}

		public FsmState(Fsm fsm)
		{
		}

		public FsmState(FsmState source)
		{
		}

		public void CopyActionData(FsmState state)
		{
		}

		public void LoadActions()
		{
		}

		public void SaveActions()
		{
		}

		public void OnEnter()
		{
		}

		private bool ActivateActions(int startIndex)
		{
			return false;
		}

		public bool OnEvent(FsmEvent fsmEvent)
		{
			return false;
		}

		public void OnFixedUpdate()
		{
		}

		public void OnUpdate()
		{
		}

		public void OnLateUpdate()
		{
		}

		public bool OnAnimatorMove()
		{
			return false;
		}

		public bool OnAnimatorIK(int layerIndex)
		{
			return false;
		}

		public bool OnCollisionEnter(Collision collisionInfo)
		{
			return false;
		}

		public bool OnCollisionStay(Collision collisionInfo)
		{
			return false;
		}

		public bool OnCollisionExit(Collision collisionInfo)
		{
			return false;
		}

		public bool OnTriggerEnter(Collider other)
		{
			return false;
		}

		public bool OnTriggerStay(Collider other)
		{
			return false;
		}

		public bool OnTriggerExit(Collider other)
		{
			return false;
		}

		public bool OnParticleCollision(GameObject other)
		{
			return false;
		}

		public bool OnCollisionEnter2D(Collision2D collisionInfo)
		{
			return false;
		}

		public bool OnCollisionStay2D(Collision2D collisionInfo)
		{
			return false;
		}

		public bool OnCollisionExit2D(Collision2D collisionInfo)
		{
			return false;
		}

		public bool OnTriggerEnter2D(Collider2D other)
		{
			return false;
		}

		public bool OnTriggerStay2D(Collider2D other)
		{
			return false;
		}

		public bool OnTriggerExit2D(Collider2D other)
		{
			return false;
		}

		public bool OnControllerColliderHit(ControllerColliderHit collider)
		{
			return false;
		}

		public bool OnJointBreak(float force)
		{
			return false;
		}

		public bool OnJointBreak2D(Joint2D joint)
		{
			return false;
		}

		public void OnGUI()
		{
		}

		public void FinishAction(FsmStateAction action)
		{
		}

		private void RemoveFinishedActions()
		{
		}

		private void CheckAllActionsFinished()
		{
		}

		public void OnExit()
		{
		}

		public void ResetLoopCount()
		{
		}

		public FsmTransition GetTransition(int transitionIndex)
		{
			return null;
		}

		public FsmEvent GetTransitionEvent(int transitionIndex)
		{
			return null;
		}

		public int GetTransitionIndex(FsmTransition transition)
		{
			return 0;
		}

		public static int GetStateIndex(FsmState state)
		{
			return 0;
		}

		public bool HasTransition(FsmTransition transition)
		{
			return false;
		}

		public bool HasFinishedTransition()
		{
			return false;
		}

		public List<FsmTransition> GetGlobalTransitions()
		{
			return null;
		}
	}
}
