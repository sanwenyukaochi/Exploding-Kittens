using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace HutongGames.PlayMaker
{
	public abstract class FsmStateAction : IFsmStateAction
	{
		public static Color ActiveHighlightColor;

		public static bool Repaint;

		private string name;

		private bool enabled;

		private bool isOpen;

		private bool active;

		private bool finished;

		private bool autoName;

		private bool blocksFinish;

		private GameObject owner;

		[NonSerialized]
		private FsmState fsmState;

		[NonSerialized]
		private Fsm fsm;

		[NonSerialized]
		private PlayMakerFSM fsmComponent;

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

		public string DisplayName { get; set; }

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

		public GameObject Owner
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public FsmState State
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool Enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsOpen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsAutoNamed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool Entered { get; set; }

		public bool Finished
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool BlocksFinish
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool HandlesOnEvent
		{
			set
			{
			}
		}

		public bool Active
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual void Init(FsmState state)
		{
		}

		public virtual void InitEditor(Fsm fsmOwner)
		{
		}

		public virtual void Reset()
		{
		}

		public void BaseReset()
		{
		}

		public virtual void OnPreprocess()
		{
		}

		public virtual void Awake()
		{
		}

		public virtual bool Event(FsmEvent fsmEvent)
		{
			return false;
		}

		public void Finish()
		{
		}

		public Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		public void StopCoroutine(Coroutine routine)
		{
		}

		public virtual void OnEnter()
		{
		}

		public virtual void OnFixedUpdate()
		{
		}

		public virtual void OnUpdate()
		{
		}

		public virtual void OnGUI()
		{
		}

		public virtual void OnLateUpdate()
		{
		}

		public virtual void OnExit()
		{
		}

		public virtual void OnDrawActionGizmos()
		{
		}

		public virtual void OnDrawActionGizmosSelected()
		{
		}

		public virtual string AutoName()
		{
			return null;
		}

		public virtual void OnActionTargetInvoked(object targetObject)
		{
		}

		public virtual float GetProgress()
		{
			return 0f;
		}

		public virtual void DoCollisionEnter(Collision collisionInfo)
		{
		}

		public virtual void DoCollisionStay(Collision collisionInfo)
		{
		}

		public virtual void DoCollisionExit(Collision collisionInfo)
		{
		}

		public virtual void DoTriggerEnter(Collider other)
		{
		}

		public virtual void DoTriggerStay(Collider other)
		{
		}

		public virtual void DoTriggerExit(Collider other)
		{
		}

		public virtual void DoParticleCollision(GameObject other)
		{
		}

		public virtual void DoCollisionEnter2D(Collision2D collisionInfo)
		{
		}

		public virtual void DoCollisionStay2D(Collision2D collisionInfo)
		{
		}

		public virtual void DoCollisionExit2D(Collision2D collisionInfo)
		{
		}

		public virtual void DoTriggerEnter2D(Collider2D other)
		{
		}

		public virtual void DoTriggerStay2D(Collider2D other)
		{
		}

		public virtual void DoTriggerExit2D(Collider2D other)
		{
		}

		public virtual void DoControllerColliderHit(ControllerColliderHit collider)
		{
		}

		public virtual void DoJointBreak(float force)
		{
		}

		public virtual void DoJointBreak2D(Joint2D joint)
		{
		}

		public virtual void DoAnimatorMove()
		{
		}

		public virtual void DoAnimatorIK(int layerIndex)
		{
		}

		public void Log(string text)
		{
		}

		public void LogWarning(string text)
		{
		}

		public void LogError(string text)
		{
		}

		public virtual string ErrorCheck()
		{
			return null;
		}

		protected static bool TagMatches(FsmString tag, Component other)
		{
			return false;
		}

		protected static bool TagMatches(FsmString tag, Collision collisionInfo)
		{
			return false;
		}

		protected static bool TagMatches(FsmString tag, Collision2D collisionInfo)
		{
			return false;
		}

		protected static bool TagMatches(FsmString tag, ControllerColliderHit collisionInfo)
		{
			return false;
		}

		protected static bool TagMatches(FsmString tag, GameObject go)
		{
			return false;
		}

		[Conditional("DEBUG_LOG")]
		private void DebugLog(object message, LogColor logColor = LogColor.None)
		{
		}
	}
}
