using UnityEngine;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.GUI)]
	[Tooltip("Draws a GUI Texture. NOTE: Uses OnGUI so you need a PlayMakerGUI component in the scene. See unity docs: <a href=\"http://unity3d.com/support/documentation/ScriptReference/GUI.DrawTexture.html\">DrawTexture</a>.")]
	public class DrawTexture : FsmStateAction
	{
		[RequiredField]
		[Tooltip("Texture to draw.")]
		public FsmTexture texture;

		[Title("Position")]
		[UIHint(UIHint.Variable)]
		[Tooltip("Rectangle on the screen to draw the texture within. Alternatively, set or override individual properties below.")]
		public FsmRect screenRect;

		[Tooltip("Left screen coordinate.")]
		public FsmFloat left;

		[Tooltip("Top screen coordinate.")]
		public FsmFloat top;

		[Tooltip("Width of texture on screen.")]
		public FsmFloat width;

		[Tooltip("Height of texture on screen.")]
		public FsmFloat height;

		[Tooltip("How to scale the image when the aspect ratio of it doesn't fit the aspect ratio to be drawn within.")]
		public ScaleMode scaleMode;

		[Tooltip("Whether to alpha blend the image on to the display (the default). If false, the picture is drawn on to the display.")]
		public FsmBool alphaBlend;

		[Tooltip("Aspect ratio to use for the source image. If 0 (the default), the aspect ratio from the image is used. Pass in w/h for the desired aspect ratio. This allows the aspect ratio of the source image to be adjusted without changing the pixel width and height.")]
		public FsmFloat imageAspect;

		[Tooltip("Use normalized screen coordinates (0-1)")]
		public FsmBool normalized;

		private Rect rect;

		public override void Reset()
		{
		}

		public override void OnGUI()
		{
		}
	}
}
