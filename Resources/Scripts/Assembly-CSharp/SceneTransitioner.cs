using UnityEngine;

public class SceneTransitioner : MonoBehaviour
{
	private const float FADE_IN_AMOUNT = 0f;

	private const float FADE_OUT_AMOUNT = 1f;

	private const float FADE_IN_TIME = 1f;

	private const float FADE_OUT_TIME = 1f;

	public Texture2D FadeTexture;

	private Color Color;

	private string levelName;

	private static SceneTransitioner instance;

	public static SceneTransitioner Instance => null;

	private Rect ScreenRect => default(Rect);

	private void Start()
	{
	}

	private void OnGUI()
	{
	}

	public void TransitionTo(string levelName)
	{
	}

	private void FadeIn()
	{
	}

	private void FadeOut()
	{
	}

	private void TweenAlpha(float alpha)
	{
	}

	private void LoadLevel()
	{
	}
}
