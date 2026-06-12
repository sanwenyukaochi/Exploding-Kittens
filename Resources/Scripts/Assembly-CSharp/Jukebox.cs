using System;
using System.Collections.Generic;
using UnityEngine;

public class Jukebox : MonoBehaviour
{
	public List<AudioSource> AudioSources;

	public static Jukebox Instance;

	public void Awake()
	{
	}

	public void Play(string soundName)
	{
	}

	public void PlayOneShot(string soundName)
	{
	}

	public void StopAll()
	{
	}

	public void Stop(string soundName)
	{
	}

	private AudioSource Find(string soundName)
	{
		return null;
	}

	private void Find(string soundName, Action<AudioSource> onFound)
	{
	}
}
