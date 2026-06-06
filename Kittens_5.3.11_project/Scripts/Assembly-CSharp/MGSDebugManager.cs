using MGS.Debugging;
using UnityEngine;

public class MGSDebugManager : MonoBehaviour
{
	private const float m_MultiTapInterval = 0.5f;

	private const float m_TapsToShowSettings = 3f;

	public GameObject inputBlocker;

	private static DebugSystem m_DebugSystem;

	private static UILogHandler m_LogHandler;

	private static FileLogHandler m_FileHandler;

	private GameObject m_Settings;

	private float m_CurrentTapTime;

	private int m_TapCount;

	private bool IsLogPanelVisible => false;

	private bool IsFilePanelVisible => false;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void ShowSettings()
	{
	}
}
