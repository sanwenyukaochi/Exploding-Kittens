using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Gets the placeHolder GameObject of a UI InputField component.")]
	[ActionCategory(ActionCategory.UI)]
	public class UiInputFieldGetPlaceHolder : ComponentAction<InputField>
	{
		[CheckForComponent(typeof(InputField))]
		[Tooltip("The GameObject with the UI InputField component.")]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[UIHint(UIHint.Variable)]
		[Tooltip("Store the placeholder for the UI InputField component.")]
		public FsmGameObject placeHolder;

		[Tooltip("true if placeholder is found")]
		public FsmBool placeHolderDefined;

		[Tooltip("Event sent if no placeholder is defined")]
		public FsmEvent foundEvent;

		[Tooltip("Event sent if a placeholder is defined")]
		public FsmEvent notFoundEvent;

		private InputField inputField;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		private void DoGetValue()
		{
		}
	}
}
