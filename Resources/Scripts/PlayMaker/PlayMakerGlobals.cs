using System;
using System.Collections.Generic;
using System.Diagnostics;
using HutongGames;
using HutongGames.PlayMaker;
using UnityEngine;

public class PlayMakerGlobals : ScriptableObject
{
	private static PlayMakerGlobals instance;

	[NonSerialized]
	private bool initialized;

	[SerializeField]
	private FsmVariables variables;

	[SerializeField]
	private List<string> events;

	public static bool Initialized => false;

	public static bool IsPlayingInEditor { get; private set; }

	public static bool IsPlaying { get; private set; }

	public static bool IsEditor { get; private set; }

	public static bool IsBuilding { get; set; }

	public static PlayMakerGlobals Instance => null;

	public FsmVariables Variables
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<string> Events
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static void InitInEditor()
	{
	}

	public static void InitApplicationFlags()
	{
	}

	public static void Initialize()
	{
	}

	public FsmEvent AddEvent(string eventName)
	{
		return null;
	}

	public static void AddGlobalEvent(string eventName)
	{
	}

	public static void RemoveGlobalEvent(string eventName)
	{
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void OnDestroy()
	{
	}

	[Conditional("DEBUG_LOG")]
	private void DebugLog(object message, LogColor logColor = LogColor.None)
	{
	}

	public static void ResetInstance()
	{
	}
}
