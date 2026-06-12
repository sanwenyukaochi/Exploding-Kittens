using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sends an Event based on the Orientation of the mobile device.")]
	[ActionCategory(ActionCategory.Device)]
	public class DeviceOrientationEvent : FsmStateAction
	{
		[Tooltip("Note: If device is physically situated between discrete positions, as when (for example) rotated diagonally, system will report Unknown orientation.")]
		public DeviceOrientation orientation;

		[Tooltip("The event to send if the device orientation matches Orientation.")]
		public FsmEvent sendEvent;

		[Tooltip("Repeat every frame. Useful if you want to wait for the orientation to be true.")]
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

		private void DoDetectDeviceOrientation()
		{
		}
	}
}
