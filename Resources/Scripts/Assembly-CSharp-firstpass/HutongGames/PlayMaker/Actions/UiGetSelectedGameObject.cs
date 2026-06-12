using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Returns the EventSystem's currently select GameObject.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiGetSelectedGameObject : FsmStateAction
	{
		[UIHint(UIHint.Variable)]
		[Tooltip("The currently selected GameObject")]
		public FsmGameObject StoreGameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Event sent when the selected GameObject changes")]
		public FsmEvent ObjectChangedEvent;

		[UIHint(UIHint.Variable)]
		[Tooltip("If true, each frame will check the currently selected GameObject")]
		public bool everyFrame;

		private GameObject lastGameObject;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void GetCurrentSelectedGameObject()
		{
		}
	}
}
