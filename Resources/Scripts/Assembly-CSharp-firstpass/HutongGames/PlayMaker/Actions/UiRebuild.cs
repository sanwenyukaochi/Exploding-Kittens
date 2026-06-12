using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Rebuild a UI Graphic component.")]
	public class UiRebuild : ComponentAction<Graphic>
	{
		[Tooltip("The GameObject with the UI Graphic component.")]
		[CheckForComponent(typeof(Graphic))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("When to Update.")]
		public CanvasUpdate canvasUpdate;

		[Tooltip("Only Rebuild when state exits.")]
		public bool rebuildOnExit;

		private Graphic graphic;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoAction()
		{
		}

		public override void OnExit()
		{
		}
	}
}
