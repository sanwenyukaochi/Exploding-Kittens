using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionTarget(typeof(AudioSource), "gameObject", false)]
	[ActionCategory(ActionCategory.Audio)]
	[ActionTarget(typeof(AudioClip), "oneShotClip", false)]
	[Tooltip("Plays the AudioClip defined in an Audio Source component on a GameObject. Set the clip using {{Set Audio Clip}}. Optionally plays a one shot Audio Clip.")]
	public class AudioPlay : ComponentAction<AudioSource>
	{
		[CheckForComponent(typeof(AudioSource))]
		[RequiredField]
		[Tooltip("The GameObject with an AudioSource component.")]
		public FsmOwnerDefault gameObject;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("Volume to play the sound at. Can be modified with {{Set Audio Volume}}.")]
		public FsmFloat volume;

		[Tooltip("Optionally play a 'one shot' AudioClip. NOTE: Volume cannot be adjusted while playing a 'one shot' AudioClip.")]
		[ObjectType(typeof(AudioClip))]
		public FsmObject oneShotClip;

		[Tooltip("Wait until the end of the clip to send the Finish Event. Set to false to send the finish event immediately.")]
		public FsmBool WaitForEndOfClip;

		[Tooltip("Send this event when the sound is finished playing. NOTE: currently also sent when the sound is paused...")]
		public FsmEvent finishedEvent;

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
