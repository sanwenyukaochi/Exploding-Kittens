using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the Character Limit value of a UI InputField component. This is the maximum number of characters that the user can type into the field.")]
	public class UiInputFieldGetCharacterLimit : ComponentAction<InputField>
	{
		[Tooltip("The GameObject with the UI InputField component.")]
		[CheckForComponent(typeof(InputField))]
		[RequiredField]
		public FsmOwnerDefault gameObject;

		[Tooltip("The maximum number of characters that the user can type into the UI InputField component.")]
		[UIHint(UIHint.Variable)]
		[RequiredField]
		public FsmInt characterLimit;

		[Tooltip("Event sent if limit is infinite (equal to 0)")]
		public FsmEvent hasNoLimitEvent;

		[Tooltip("Event sent if limit is more than 0")]
		public FsmEvent isLimitedEvent;

		[Tooltip("Repeats every frame, useful for animation")]
		public bool everyFrame;

		private InputField inputField;

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
