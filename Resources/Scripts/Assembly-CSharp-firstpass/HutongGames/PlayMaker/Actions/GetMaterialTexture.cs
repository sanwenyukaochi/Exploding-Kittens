using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get a texture from a material on a GameObject")]
	[ActionCategory(ActionCategory.Material)]
	public class GetMaterialTexture : ComponentAction<Renderer>
	{
		[RequiredField]
		[CheckForComponent(typeof(Renderer))]
		[Tooltip("The GameObject the Material is applied to.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The index of the Material in the Materials array.")]
		public FsmInt materialIndex;

		[Tooltip("The texture to get. See Unity Shader docs for names.")]
		[UIHint(UIHint.NamedTexture)]
		public FsmString namedTexture;

		[RequiredField]
		[UIHint(UIHint.Variable)]
		[Title("StoreTexture")]
		[Tooltip("Store the texture in a variable.")]
		public FsmTexture storedTexture;

		[Tooltip("Get the shared version of the texture.")]
		public bool getFromSharedMaterial;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetMaterialTexture()
		{
		}
	}
}
