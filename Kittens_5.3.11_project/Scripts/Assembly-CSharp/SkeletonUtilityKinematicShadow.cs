using System.Collections.Generic;
using UnityEngine;

public class SkeletonUtilityKinematicShadow : MonoBehaviour
{
	public bool hideShadow;

	public Transform parent;

	private Dictionary<Transform, Transform> shadowTable;

	private GameObject shadowRoot;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
	}
}
