using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends Events based on mouse interactions with a Game Object: MouseOver, MouseDown, MouseUp, MouseOff. Use Ray Distance to set how close the camera must be to pick the object.\nNOTE: Picking uses the Main Camera, so you must have a Camera in the scene tagged as Main Camera.")]
	[ActionCategory(ActionCategory.Input)]
	[ActionTarget(typeof(GameObject), "GameObject", false)]
	public class MousePickEvent : FsmStateAction
	{
		[CheckForComponent(typeof(Collider))]
		[Tooltip("The game object to test for mouse picking.")]
		public FsmOwnerDefault GameObject;

		[Tooltip("Length of the ray to cast from the camera.")]
		public FsmFloat rayDistance;

		[Tooltip("Event to send when the mouse is over the GameObject.")]
		public FsmEvent mouseOver;

		[Tooltip("Event to send when the mouse is pressed while over the GameObject.")]
		public FsmEvent mouseDown;

		[Tooltip("Event to send when the mouse is released while over the GameObject.")]
		public FsmEvent mouseUp;

		[Tooltip("Event to send when the mouse moves off the GameObject.")]
		public FsmEvent mouseOff;

		[Tooltip("Pick only from these layers.")]
		[UIHint(UIHint.Layer)]
		public FsmInt[] layerMask;

		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoMousePickEvent()
		{
		}

		private bool DoRaycast()
		{
			return false;
		}

		public override string ErrorCheck()
		{
			return null;
		}
	}
}
