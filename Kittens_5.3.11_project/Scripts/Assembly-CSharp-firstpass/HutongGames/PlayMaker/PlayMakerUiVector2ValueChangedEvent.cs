using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker
{
	[AddComponentMenu("PlayMaker/UI/UI Vector2 Value Changed Event")]
	public class PlayMakerUiVector2ValueChangedEvent : PlayMakerUiEventBase
	{
		public ScrollRect scrollRect;

		protected override void Initialize()
		{
		}

		protected void OnDisable()
		{
		}

		private void OnValueChanged(Vector2 value)
		{
		}
	}
}
