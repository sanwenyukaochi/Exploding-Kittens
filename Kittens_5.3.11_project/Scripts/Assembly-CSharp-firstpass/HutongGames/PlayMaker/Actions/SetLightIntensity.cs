using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Lights)]
	[Tooltip("Sets the Intensity of a Light.")]
	public class SetLightIntensity : ComponentAction<Light>
	{
		[CheckForComponent(typeof(Light))]
		[RequiredField]
		[Tooltip("The Game Object with the Light Component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The intensity of the light.")]
		public FsmFloat lightIntensity;

		[Tooltip("Update every frame. Useful if the intensity is animated.")]
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

		private void DoSetLightIntensity()
		{
		}
	}
}
