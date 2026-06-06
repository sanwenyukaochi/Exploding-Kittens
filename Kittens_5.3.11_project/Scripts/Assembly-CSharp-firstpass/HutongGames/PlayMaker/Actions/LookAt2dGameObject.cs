using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Transform)]
	[Tooltip("Rotates a 2d Game Object on it's z axis so its forward vector points at a Target.")]
	public class LookAt2dGameObject : FsmStateAction
	{
		[Tooltip("The GameObject to rotate.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The GameObject to Look At.")]
		public FsmGameObject targetObject;

		[Tooltip("Set the GameObject starting offset. In degrees. 0 if your object is facing right, 180 if facing left etc...")]
		public FsmFloat rotationOffset;

		[Tooltip("Draw a debug line from the GameObject to the Target.")]
		[Title("Draw Debug Line")]
		public FsmBool debug;

		[Tooltip("Color to use for the debug line.")]
		public FsmColor debugLineColor;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private GameObject go;

		private GameObject goTarget;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoLookAt()
		{
		}
	}
}
