using HutongGames.PlayMaker.TweenEnums;
using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Tween common AudioSource properties.")]
	[ActionCategory(ActionCategory.Tween)]
	[ActionTarget(typeof(AudioSource), null, false)]
	public class TweenAudio : TweenComponentBase<AudioSource>
	{
		public enum AudioProperty
		{
			Volume = 0,
			Pitch = 1
		}

		[Tooltip("Audio property to tween.")]
		public AudioProperty property;

		[Tooltip("Tween To/From values set below.")]
		public TweenDirection tweenDirection;

		[Tooltip("Value for the selected property.")]
		public FsmFloat value;

		private AudioSource audio;

		private float fromFloat;

		private float toFloat;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		protected override void DoTween()
		{
		}
	}
}
