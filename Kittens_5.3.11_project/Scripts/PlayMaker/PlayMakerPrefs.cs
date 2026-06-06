using System.Collections.Generic;
using UnityEngine;

public class PlayMakerPrefs : ScriptableObject
{
	private static PlayMakerPrefs instance;

	private static readonly Color[] defaultColors;

	private static readonly string[] defaultColorNames;

	private static Color[] minimapColors;

	[Tooltip("Output performance warnings to Unity log.\nNote, logging can cause hitches, so you should disabled this in final builds!")]
	[SerializeField]
	private bool logPerformanceWarnings;

	[Tooltip("Show Event Handler Components automatically added on GameObjects.\nNormally you want to hide these to keep the Inspector cleaner.")]
	[SerializeField]
	private bool showEventHandlerComponents;

	[Tooltip("How long debug lines are visible for (in seconds).")]
	[SerializeField]
	private float debugLinesDuration;

	[Tooltip("Colors used by States etc.")]
	[SerializeField]
	private Color[] colors;

	[Tooltip("Descriptive names for each color.")]
	[SerializeField]
	private string[] colorNames;

	[Tooltip("Color used for Tween From Handles.")]
	[SerializeField]
	private Color tweenFromColor;

	[Tooltip("Color used for Tween To Handles.")]
	[SerializeField]
	private Color tweenToColor;

	[SerializeField]
	[Tooltip("Color used to draw arrows. E.g., velocity, force, direction...")]
	private Color arrowColor;

	[SerializeField]
	private List<string> oldActionNames;

	[SerializeField]
	private List<string> newActionNames;

	[Tooltip("Organize Pools in the hierarchy , and store stacked instances per pool\nNote, this has little impact on performances, but better for organization")]
	[SerializeField]
	private bool organizePoolsInHierarchy;

	[Tooltip("If true, will provide a default name to the instances based on their pool index and prefab name\nNote, this has an impact on performance and should be turned off for maximum efficiency")]
	[SerializeField]
	private bool autoNamePoolInstances;

	[Tooltip("If true, hides pools organization ( if OrganizePoolsInHierarchy is true) and all pool stacked instances\nNote, this has no impact on performance, but account for a clean hierarchy, you don't need generally to see")]
	[SerializeField]
	private bool hidePoolsInHierarchy;

	public static PlayMakerPrefs Instance => null;

	public static float DebugLinesDuration
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public static bool LogPerformanceWarnings
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool ShowEventHandlerComponents
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static Color TweenFromColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public static Color TweenToColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public static Color ArrowColor
	{
		get
		{
			return default(Color);
		}
		set
		{
		}
	}

	public static Color[] Colors
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static string[] ColorNames
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static Color[] MinimapColors => null;

	public static bool OrganizePoolsInHierarchy
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool AutoNamePoolInstances
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool HidePoolsInHierarchy
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static void SaveChanges()
	{
	}

	public void ResetDefaultColors()
	{
	}

	public void AddActionRenameRule(string oldName, string newName)
	{
	}

	public void DeleteActionRenameRule(int index)
	{
	}

	public string GetNewActionName(string oldName)
	{
		return null;
	}

	private static void UpdateMinimapColors()
	{
	}

	private string TryGetNewActionName(string oldName)
	{
		return null;
	}
}
