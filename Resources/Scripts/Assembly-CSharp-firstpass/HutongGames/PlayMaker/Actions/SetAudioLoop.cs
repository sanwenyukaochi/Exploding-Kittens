using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Sets looping on the AudioSource component on a Game Object.")]
	public class SetAudioLoop : ComponentAction<AudioSource>
	{
		[Tooltip("A GameObject with an AudioSource component.")]
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		public FsmOwnerDefault gameObject;

		[Tooltip("Set the Audio Source looping.")]
		public FsmBool loop;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
