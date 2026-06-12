using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the material on a Game Object.")]
	[ActionCategory(ActionCategory.Material)]
	public class SetMaterial : ComponentAction<Renderer>
	{
		[RequiredField]
		[CheckForComponent(typeof(Renderer))]
		[Tooltip("A Game Object with a Renderer component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The index of the material on the object.")]
		public FsmInt materialIndex;

		[RequiredField]
		[Tooltip("The material to apply.")]
		public FsmMaterial material;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetMaterial()
		{
		}
	}
}
