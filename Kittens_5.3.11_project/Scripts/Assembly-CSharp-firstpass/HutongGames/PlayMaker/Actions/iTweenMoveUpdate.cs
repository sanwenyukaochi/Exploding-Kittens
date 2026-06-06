using System.Collections;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Similar to MoveTo but incredibly less expensive for usage inside the Update function or similar looping situations involving a 'live' set of changing values. Does not utilize an EaseType.")]
	[ActionCategory("iTween")]
	public class iTweenMoveUpdate : FsmStateAction
	{
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Move From a transform rotation.")]
		public FsmGameObject transformPosition;

		[Tooltip("The position the GameObject will animate from.  If transformPosition is set, this is used as an offset.")]
		public FsmVector3 vectorPosition;

		[Tooltip("The time in seconds the animation will take to complete.")]
		public FsmFloat time;

		[Tooltip("Whether to animate in local or world space.")]
		public Space space;

		[ActionSection("LookAt")]
		[Tooltip("Whether or not the GameObject will orient to its direction of travel. False by default.")]
		public FsmBool orientToPath;

		[Tooltip("A target object the GameObject will look at.")]
		public FsmGameObject lookAtObject;

		[Tooltip("A target position the GameObject will look at.")]
		public FsmVector3 lookAtVector;

		[Tooltip("The time in seconds the object will take to look at either the Look At Target or Orient To Path. 0 by default")]
		public FsmFloat lookTime;

		[Tooltip("Restricts rotation to the supplied axis only.")]
		public iTweenFsmAction.AxisRestriction axis;

		private Hashtable hash;

		private GameObject go;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnExit()
		{
		}

		private void DoiTween()
		{
		}
	}
}
