using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Camera)]
	[Tooltip("Sets the Main Camera.")]
	public class SetMainCamera : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The GameObject to set as the main camera (should have a Camera component).")]
		[CheckForComponent(typeof(Camera))]
		public FsmGameObject gameObject;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}
	}
}
