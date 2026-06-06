using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Ngui Actions")]
	[Tooltip("Change Label Font that you already created in your project using Atlas font maker")]
	public class nguiChangeLabelFont : FsmStateAction
	{
		[Tooltip("NGUI Label to change Font")]
		[RequiredField]
		public FsmOwnerDefault NguiLabelObject;

		private UILabel theNguiLabel;

		[UIHint(UIHint.FsmGameObject)]
		[Tooltip("Input your new Font")]
		public UIFont newAtlasFont;

		[UIHint(UIHint.Variable)]
		public Font newTrueTypeFont;

		[Tooltip("When true, runs on every frame")]
		public bool everyFrame;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void doChangeFont()
		{
		}
	}
}
