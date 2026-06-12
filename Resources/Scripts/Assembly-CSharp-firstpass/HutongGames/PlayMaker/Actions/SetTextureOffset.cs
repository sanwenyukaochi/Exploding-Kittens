using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Sets the Offset of a named texture in a Game Object's Material. Useful for scrolling texture effects.")]
	public class SetTextureOffset : ComponentAction<Renderer>
	{
		[Tooltip("The target Game Object.")]
		[RequiredField]
		[CheckForComponent(typeof(Renderer))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The index of the material on the object.")]
		public FsmInt materialIndex;

		[RequiredField]
		[Tooltip("The named texture. See unity docs: <a href=\"http://unity3d.com/support/documentation/ScriptReference/Material.SetTextureOffset.html\" rel=\"nofollow\">SetTextureOffset</a>")]
		[UIHint(UIHint.NamedColor)]
		public FsmString namedTexture;

		[RequiredField]
		[Tooltip("The amount to offset in X axis. 1 = full width of texture.")]
		public FsmFloat offsetX;

		[RequiredField]
		[Tooltip("The amount to offset in Y axis. 1 = full height of texture.")]
		public FsmFloat offsetY;

		[Tooltip("Repeat every frame.")]
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

		private void DoSetTextureOffset()
		{
		}
	}
}
