using System;
using UnityEngine;

public class BackButtonFactory : MonoBehaviour
{
	public GameObject Container;

	public GameObject BackButtonPrefab;

	public GameObject CancelButtonPrefab;

	public BackButton Create(BackButtonStyle style, Action onPress)
	{
		return null;
	}

	private GameObject Prefab(BackButtonStyle style)
	{
		return null;
	}
}
