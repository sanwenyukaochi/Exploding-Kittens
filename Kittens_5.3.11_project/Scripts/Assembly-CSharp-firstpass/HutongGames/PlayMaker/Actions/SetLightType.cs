using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Set Spot, Directional, or Point Light type.")]
	[ActionCategory(ActionCategory.Lights)]
	public class SetLightType : ComponentAction<Light>
	{
		[Tooltip("The Game Object with the Light Component.")]
		[CheckForComponent(typeof(Light))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Spot, directional, or point light.")]
		[ObjectType(typeof(LightType))]
		public FsmEnum lightType;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetLightType()
		{
		}
	}
}
