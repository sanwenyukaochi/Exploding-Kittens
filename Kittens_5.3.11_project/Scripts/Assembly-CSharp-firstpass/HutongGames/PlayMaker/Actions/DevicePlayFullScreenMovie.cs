using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Plays a full-screen movie on a handheld device. Please consult the Unity docs for <a href=\"http://docs.unity3d.com/Documentation/ScriptReference/Handheld.PlayFullScreenMovie.html\">Handheld.PlayFullScreenMovie</a> for proper usage.\nNOTE: The action will warn you about platform requirements.")]
	public class DevicePlayFullScreenMovie : FsmStateAction
	{
		[Tooltip("Note that player will stream movie directly from the iPhone disc, therefore you have to provide movie as a separate files and not as an usual asset.\nYou will have to create a folder named StreamingAssets inside your Unity project (inside your Assets folder). Store your movies inside that folder. Unity will automatically copy contents of that folder into the iPhone application bundle.")]
		[RequiredField]
		public FsmString moviePath;

		[RequiredField]
		[Tooltip("This action will initiate a transition that fades the screen from your current content to the designated background color of the player. When playback finishes, the player uses another fade effect to transition back to your content.")]
		public FsmColor fadeColor;

		[Tooltip("Options for displaying movie playback controls. See Unity docs.")]
		public FullScreenMovieControlMode movieControlMode;

		[Tooltip("Scaling modes for displaying movies.. See Unity docs.")]
		public FullScreenMovieScalingMode movieScalingMode;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
