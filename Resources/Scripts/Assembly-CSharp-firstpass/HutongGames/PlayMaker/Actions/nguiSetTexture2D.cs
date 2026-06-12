using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Set/change NGUI Texture")]
	[ActionCategory("Ngui Actions")]
	public class nguiSetTexture2D : FsmStateAction
	{
		[UIHint(UIHint.Description)]
		public string des;

		[RequiredField]
		public FsmOwnerDefault NguiObject;

		public FsmTexture targetTexture;

		public UIBasicSprite.Type textureType;

		public FsmColor colorTint;

		private GameObject go;

		[Tooltip("When true, runs on every frame")]
		public bool everyFrame;

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoSetTexture()
		{
		}
	}
}
