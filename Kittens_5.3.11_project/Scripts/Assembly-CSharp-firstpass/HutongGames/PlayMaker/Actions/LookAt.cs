using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Rotates a Game Object so its forward vector points at a Target. The Target can be specified as a GameObject or a world Position. If you specify both, then Position specifies a local offset from the target object's Position.")]
	public class LookAt : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject to rotate.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("The GameObject to Look At.")]
		public FsmGameObject targetObject;

		[Tooltip("World position to look at, or local offset from Target Object if specified.")]
		public FsmVector3 targetPosition;

		[Tooltip("Rotate the GameObject to point its up direction vector in the direction hinted at by the Up Vector. See Unity Look At docs for more details.")]
		public FsmVector3 upVector;

		[Tooltip("Don't rotate vertically.")]
		public FsmBool keepVertical;

		[Title("Draw Debug Line")]
		[Tooltip("Draw a debug line from the GameObject to the Target.")]
		public FsmBool debug;

		[Tooltip("Color to use for the debug line.")]
		public FsmColor debugLineColor;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private GameObject go;

		private GameObject goTarget;

		private Vector3 lookAtPos;

		private Vector3 lookAtPosWithVertical;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnLateUpdate()
		{
		}

		private void DoLookAt()
		{
		}

		public bool UpdateLookAtPosition()
		{
			return false;
		}

		public Vector3 GetLookAtPosition()
		{
			return default(Vector3);
		}

		public Vector3 GetLookAtPositionWithVertical()
		{
			return default(Vector3);
		}
	}
}
