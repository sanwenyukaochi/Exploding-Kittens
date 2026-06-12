using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get a material at index on a gameObject and store it in a variable")]
	[ActionCategory(ActionCategory.Material)]
	public class GetMaterial : ComponentAction<Renderer>
	{
		[RequiredField]
		[CheckForComponent(typeof(Renderer))]
		[Tooltip("The GameObject the Material is applied to.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The index of the Material in the Materials array.")]
		public FsmInt materialIndex;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Tooltip("Store the material in a variable.")]
		public FsmMaterial material;

		[Tooltip("Get the shared material of this object. NOTE: Modifying the shared material will change the appearance of all objects using this material, and change material settings that are stored in the project too.")]
		public bool getSharedMaterial;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetMaterial()
		{
		}
	}
}
