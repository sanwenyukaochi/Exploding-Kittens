using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Forces a rigid body to sleep at least one frame. See unity docs: <a href=\"http://unity3d.com/support/documentation/ScriptReference/Rigidbody.Sleep.html\">Rigidbody.sleep</a>.")]
	public class Sleep : ComponentAction<Rigidbody>
	{
		[Tooltip("A Game Object with a Rigid Body.")]
		[CheckForComponent(typeof(Rigidbody))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSleep()
		{
		}
	}
}
