using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Get the ScaleFactor of a CanvasScaler.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiCanvasScalerGetScaleFactor : ComponentAction<CanvasScaler>
	{
		[RequiredField]
		[Tooltip("The GameObject with a UI CanvasScaler component.")]
		[CheckForComponent(typeof(CanvasScaler))]
		public FsmOwnerDefault gameObject;

		[Tooltip("The scaleFactor of the CanvasScaler component.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmFloat scaleFactor;

		[Tooltip("Repeats every frame, useful for animation")]
		public bool everyFrame;

		private CanvasScaler component;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetValue()
		{
		}
	}
}
