using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Physics)]
	[Tooltip("Controls whether physics affects the game object. See unity docs: <a href=\"http://unity3d.com/support/documentation/ScriptReference/Rigidbody-isKinematic.html\">IsKinematic</a>.")]
	public class SetIsKinematic : ComponentAction<Rigidbody>
	{
		[CheckForComponent(typeof(Rigidbody))]
		[RequiredField]
		[Tooltip("The Game Object to set.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("Set is kinematic true/false.")]
		public FsmBool isKinematic;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetIsKinematic()
		{
		}
	}
}
