using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the Texture projected by a Light.")]
	[ActionCategory(ActionCategory.Lights)]
	public class SetLightCookie : ComponentAction<Light>
	{
		[RequiredField]
		[CheckForComponent(typeof(Light))]
		[Tooltip("The Game Object with the Light Component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The texture to project.")]
		public FsmTexture lightCookie;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetLightCookie()
		{
		}
	}
}
