using System;
using HutongGames.PlayMaker.TweenEnums;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionTarget(typeof(Camera), null, false)]
	[Tooltip("Tween position of UI GameObjects.")]
	[ActionCategory(ActionCategory.Tween)]
	public class TweenUiPosition : TweenComponentBase<RectTransform>
	{
		[Tooltip("Setup where to tween from.")]
		[Title("Options")]
		[ActionSection("From")]
		public UiPositionOptions fromOption;

		[Tooltip("Optionally use a GameObject as the from position.")]
		public FsmGameObject fromTarget;

		[Tooltip("If a GameObject is specified, use this as an offset. Otherwise this is a world position.")]
		public FsmVector3 fromPosition;

		[Tooltip("Setup where to tween from.")]
		[ActionSection("To")]
		[Title("Options")]
		public UiPositionOptions toOption;

		[Tooltip("Optionally use a GameObject as the to position.")]
		public FsmGameObject toTarget;

		[Tooltip("If a GameObject is specified, use this as an offset. Otherwise this is a world position.")]
		public FsmVector3 toPosition;

		[NonSerialized]
		private RectTransform transform;

		[NonSerialized]
		private Transform fromTransform;

		[NonSerialized]
		private Transform toTransform;

		public Vector3 StartPosition { get; private set; }

		public Vector3 EndPosition { get; private set; }

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void InitStartPosition()
		{
		}

		private void InitEndPosition()
		{
		}

		protected override void DoTween()
		{
		}
	}
}
