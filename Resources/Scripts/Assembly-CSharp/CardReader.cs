using System.Collections.Generic;
using UnityEngine;

public class CardReader : MonoBehaviour
{
	public List<Card> Read(TextAsset textAsset, int numPlayers)
	{
		return null;
	}

	private List<Card> CardsFromRecord(Dictionary<string, string> record, int numPlayers)
	{
		return null;
	}

	private Texture TextureFromString(string textureFilename)
	{
		return null;
	}

	private CardCategory CardCategoryFromString(string category)
	{
		return default(CardCategory);
	}

	private bool IsComment(string line)
	{
		return false;
	}
}
