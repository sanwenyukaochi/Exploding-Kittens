using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Measures the Distance between a GameObject and a target GameObject/Position. If both GameObject and Position are defined, position is taken a local offset from the GameObject's position.")]
	[ActionCategory(ActionCategory.GameObject)]
	public class GetDistanceXYZ : ComponentAction<Transform>
	{
		[Tooltip("Measure distance from this GameObject.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("Measure distance to this GameObject (or set world position below).")]
		public FsmGameObject target;

		[Tooltip("World position or local offset from target GameObject, if defined.")]
		public FsmVector3 position;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the distance in a float variable.")]
		public FsmFloat storeDistance;

		[Tooltip("Space used to measure the distance in. E.g. along the world X axis or the GameObject's local X axis.")]
		public Space space;

		[Tooltip("Store the distance along the X axis.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat storeXDistance;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the distance along the Y axis.")]
		public FsmFloat storeYDistance;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the distance along the Z axis.")]
		public FsmFloat storeZDistance;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private GameObject cachedTargetGameObject;

		private Transform targetTransform;

		private Transform gameObjectTransform => null;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetDistanceXYZ()
		{
		}
	}
}
