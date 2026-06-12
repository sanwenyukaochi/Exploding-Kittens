using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BMFont
{
	[SerializeField]
	[HideInInspector]
	private int mSize;

	[HideInInspector]
	[SerializeField]
	private int mBase;

	[SerializeField]
	[HideInInspector]
	private int mWidth;

	[SerializeField]
	[HideInInspector]
	private int mHeight;

	[SerializeField]
	[HideInInspector]
	private string mSpriteName;

	[SerializeField]
	[HideInInspector]
	private List<BMGlyph> mSaved;

	private Dictionary<int, BMGlyph> mDict;

	public bool isValid => false;

	public int charSize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int baseOffset
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int texWidth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int texHeight
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int glyphCount => 0;

	public string spriteName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<BMGlyph> glyphs => null;

	public BMGlyph GetGlyph(int index, bool createIfMissing)
	{
		return null;
	}

	public BMGlyph GetGlyph(int index)
	{
		return null;
	}

	public void Clear()
	{
	}

	public void Trim(int xMin, int yMin, int xMax, int yMax)
	{
	}
}
