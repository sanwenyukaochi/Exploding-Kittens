using System;
using System.Collections.Generic;

[Serializable]
public class EmotePack
{
	public string Id;

	public List<Emote> Emotes;

	public Emote RandomEmote => null;

	public EmotePack(string id)
	{
	}

	public void AddEmote(Emote emote)
	{
	}

	public Emote FindById(string id)
	{
		return null;
	}
}
