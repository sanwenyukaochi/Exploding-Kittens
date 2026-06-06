using System.Collections.Generic;
using UnityEngine;

public class DisablyButton : MonoBehaviour
{
	public UIWidget[] Widgets;

	public float Brightness;

	public bool StartsDisabled;

	private Dictionary<UIWidget, Color> originalColors;

	private Dictionary<UIWidget, Color> disableColors;

	private Collider widgetCollider;

	private void Awake()
	{
	}

	public void Disable()
	{
	}

	public void Enable()
	{
	}

	private void Flip(bool isEnabled)
	{
	}
}
