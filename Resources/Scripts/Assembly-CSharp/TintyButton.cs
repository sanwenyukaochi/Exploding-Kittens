using System.Collections.Generic;
using UnityEngine;

public class TintyButton : MonoBehaviour
{
	public UIWidget[] Widgets;

	public Dictionary<UIWidget, Color> originalColors;

	public bool DragOn;

	private void Start()
	{
	}

	private void OnPress(bool isDown)
	{
	}

	private Color DownColorForWidget(UIWidget widget)
	{
		return default(Color);
	}

	private void OnDrag()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}
}
