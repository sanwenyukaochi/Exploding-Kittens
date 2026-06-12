using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Lights)]
	[Tooltip("Sets the Flare effect used by a Light.")]
	public class SetLightFlare : ComponentAction<Light>
	{
		[RequiredField]
		[Tooltip("The Game Object with the Light Component.")]
		[CheckForComponent(typeof(Light))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The flare to use.")]
		public Flare lightFlare;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetLightRange()
		{
		}
	}
}
