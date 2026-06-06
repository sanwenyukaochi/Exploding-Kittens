using System;
using Photon;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class PickupItemSyncer : Photon.MonoBehaviour
{
	public bool IsWaitingForPickupInit;

	private const float TimeDeltaToIgnore = 0.2f;

	public void OnPhotonPlayerConnected(PhotonPlayer newPlayer)
	{
	}

	public void OnJoinedRoom()
	{
	}

	public void AskForPickupItemSpawnTimes()
	{
	}

	[PunRPC]
	[Obsolete("Use RequestForPickupItems(PhotonMessageInfo msgInfo) with corrected typing instead.")]
	public void RequestForPickupTimes(PhotonMessageInfo msgInfo)
	{
	}

	[PunRPC]
	public void RequestForPickupItems(PhotonMessageInfo msgInfo)
	{
	}

	private void SendPickedUpItems(PhotonPlayer targetPlayer)
	{
	}

	[PunRPC]
	public void PickupItemInit(double timeBase, float[] inactivePickupsAndTimes)
	{
	}
}
