using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MGS.Debugging
{
	public class UILogEntry : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI m_Title;

		[SerializeField]
		private TextMeshProUGUI m_Content;

		[SerializeField]
		private Button m_Button;

		public void Set(string log, string type, string trace = "")
		{
		}
	}
}
