using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Sets the velocity of a game object with a rigid body. To leave any axis unchanged, set variable to 'None'.\nIn most cases you should not modify the velocity directly, as this can result in unrealistic behaviour. See unity docs: <a href=\"http://unity3d.com/support/documentation/ScriptReference/Rigidbody-velocity.html\">Rigidbody.velocity</a>.")]
	public class SetVelocity : ComponentAction<Rigidbody>
	{
		[Tooltip("The Game Object with the RigidBody component.")]
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Set velocity using Vector3 variable and/or individual channels below.")]
		public FsmVector3 vector;

		[Tooltip("Velocity in X axis.")]
		public FsmFloat x;

		[Tooltip("Velocity in Y axis.")]
		public FsmFloat y;

		[Tooltip("Velocity in Z axis.")]
		public FsmFloat z;

		[Tooltip("You can set velocity in world or local space.")]
		public Space space;

		[Tooltip("Set the velocity every frame.")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnPreprocess()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnFixedUpdate()
		{
		}

		private void DoSetVelocity()
		{
		}
	}
}
