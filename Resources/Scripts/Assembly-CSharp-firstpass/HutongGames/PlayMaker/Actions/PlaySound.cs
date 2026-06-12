using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Plays an Audio Clip at a position defined by a Game Object or Vector3. If a position is defined, it takes priority over the game object. This action doesn't require an Audio Source component, but offers less control than Audio actions.")]
	public class PlaySound : FsmStateAction
	{
		[Tooltip("A Game Object that defines a position.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("A Vector3 value that defines a world position (overrides Game Object).")]
		public FsmVector3 position;

		[Title("Audio Clip")]
		[ObjectType(typeof(AudioClip))]
		[Tooltip("The audio clip to play.")]
		[RequiredField]
		public FsmObject clip;

		[Tooltip("Volume to play sound at.")]
		[HasFloatSlider(0f, 1f)]
		public FsmFloat volume;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoPlaySound()
		{
		}
	}
}
