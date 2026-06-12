using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Sets the placeholder of a UI InputField component. Optionally reset on exit")]
	public class UiInputFieldSetPlaceHolder : ComponentAction<InputField>
	{
		[Tooltip("The GameObject with the UI InputField component.")]
		[CheckForComponent(typeof(InputField))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[CheckForComponent(typeof(Graphic))]
		[RequiredField]
		[Tooltip("The placeholder (any graphic UI Component) for the UI InputField component.")]
		public FsmGameObject placeholder;

		[Tooltip("Reset when exiting this state.")]
		public FsmBool resetOnExit;

		private InputField inputField;

		private Graphic originalValue;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoSetValue()
		{
		}

		public override void OnExit()
		{
		}
	}
}
