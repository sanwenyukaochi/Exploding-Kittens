using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker
{
	[AddComponentMenu("PlayMaker/UI/UI End Edit Event")]
	public class PlayMakerUiEndEditEvent : PlayMakerUiEventBase
	{
		public InputField inputField;

		public TMP_InputField tmpInputField;

		protected override void Initialize()
		{
		}

		protected void OnDisable()
		{
		}

		private void DoOnEndEdit(string value)
		{
		}
	}
}
