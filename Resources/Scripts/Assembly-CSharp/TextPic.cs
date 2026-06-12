using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class TextPic : Text, IPointerClickHandler, IEventSystemHandler, IPointerExitHandler, IPointerEnterHandler, ISelectHandler
{
	[Serializable]
	public struct IconName
	{
		public string name;

		public Sprite sprite;
	}

	[Serializable]
	public class HrefClickEvent : UnityEvent<string>
	{
	}

	private class HrefInfo
	{
		public int startIndex;

		public int endIndex;

		public string name;

		public readonly List<Rect> boxes;
	}

	private readonly List<Image> m_ImagesPool;

	private readonly List<int> m_ImagesVertexIndex;

	private static readonly Regex s_Regex;

	private string fixedString;

	private string m_OutputText;

	public IconName[] inspectorIconList;

	private Dictionary<string, Sprite> iconList;

	public float ImageScalingFactor;

	public string hyperlinkColor;

	[SerializeField]
	public Vector2 imageOffset;

	private Button button;

	private bool selected;

	private List<Vector2> positions;

	private readonly List<HrefInfo> m_HrefInfos;

	private static readonly StringBuilder s_TextBuilder;

	private static readonly Regex s_HrefRegex;

	[SerializeField]
	private HrefClickEvent m_OnHrefClick;

	public HrefClickEvent onHrefClick
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override void SetVerticesDirty()
	{
	}

	private new void Start()
	{
	}

	protected void UpdateQuadImage()
	{
	}

	protected override void OnPopulateMesh(VertexHelper toFill)
	{
	}

	protected string GetOutputText()
	{
		return null;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	public void OnPointerExit(PointerEventData eventData)
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}
}
