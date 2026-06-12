using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Fade from a fullscreen Color. NOTE: Uses OnGUI so requires a PlayMakerGUI component in the scene.")]
	[ActionCategory(ActionCategory.Camera)]
	public class CameraFadeIn : FsmStateAction
	{
		[Tooltip("Color to fade from. E.g., Fade up from black.")]
		[RequiredField]
		public FsmColor color;

		[RequiredField]
		[HasFloatSlider(0f, 10f)]
		[Tooltip("Fade in time in seconds.")]
		public FsmFloat time;

		[Tooltip("Optional Event to send when finished.")]
		public FsmEvent finishEvent;

		[Tooltip("Ignore TimeScale. Useful if the game is paused.")]
		public bool realTime;

		private float startTime;

		private float currentTime;

		private Color colorLerp;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
