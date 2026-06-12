using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the strength of the shadows cast by a Light.")]
	[ActionCategory(ActionCategory.Lights)]
	public class SetShadowStrength : ComponentAction<Light>
	{
		[RequiredField]
		[CheckForComponent(typeof(Light))]
		[Tooltip("The Game Object with the Light Component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The strength of the shadows. 1 = opaque, 0 = transparent.")]
		public FsmFloat shadowStrength;

		[Tooltip("Update every frame. Useful if the shadow strength is animated.")]
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

		private void DoSetShadowStrength()
		{
		}
	}
}
