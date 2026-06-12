using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker
{
	[AddComponentMenu("PlayMaker/UI/UI Bool Value Changed Event")]
	public class PlayMakerUiBoolValueChangedEvent : PlayMakerUiEventBase
	{
		public Toggle toggle;

		protected override void Initialize()
		{
		}

		protected void OnDisable()
		{
		}

		private void OnValueChanged(bool value)
		{
		}
	}
}
