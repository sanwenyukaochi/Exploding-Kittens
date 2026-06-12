using System;
using UnityEngine;

public class OnPressAndHoldTimer : MonoBehaviour
{
	public Camera m_Camera;

	public float PressAndHoldDuration;

	public bool m_Pressed;

	public float m_PressedTime;

	public ActionBase Action;

	private DateTime clickedAtTime;

	public void OnPress(bool isDown)
	{
	}

	private void Update()
	{
	}
}
