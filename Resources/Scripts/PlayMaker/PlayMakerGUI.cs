using System.Collections.Generic;
using HutongGames.PlayMaker;
using UnityEngine;

[AddComponentMenu("PlayMaker/PlayMakerGUI")]
[ExecuteInEditMode]
public class PlayMakerGUI : MonoBehaviour
{
	private static readonly List<PlayMakerFSM> fsmList;

	public static Fsm SelectedFSM;

	private static readonly GUIContent labelContent;

	public bool previewOnGUI;

	public bool enableGUILayout;

	public bool drawStateLabels;

	public bool enableStateLabelsInBuilds;

	public bool GUITextureStateLabels;

	public bool GUITextStateLabels;

	public bool filterLabelsWithDistance;

	public float maxLabelDistance;

	public bool controlMouseCursor;

	public float labelScale;

	private static readonly List<PlayMakerFSM> SortedFsmList;

	private static GameObject labelGameObject;

	private static float fsmLabelIndex;

	private static PlayMakerGUI instance;

	private static GUISkin guiSkin;

	private static Color guiColor;

	private static Color guiBackgroundColor;

	private static Color guiContentColor;

	private static Matrix4x4 guiMatrix;

	private const float MaxLabelWidth = 200f;

	private static GUIStyle stateLabelStyle;

	private static Texture2D stateLabelBackground;

	private float initLabelScale;

	public static bool Exists => false;

	public static bool EnableStateLabels
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool EnableStateLabelsInBuild
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static PlayMakerGUI Instance => null;

	public static bool Enabled => false;

	public static GUISkin GUISkin
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static Color GUIColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public static Color GUIBackgroundColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public static Color GUIContentColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public static Matrix4x4 GUIMatrix
	{
		get
		{
			return default(Matrix4x4);
		}
		set
		{
		}
	}

	public static Texture MouseCursor { get; set; }

	public static bool LockCursor { get; set; }

	public static bool HideCursor { get; set; }

	private static void InitInstance()
	{
	}

	private void InitLabelStyle()
	{
	}

	private void DrawStateLabels()
	{
	}

	private void DrawStateLabel(PlayMakerFSM fsm)
	{
	}

	private static string GenerateStateLabel(PlayMakerFSM fsm)
	{
		return null;
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnGUI()
	{
	}

	private void CallOnGUI(Fsm fsm)
	{
	}

	private void OnDisable()
	{
	}

	private static void DoEditGUI()
	{
	}

	public void OnApplicationQuit()
	{
	}
}
