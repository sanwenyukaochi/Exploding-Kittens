using Photon;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class HighlightOwnedGameObj : Photon.MonoBehaviour
{
	public GameObject PointerPrefab;

	public float Offset;

	private Transform markerTransform;

	private void Update()
	{
	}
}
