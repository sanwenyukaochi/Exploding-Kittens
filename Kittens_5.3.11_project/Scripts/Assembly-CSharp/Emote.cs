using System;

[Serializable]
public class Emote
{
	public string Id;

	public string SoundName;

	public string EmotePackId;

	public string ButtonLabel;

	public string Transcript;

	public Emote(string id, string emotePackId, string soundName, string buttonLabel, string transcript)
	{
	}
}
