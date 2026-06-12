using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Sets a named texture in a game object's material.")]
	public class SetMaterialTexture : ComponentAction<Renderer>
	{
		[CheckForComponent(typeof(Renderer))]
		[Tooltip("The GameObject that the material is applied to.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("GameObjects can have multiple materials. Specify an index to target a specific material.")]
		public FsmInt materialIndex;

		[Tooltip("Alternatively specify a Material instead of a GameObject and Index.")]
		public FsmMaterial material;

		[UIHint(UIHint.NamedTexture)]
		[Tooltip("A named parameter in the shader. Common names include: _MainTex, _BumpMap, _Cube...")]
		public FsmString namedTexture;

		[Tooltip("The texture to use.")]
		public FsmTexture texture;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetMaterialTexture()
		{
		}
	}
}
