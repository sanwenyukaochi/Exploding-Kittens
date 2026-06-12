using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Audio)]
	[Tooltip("Sets the Volume of the Audio Clip played by the AudioSource component on a Game Object.")]
	public class SetAudioVolume : ComponentAction<AudioSource>
	{
		[RequiredField]
		[CheckForComponent(typeof(AudioSource))]
		[Tooltip("A GameObject with an AudioSource component.")]
		public FsmOwnerDefault gameObject;

		[HasFloatSlider(0f, 1f)]
		[Tooltip("Set the volume.")]
		public FsmFloat volume;

		[Tooltip("Repeat every frame. Useful if you're driving the volume with a float variable.")]
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

		private void DoSetAudioVolume()
		{
		}
	}
}
