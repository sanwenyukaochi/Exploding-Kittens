using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics)]
	[HelpUrl("http://hutonggames.com/playmakerforum/index.php?topic=4734.0")]
	[Tooltip("Sets the Drag of a Game Object's Rigid Body.")]
	public class SetDrag : ComponentAction<Rigidbody>
	{
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("The GameObject that owns the RigidBody.")]
		public FsmOwnerDefault gameObject;

		[HasFloatSlider(0f, 10f)]
		[Tooltip("Set the Drag.")]
		[RequiredField]
		public FsmFloat drag;

		[Tooltip("Repeat every frame.")]
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

		private void DoSetDrag()
		{
		}
	}
}
