using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets pointer data on the last System Event.\nHINT: Use {{Hide Unused}} in the {{State Inspector}} to hide the unused parameters after selecting the ones you need.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiGetLastPointerDataInfo : FsmStateAction
	{
		public static PointerEventData lastPointerEventData;

		[Tooltip("Number of clicks in a row.")]
		[UIHint(UIHint.Variable)]
		public FsmInt clickCount;

		[Tooltip("The last time a click event was sent.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat clickTime;

		[Tooltip("Pointer delta since last update.")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 delta;

		[UIHint(UIHint.Variable)]
		[Tooltip("Is a drag operation currently occuring.")]
		public FsmBool dragging;

		[ObjectType(typeof(PointerEventData.InputButton))]
		[UIHint(UIHint.Variable)]
		[Tooltip("The InputButton for this event.")]
		public FsmEnum inputButton;

		[UIHint(UIHint.Variable)]
		[Tooltip("Is the pointer being pressed? (Not documented by Unity)")]
		public FsmBool eligibleForClick;

		[Tooltip("The camera associated with the last OnPointerEnter event.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject enterEventCamera;

		[UIHint(UIHint.Variable)]
		[Tooltip("The camera associated with the last OnPointerPress event.")]
		public FsmGameObject pressEventCamera;

		[Tooltip("Is the pointer moving.")]
		[UIHint(UIHint.Variable)]
		public FsmBool isPointerMoving;

		[UIHint(UIHint.Variable)]
		[Tooltip("Is scroll being used on the input device.")]
		public FsmBool isScrolling;

		[Tooltip("The GameObject for the last press event.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject lastPress;

		[Tooltip("The object that is receiving OnDrag.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject pointerDrag;

		[Tooltip("The object that received 'OnPointerEnter'.")]
		[UIHint(UIHint.Variable)]
		public FsmGameObject pointerEnter;

		[UIHint(UIHint.Variable)]
		[Tooltip("Id of the pointer (touch id).")]
		public FsmInt pointerId;

		[UIHint(UIHint.Variable)]
		[Tooltip("The GameObject that received the OnPointerDown.")]
		public FsmGameObject pointerPress;

		[Tooltip("Current pointer position.")]
		[UIHint(UIHint.Variable)]
		public FsmVector2 position;

		[UIHint(UIHint.Variable)]
		[Tooltip("Position of the press.")]
		public FsmVector2 pressPosition;

		[UIHint(UIHint.Variable)]
		[Tooltip("The object that the press happened on even if it can not handle the press event.")]
		public FsmGameObject rawPointerPress;

		[UIHint(UIHint.Variable)]
		[Tooltip("The amount of scroll since the last update.")]
		public FsmVector2 scrollDelta;

		[Tooltip("Is the event used?")]
		[UIHint(UIHint.Variable)]
		public FsmBool used;

		[Tooltip("Should a drag threshold be used?")]
		[UIHint(UIHint.Variable)]
		public FsmBool useDragThreshold;

		[Tooltip("The normal of the last raycast in world coordinates.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 worldNormal;

		[Tooltip("The world position of the last raycast.")]
		[UIHint(UIHint.Variable)]
		public FsmVector3 worldPosition;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
