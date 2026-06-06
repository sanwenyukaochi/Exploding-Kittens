using System;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUIElement)]
	[Obsolete("GUIElement is part of the legacy UI system removed in 2019.3")]
	[Tooltip("Performs a Hit Test on a Game Object with a GUITexture or GUIText component.")]
	public class GUIElementHitTest : FsmStateAction
	{
		[ActionSection("Obsolete. Use Unity UI instead.")]
		[Tooltip("The GameObject that has a GUITexture or GUIText component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Specify camera or use MainCamera as default.")]
		public Camera camera;

		[Tooltip("A vector position on screen. Usually stored by actions like GetTouchInfo, or World To Screen Point.")]
		public FsmVector3 screenPoint;

		[Tooltip("Specify screen X coordinate.")]
		public FsmFloat screenX;

		[Tooltip("Specify screen Y coordinate.")]
		public FsmFloat screenY;

		[Tooltip("Whether the specified screen coordinates are normalized (0-1).")]
		public FsmBool normalized;

		[Tooltip("Event to send if the Hit Test is true.")]
		public FsmEvent hitEvent;

		[Tooltip("Store the result of the Hit Test in a bool variable (true/false).")]
		[UIHint(UIHint.Variable)]
		public FsmBool storeResult;

		[Tooltip("Repeat every frame. Useful if you want to wait for the hit test to return true.")]
		public FsmBool everyFrame;

		private GameObject gameObjectCached;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
