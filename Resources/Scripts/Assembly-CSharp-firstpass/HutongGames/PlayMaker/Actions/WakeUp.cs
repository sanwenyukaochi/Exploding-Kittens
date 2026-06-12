using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics)]
	[SeeAlso("<a href =\"http://unity3d.com/support/documentation/ScriptReference/Rigidbody.WakeUp.html\">Rigidbody.WakeUp</a>")]
	[Tooltip("Forces a Game Object's Rigid Body to wake up. See Unity Docs: <a href=\"http://unity3d.com/support/documentation/ScriptReference/Rigidbody.WakeUp.html\">Rigidbody.WakeUp</a>.")]
	public class WakeUp : ComponentAction<Rigidbody>
	{
		[RequiredField]
		[CheckForComponent(typeof(Rigidbody))]
		[Tooltip("The Game Object to wake up.")]
		public FsmOwnerDefault gameObject;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoWakeUp()
		{
		}
	}
}
