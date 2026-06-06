using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the position of a vertex in a GameObject's mesh. Hint: Use GetVertexCount to get the number of vertices in a mesh.")]
	[ActionCategory("Mesh")]
	public class GetVertexPosition : FsmStateAction
	{
		[RequiredField]
		[CheckForComponent(typeof(MeshFilter))]
		[Tooltip("The GameObject to check.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The index of the vertex.")]
		public FsmInt vertexIndex;

		[Tooltip("Coordinate system to use.")]
		public Space space;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the vertex position in a variable.")]
		[RequiredField]
		public FsmVector3 storePosition;

		[Tooltip("Repeat every frame. Useful if the mesh is animated.")]
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

		private void DoGetVertexPosition()
		{
		}
	}
}
