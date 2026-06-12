using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Turns a Game Object on/off in a regular repeating pattern.")]
	[ActionCategory(ActionCategory.Effects)]
	public class Blink : ComponentAction<Renderer>
	{
		[Tooltip("The Game Object to blink on/off.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Time to stay off in seconds.")]
		[HasFloatSlider(0f, 5f)]
		public FsmFloat timeOff;

		[HasFloatSlider(0f, 5f)]
		[Tooltip("Time to stay on in seconds.")]
		public FsmFloat timeOn;

		[Tooltip("Start in the on state.")]
		public FsmBool startOn;

		[Tooltip("Only effect the renderer, keeping other components active.")]
		public bool rendererOnly;

		[Tooltip("Ignore TimeScale. Useful if the game is paused.")]
		public bool realTime;

		private float startTime;

		private float timer;

		private bool blinkOn;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void UpdateBlinkState(bool state)
		{
		}
	}
}
