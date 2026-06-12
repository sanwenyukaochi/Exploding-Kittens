using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Sets the ScaleFactor of a CanvasScaler.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiCanvasScalerSetScaleFactor : ComponentAction<CanvasScaler>
	{
		[RequiredField]
		[CheckForComponent(typeof(CanvasScaler))]
		[Tooltip("The GameObject with a UI CanvasScaler component.")]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The scaleFactor of the UI CanvasScaler.")]
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

		private void DoSetValue()
		{
		}
	}
}
