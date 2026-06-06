using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.UI)]
	[Tooltip("Gets the text value of a UI InputField component as a float.")]
	public class UiInputFieldGetTextAsFloat : ComponentAction<InputField>
	{
		[Tooltip("The GameObject with the UI InputField component.")]
		[RequiredField]
		[CheckForComponent(typeof(InputField))]
		public FsmOwnerDefault gameObject;

		[RequiredField]
		[Tooltip("The text value as a float of the UI InputField component.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat value;

		[UIHint(UIHint.Variable)]
		[Tooltip("true if text resolves to a float")]
		public FsmBool isFloat;

		[Tooltip("true if text resolves to a float")]
		public FsmEvent isFloatEvent;

		[Tooltip("Event sent if text does not resolves to a float")]
		public FsmEvent isNotFloatEvent;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private InputField inputField;

		private float _value;

		private bool _success;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoGetTextValue()
		{
		}
	}
}
