using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Sets the Scale of a named texture in a Game Object's Material. Useful for special effects.")]
	public class SetTextureScale : ComponentAction<Renderer>
	{
		[RequiredField]
		[CheckForComponent(typeof(Renderer))]
		[Tooltip("The target Game Object.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The index of the material on the object.")]
		public FsmInt materialIndex;

		[UIHint(UIHint.NamedColor)]
		[Tooltip("The named texture. See unity docs: <a href=\"http://unity3d.com/support/documentation/ScriptReference/Material.SetTextureScale.html\" rel=\"nofollow\">SetTextureScale</a>")]
		public FsmString namedTexture;

		[RequiredField]
		[Tooltip("Scale in X axis. 2 = double the texture's width.")]
		public FsmFloat scaleX;

		[Tooltip("Scale in Y axis. 2 = double the texture's height.")]
		[RequiredField]
		public FsmFloat scaleY;

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

		private void DoSetTextureScale()
		{
		}
	}
}
