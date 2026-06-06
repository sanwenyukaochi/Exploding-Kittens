using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

namespace MGS.Debugging
{
	public class DebugSettings : MonoBehaviour
	{
		[SerializeField]
		private Button m_CloseButton;

		[SerializeField]
		private SettingToggle[] m_Toggles;

		private MethodInfo[] m_DebugFunctions;

		[SerializeField]
		private GameObject m_DebugFunctionEntry;

		[SerializeField]
		private GameObject m_DebugFunctionsContent;

		[SerializeField]
		private GameObject m_DebugFunctionPopup;

		[SerializeField]
		private Text m_DebugFunctionName;

		[SerializeField]
		private Text m_DebugFunctionDescription;

		[SerializeField]
		private Transform m_DebugFunctionParameterParent;

		[SerializeField]
		private Button m_ExecuteDebugFunctionButton;

		[SerializeField]
		private GameObject m_DebugFunctionsPanel;

		[SerializeField]
		private Transform m_DebugChannelsParent;

		[SerializeField]
		private GameObject m_DebugChannelEntry;

		[SerializeField]
		private GameObject m_ReportForm;

		[SerializeField]
		private InputField m_ReportText;

		[SerializeField]
		private GameObject m_ReportRecipientEntry;

		[SerializeField]
		private Transform m_ReportRecipientsParent;

		[SerializeField]
		private Dropdown m_SessionsDropdown;

		[SerializeField]
		private Button m_AddRecipientButton;

		[SerializeField]
		private InputField m_AddRecipientField;

		private Dictionary<string, bool> m_ChannelExpandStates;

		private Dictionary<string, Button> m_ChannelButtons;

		private Dictionary<string, Toggle> m_RecipientToggles;

		private MethodInfo m_PendingMethod;

		private List<DebugFunctionParameterInput> m_ParameterInputs;

		private void Start()
		{
		}

		public void ToggleAll()
		{
		}

		private void _AddChannel(string channel, int siblingIndex = -1)
		{
		}

		private void _RemoveChannel(string channel)
		{
		}

		private string[] _GetNestedChannels(string channel, bool allLevels = false)
		{
			return null;
		}

		private bool _HasNestedChannels(string channel)
		{
			return false;
		}

		private bool _IsNestedChannel(string channel)
		{
			return false;
		}

		private void _UpdateButtonColor(Button button, string channel)
		{
		}

		private void _ShowFunctionPopup(string name, MethodInfo method)
		{
		}

		public void OnExecuteDebugFunction()
		{
		}

		public void CloseFunctionPopup()
		{
		}

		private bool _AllParametersValid()
		{
			return false;
		}

		private void Update()
		{
		}

		public static bool IsEnabled(string type)
		{
			return false;
		}

		public void OpenReport()
		{
		}

		private void _PopulateReportRecipients()
		{
		}

		public void SendReport()
		{
		}

		public void CancelReport()
		{
		}

		public void AddRecipientPressed()
		{
		}

		public void RecipientFieldChanged()
		{
		}
	}
}
