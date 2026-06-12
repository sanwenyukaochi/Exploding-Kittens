using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the mass of a game object's rigid body. See unity docs: <a href=\"http://unity3d.com/support/documentation/ScriptReference/Rigidbody-mass.html\">Rigidbody.Mass</a>")]
	[ActionCategory(ActionCategory.Physics)]
	public class SetMass : ComponentAction<Rigidbody>
	{
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("A GameObject with a RigidBody component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[HasFloatSlider(0.1f, 10f)]
		[Tooltip("Set the mass. Unity recommends a mass between 0.1 and 10.")]
		public FsmFloat mass;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetMass()
		{
		}
	}
}
