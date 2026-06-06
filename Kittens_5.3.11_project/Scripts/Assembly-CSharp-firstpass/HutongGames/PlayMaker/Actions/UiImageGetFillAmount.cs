using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Set The Fill Amount on a UI Image")]
	[ActionCategory(ActionCategory.UI)]
	public class UiImageGetFillAmount : ComponentAction<Image>
	{
		[Tooltip("The GameObject with the UI Image component.")]
		[CheckForComponent(typeof(Image))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The fill amount.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmFloat ImageFillAmount;

		[Tooltip("Repeats every frame")]
		public bool everyFrame;

		private Image image;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetFillAmount()
		{
		}
	}
}
