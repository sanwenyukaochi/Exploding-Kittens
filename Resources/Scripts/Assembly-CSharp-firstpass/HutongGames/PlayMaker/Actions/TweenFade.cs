using System;
using HutongGames.PlayMaker.TweenEnums;
using UnityEngine;
using UnityEngine.UI;

namespace HutongGames.PlayMaker.Actions
{
	[Tooltip("Fades a GameObject with a Material, Sprite, Image, Text, Light, AudioSource, or CanvasGroup component.\n\nNote: The Material Shader must support transparency. For example, in URP set the Surface Type to Transparent.\n\nTip: When using the Standard shader, set Rendering Mode to Fade for best fading effect.")]
	[ActionCategory(ActionCategory.Tween)]
	public class TweenFade : TweenActionBase
	{
		public enum TargetType
		{
			None = 0,
			Material = 1,
			Sprite = 2,
			Image = 3,
			Text = 4,
			Light = 5,
			AudioSource = 6,
			CanvasGroup = 7
		}

		private const string SupportedComponents = "MeshRenderer, Sprite, Image, Text, Light, AudioSource, or CanvasGroup component.";

		[Tooltip("A GameObject with a MeshRenderer, Sprite, Image, Text, Light, AudioSource, or CanvasGroup component.")]
		public FsmOwnerDefault gameObject;

		[Tooltip("Fade To or From value.")]
		public TweenDirection tweenDirection;

		[Tooltip("Value to fade to. E.g., alpha if fading an image, volume if fading audio...")]
		public FsmFloat value;

		private GameObject cachedGameObject;

		private Component cachedComponent;

		private TargetType targetType;

		private Renderer renderer;

		private SpriteRenderer spriteRenderer;

		private Text text;

		private Image image;

		private Light light;

		private CanvasGroup canvasGroup;

		private AudioSource audioSource;

		private float startValue;

		private float endValue;

		public TargetType type => default(TargetType);

		public override void Reset()
		{
		}

		private void UpdateCache(GameObject go)
		{
		}

		private void FindComponent(params Type[] components)
		{
		}

		private void CheckCache()
		{
		}

		private void InitTarget()
		{
		}

		public override void OnEnter()
		{
		}

		private float GetTargetFade()
		{
			return 0f;
		}

		private void SetTargetFade(float fade)
		{
		}

		protected override void DoTween()
		{
		}
	}
}
