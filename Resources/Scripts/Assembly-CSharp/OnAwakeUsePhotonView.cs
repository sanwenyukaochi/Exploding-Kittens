using Photon;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class OnAwakeUsePhotonView : Photon.MonoBehaviour
{
	private void Awake()
	{
	}

	private void Start()
	{
	}

	[PunRPC]
	public void OnAwakeRPC()
	{
	}

	[PunRPC]
	public void OnAwakeRPC(byte myParameter)
	{
	}
}
