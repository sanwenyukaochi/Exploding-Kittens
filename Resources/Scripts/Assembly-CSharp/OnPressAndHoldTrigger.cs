using System;
using UnityEngine;

public class OnPressAndHoldTrigger : MonoBehaviour
{
	public float PressAndHoldDuration;

	public ActionBase Action;

	private DateTime clickedAtTime;

	public void OnPress(bool isDown)
	{
	}
}
