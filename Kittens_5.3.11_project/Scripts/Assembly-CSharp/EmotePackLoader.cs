using System.Collections.Generic;
using UnityEngine;

public class EmotePackLoader : MonoBehaviour
{
	public EmotePackRepository EmotePackRepository;

	public TextAsset TextAsset;

	private void Start()
	{
	}

	public List<EmotePack> LoadEmotePacks()
	{
		return null;
	}

	private EmotePack FindOrCreateEmotePack(Dictionary<string, EmotePack> emotePacks, Emote emote)
	{
		return null;
	}

	private Emote BuildEmote(Dictionary<string, string> record)
	{
		return null;
	}
}
