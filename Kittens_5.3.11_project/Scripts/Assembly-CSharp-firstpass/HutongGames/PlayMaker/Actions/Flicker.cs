using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Effects)]
	[Tooltip("Randomly flickers a Game Object on/off.")]
	public class Flicker : ComponentAction<Renderer>
	{
		[Tooltip("The GameObject to flicker.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("The frequency of the flicker in seconds.")]
		public FsmFloat frequency;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("Amount of time flicker is On (0-1). E.g. Use 0.95 for an occasional flicker.")]
		public FsmFloat amountOn;

		[Tooltip("Only effect the renderer, leaving other components active.")]
		public bool rendererOnly;

		[Tooltip("Ignore time scale. Useful if flickering UI when the game is paused.")]
		public bool realTime;

		private float startTime;

		private float timer;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}
	}
}
