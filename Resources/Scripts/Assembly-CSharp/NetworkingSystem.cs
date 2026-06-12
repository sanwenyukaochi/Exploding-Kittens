using UnityEngine;

public class NetworkingSystem : MonoBehaviour
{
	[Header("Concrete Message Clients")]
	public PhotonMessageClient PhotonMessageClient;

	public MultipeerMessageClient MultipeerMessageClient;

	public LocalMessageClient LocalMessageClient;

	[Header("--")]
	public IMessageClient MessageClient;

	public NetworkingType NetworkingType;

	public static NetworkingSystem Instance;

	public void Awake()
	{
	}

	public void SwitchTo(NetworkingType networkingType)
	{
	}

	public IMessageClient MessageClientForNetworkingType(NetworkingType networkingType)
	{
		return null;
	}
}
