using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets a named color value in a Game Object's material.\n\nNote: With URP and HDRP set NamedColor to _BaseColor instead of _Color")]
	[ActionCategory(ActionCategory.Material)]
	public class SetMaterialColor : ComponentAction<Renderer>
	{
		[Tooltip("The GameObject that the material is applied to.")]
		[CheckForComponent(typeof(Renderer))]
		public FsmOwnerDefault gameObject;

		[Tooltip("GameObjects can have multiple materials. Specify an index to target a specific material.")]
		public FsmInt materialIndex;

		[Tooltip("Alternatively specify a Material instead of a GameObject and Index.")]
		public FsmMaterial material;

		[UIHint(UIHint.NamedColor)]
		[Tooltip("The named color.\nNote: With URP and HDRP set NamedColor to _BaseColor instead of _Color.\nSee unity docs: <a href=\"https://docs.unity3d.com/ScriptReference/Material.SetColor.html\" rel=\"nofollow\">Material.SetColor</a>")]
		public FsmString namedColor;

		[Tooltip("Set the parameter value.")]
		[RequiredField]
		public FsmColor color;

		[Tooltip("Repeat every frame. Useful if the value is animated.")]
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

		private void DoSetMaterialColor()
		{
		}
	}
}
