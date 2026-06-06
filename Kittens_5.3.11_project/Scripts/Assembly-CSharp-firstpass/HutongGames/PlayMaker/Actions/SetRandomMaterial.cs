using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Material)]
	[Tooltip("Sets a Game Object's material randomly from an array of Materials.")]
	public class SetRandomMaterial : ComponentAction<Renderer>
	{
		[RequiredField]
		[CheckForComponent(typeof(Renderer))]
		[Tooltip("The GameObject that the material is applied to.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The index of the material on the object.")]
		public FsmInt materialIndex;

		[Tooltip("Array of materials to randomly select from.")]
		public FsmMaterial[] materials;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetRandomMaterial()
		{
		}
	}
}
