using System;
using UnityEngine;

public class OnDisableCallback : MonoBehaviour
{
	public Action<GameObject> Callback;

	private void OnDisable()
	{
	}
}
