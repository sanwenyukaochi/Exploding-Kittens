using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("The eventType will be executed on all components on the GameObject that can handle it.")]
	public class UiEventSystemCurrentRayCastAll : FsmStateAction
	{
		[RequiredField]
		[Tooltip("The ScreenPosition in pixels")]
		public FsmVector3 screenPosition;

		[Tooltip("The ScreenPosition in a Vector2")]
		public FsmVector2 orScreenPosition2d;

		[Tooltip("GameObjects hit by the raycast")]
		[ArrayEditor(VariableType.GameObject, null, 0, 0, 65536)]
		[UIHint(UIHint.Variable)]
		public FsmArray gameObjectList;

		[UIHint(UIHint.Variable)]
		[Tooltip("Number of hits")]
		public FsmInt hitCount;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private PointerEventData pointer;

		private List<RaycastResult> raycastResults;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void ExecuteRayCastAll()
		{
		}
	}
}
