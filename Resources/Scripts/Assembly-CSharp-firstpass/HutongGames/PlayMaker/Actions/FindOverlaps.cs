using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Find overlaps with GameObject colliders in the scene.")]
	public class FindOverlaps : ComponentAction<Transform>
	{
		public enum Shape
		{
			Box = 0,
			Sphere = 1,
			Capsule = 2
		}

		[Tooltip("GameObject position to use for the test shape. Set to none to use world origin (0,0,0).")]
		public FsmOwnerDefault position;

		[Tooltip("Offset position of the shape.")]
		public FsmVector3 offset;

		[Tooltip("Shape to find overlaps against.")]
		public Shape shape;

		[HideIf("HideRadius")]
		[Tooltip("Radius of sphere/capsule.")]
		public FsmFloat radius;

		[HideIf("HideBox")]
		[Tooltip("Size of box.")]
		public FsmVector3 box;

		[Tooltip("The height of the capsule.")]
		[HideIf("HideCapsule")]
		public FsmFloat height;

		[Tooltip("Maximum number of overlaps to detect.")]
		public FsmInt maxOverlaps;

		[Tooltip("LayerMask name to filter the overlapping objects")]
		[ActionSection("Filter")]
		[UIHint(UIHint.LayerMask)]
		public FsmInt layerMask;

		[Tooltip("Invert the mask, so you pick from all layers except those defined above.")]
		public FsmBool invertMask;

		[Tooltip("Include self in the array.")]
		public FsmBool includeSelf;

		[Tooltip("Set how often to cast a ray. 0 = once, don't repeat; 1 = everyFrame; 2 = every other frame... \nBecause Overlaps can get expensive use the highest repeat interval you can get away with.")]
		public FsmInt repeatInterval;

		[ActionSection("Output")]
		[UIHint(UIHint.Variable)]
		[ArrayEditor(VariableType.GameObject, null, 0, 0, 65536)]
		[Tooltip("Store overlapping GameObjects in an array.")]
		public FsmArray storeOverlapping;

		[Tooltip("Event to send if overlaps were found.")]
		public FsmEvent foundOverlaps;

		[Tooltip("Event to send if no overlaps were found.")]
		public FsmEvent noOverlaps;

		[ActionSection("Debug")]
		[Tooltip("The color to use for the debug line.")]
		public FsmColor debugColor;

		[Tooltip("Draw a gizmo in the scene view to visualize the shape.")]
		public FsmBool debug;

		private Collider[] colliders;

		private int repeat;

		public Vector3 center { get; private set; }

		public Quaternion orientation { get; private set; }

		public Vector3 capsulePoint1 { get; private set; }

		public Vector3 capsulePoint2 { get; private set; }

		public int targetMask { get; private set; }

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public bool HideBox()
		{
			return false;
		}

		public bool HideRadius()
		{
			return false;
		}

		public bool HideCapsule()
		{
			return false;
		}

		public override void OnEnter()
		{
		}

		public override void OnFixedUpdate()
		{
		}

		private void DoGetOverlap()
		{
		}

		public void InitShapeCenter()
		{
		}
	}
}
