using System;
using UnityEngine;

public class OnEnableCallback : MonoBehaviour
{
	public Action<GameObject> Callback;

	private void OnEnable()
	{
	}
}
