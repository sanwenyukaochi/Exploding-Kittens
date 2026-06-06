using System.Collections.Generic;
using UnityEngine;

public class EmotePackRepository : MonoBehaviour
{
	public static EmotePackRepository Instance;

	public List<EmotePack> EmotePacks;

	private void Awake()
	{
	}

	public void Initialize(List<EmotePack> emotePacks)
	{
	}

	public EmotePack FindById(string id)
	{
		return null;
	}
}
