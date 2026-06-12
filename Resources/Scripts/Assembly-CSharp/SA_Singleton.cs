using System;
using UnityEngine;

public abstract class SA_Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
	private static T _instance;

	private static bool applicationIsQuitting;

	[Obsolete("instance is deprectaed, plase use Instance instaed")]
	public static T instance => null;

	public static T Instance => null;

	public static bool HasInstance => false;

	public static bool IsDestroyed => false;

	protected virtual void OnDestroy()
	{
	}

	protected virtual void OnApplicationQuit()
	{
	}
}
