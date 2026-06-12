using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Debug)]
	[Tooltip("Draw a debug Gizmo.\nNote: you can enable/disable Gizmos in the Game View toolbar.")]
	public class DebugDrawShape : ComponentAction<Transform>
	{
		public enum ShapeType
		{
			Sphere = 0,
			Cube = 1,
			WireSphere = 2,
			WireCube = 3
		}

		[Tooltip("Draw the Gizmo at a GameObject's position.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The type of Gizmo to draw:\nSphere, Cube, WireSphere, or WireCube.")]
		public ShapeType shape;

		[Tooltip("The color to use.")]
		public FsmColor color;

		[HideIf("HideRadius")]
		[Tooltip("Use this for sphere gizmos")]
		public FsmFloat radius;

		[Tooltip("Use this for cube gizmos")]
		[HideIf("HideSize")]
		public FsmVector3 size;

		public bool HideRadius()
		{
			return false;
		}

		public bool HideSize()
		{
			return false;
		}

		public override void Reset()
		{
		}

		public override void Awake()
		{
		}

		public override void OnDrawActionGizmos()
		{
		}
	}
}
