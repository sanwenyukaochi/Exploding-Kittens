using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Sends events when a GUI Texture or GUI Text is touched. Optionally filter by a fingerID.")]
	[Obsolete("GUIElement is part of the legacy UI system removed in 2019.3")]
	public class TouchGUIEvent : FsmStateAction
	{
		public enum OffsetOptions
		{
			TopLeft = 0,
			Center = 1,
			TouchStart = 2
		}

		[RequiredField]
		[ActionSection("Obsolete. Use Unity UI instead.")]
		[Tooltip("The Game Object that owns the GUI Texture or GUI Text.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Only detect touches that match this fingerID, or set to None.")]
		public FsmInt fingerId;

		[Tooltip("Event to send on touch began.")]
		[ActionSection("Events")]
		public FsmEvent touchBegan;

		[Tooltip("Event to send on touch moved.")]
		public FsmEvent touchMoved;

		[Tooltip("Event to send on stationary touch.")]
		public FsmEvent touchStationary;

		[Tooltip("Event to send on touch ended.")]
		public FsmEvent touchEnded;

		[Tooltip("Event to send on touch cancel.")]
		public FsmEvent touchCanceled;

		[Tooltip("Event to send if not touching (finger down but not over the GUI element)")]
		public FsmEvent notTouching;

		[Tooltip("Store the fingerId of the touch.")]
		[UIHint(UIHint.Variable)]
		[ActionSection("Store Results")]
		public FsmInt storeFingerId;

		[Tooltip("Store the screen position where the GUI element was touched.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeHitPoint;

		[Tooltip("Normalize the hit point screen coordinates (0-1).")]
		public FsmBool normalizeHitPoint;

		[Tooltip("Store the offset position of the hit.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeOffset;

		[Tooltip("How to measure the offset.")]
		public OffsetOptions relativeTo;

		[Tooltip("Normalize the offset.")]
		public FsmBool normalizeOffset;

		[ActionSection(null)]
		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private Vector3 touchStartPos;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
