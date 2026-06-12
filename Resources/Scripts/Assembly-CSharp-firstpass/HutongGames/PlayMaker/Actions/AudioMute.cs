using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Mute/un-mute the Audio Clip played by an Audio Source component on a Game Object.")]
	public class AudioMute : ComponentAction<AudioSource>
	{
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("The GameObject with an Audio Source component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Check to mute, uncheck to un-mute.")]
		[RequiredField]
		public FsmBool mute;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
