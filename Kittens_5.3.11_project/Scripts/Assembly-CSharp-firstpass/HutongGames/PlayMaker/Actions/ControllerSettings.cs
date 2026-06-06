using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Character)]
	[Tooltip("Modify various character controller settings.\n'None' leaves the setting unchanged.")]
	public class ControllerSettings : ComponentAction<CharacterController>
	{
		[RequiredField]
		[Tooltip("The GameObject that owns the CharacterController.")]
		[CheckForComponent(typeof(CharacterController))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The height of the character's capsule.")]
		public FsmFloat height;

		[Tooltip("The radius of the character's capsule.")]
		public FsmFloat radius;

		[Tooltip("The character controllers slope limit in degrees.")]
		public FsmFloat slopeLimit;

		[Tooltip("The character controllers step offset in meters.")]
		public FsmFloat stepOffset;

		[Tooltip("The center of the character's capsule relative to the transform's position")]
		public FsmVector3 center;

		[Tooltip("Should other RigidBodies or CharacterControllers collide with this character controller (By default always enabled).")]
		public FsmBool detectCollisions;

		[Tooltip("Repeat every frame while the state is active.")]
		public bool everyFrame;

		private CharacterController controller => null;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoControllerSettings()
		{
		}
	}
}
