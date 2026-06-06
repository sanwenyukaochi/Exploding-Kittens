using UnityEngine;

public class DebugPanel : MonoBehaviour
{
	public UILabel Label;

	public UIScrollView ScrollView;

	private string text;

	private const int UNITY_TEXT_LIMIT = 5000;

	public static DebugPanel Instance;

	private void Awake()
	{
	}

	public static void Log(string header, string log, string color)
	{
	}

	public void Log(string header, string log)
	{
	}

	public void Log(string log)
	{
	}

	public void OnDoubleClick()
	{
	}

	public void Clear()
	{
	}

	private void Refresh()
	{
	}

	private void TruncateIfNecessary()
	{
	}
}
