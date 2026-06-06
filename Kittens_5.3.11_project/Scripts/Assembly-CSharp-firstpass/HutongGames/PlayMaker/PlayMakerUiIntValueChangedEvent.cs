using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker
{
	[AddComponentMenu("PlayMaker/UI/UI Int Value Changed Event")]
	public class PlayMakerUiIntValueChangedEvent : PlayMakerUiEventBase
	{
		public Dropdown dropdown;

		public TMP_Dropdown tmpDropdown;

		protected override void Initialize()
		{
		}

		protected void OnDisable()
		{
		}

		private void OnValueChanged(int value)
		{
		}
	}
}
