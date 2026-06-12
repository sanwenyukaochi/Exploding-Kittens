using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace MGS.Debugging
{
	public class DebugFunctionParameterInput : MonoBehaviour
	{
		[SerializeField]
		private InputField m_InputField;

		[SerializeField]
		private Toggle m_Toggle;

		[SerializeField]
		private Text m_ParameterName;

		[SerializeField]
		private Dropdown m_Dropdown;

		private object m_Value;

		private ParameterInfo m_Parameter;

		public void SetParameter(ParameterInfo parameter)
		{
		}

		public object GetValue()
		{
			return null;
		}

		public void OnToggleValueChanged()
		{
		}

		public void OnInputValueChanged()
		{
		}

		public void OnDropdownValueChanged()
		{
		}
	}
}
