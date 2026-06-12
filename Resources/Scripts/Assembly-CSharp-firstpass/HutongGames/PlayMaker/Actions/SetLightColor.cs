using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the Color of a Light.")]
	[ActionCategory(ActionCategory.Lights)]
	public class SetLightColor : ComponentAction<Light>
	{
		[RequiredField]
		[CheckForComponent(typeof(Light))]
		[Tooltip("The Game Object with the Light Component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The color of the light.")]
		public FsmColor lightColor;

		[Tooltip("Update every frame. Useful if the color is animated.")]
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

		private void DoSetLightColor()
		{
		}
	}
}
