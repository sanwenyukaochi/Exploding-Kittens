using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Toggled Objects")]
public class UIToggledObjects : MonoBehaviour
{
	public List<GameObject> activate;

	public List<GameObject> deactivate;

	[HideInInspector]
	[SerializeField]
	private GameObject target;

	[SerializeField]
	[HideInInspector]
	private bool inverse;

	private void Awake()
	{
	}

	public void Toggle()
	{
	}

	private void Set(GameObject go, bool state)
	{
	}
}
