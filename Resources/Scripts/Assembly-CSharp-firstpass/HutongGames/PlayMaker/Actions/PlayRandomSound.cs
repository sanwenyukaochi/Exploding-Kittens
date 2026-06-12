using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Plays a Random Audio Clip at a position defined by a Game Object or a Vector3. If a position is defined, it takes priority over the game object. You can set the relative weight of the clips to control how often they are selected.")]
	public class PlayRandomSound : FsmStateAction
	{
		[Tooltip("The GameObject to play the sound.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Use world position instead of GameObject.")]
		public FsmVector3 position;

		[Tooltip("A possible Audio Clip choice.")]
		[ObjectType(typeof(AudioClip))]
		[CompoundArray("Audio Clips", "Audio Clip", "Weight")]
		public FsmObject[] audioClips;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("The relative probability of this sound being picked. E.g. a weight of 0.5 is half as likely to be picked as a weight of 1.")]
		public FsmFloat[] weights;

		[Tooltip("Volume to play the sound at.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat volume;

		[Tooltip("Don't play the same sound twice in a row")]
		public FsmBool noRepeat;

		private int randomIndex;

		private int lastIndex;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoPlayRandomClip()
		{
		}
	}
}
