using System.Collections.Generic;
using System.Reflection;
using Photon;
using UnityEngine;

[AddComponentMenu("Photon Networking/Photon View &v")]
public class PhotonView : Photon.MonoBehaviour
{
	public int ownerId;

	public byte group;

	protected internal bool mixedModeIsReliable;

	public bool OwnerShipWasTransfered;

	public int prefixBackup;

	internal object[] instantiationDataField;

	protected internal object[] lastOnSerializeDataSent;

	protected internal object[] lastOnSerializeDataReceived;

	public ViewSynchronization synchronization;

	public OnSerializeTransform onSerializeTransformOption;

	public OnSerializeRigidBody onSerializeRigidBodyOption;

	public OwnershipOption ownershipTransfer;

	public List<Component> ObservedComponents;

	private Dictionary<Component, MethodInfo> m_OnSerializeMethodInfos;

	[SerializeField]
	private int viewIdField;

	public int instantiationId;

	public int currentMasterID;

	protected internal bool didAwake;

	[SerializeField]
	protected internal bool isRuntimeInstantiated;

	protected internal bool removedFromLocalViewList;

	internal UnityEngine.MonoBehaviour[] RpcMonoBehaviours;

	private MethodInfo OnSerializeMethodInfo;

	private bool failedToFindOnSerialize;

	public int prefix
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public object[] instantiationData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int viewID
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool isSceneView => false;

	public PhotonPlayer owner => null;

	public int OwnerActorNr => 0;

	public bool isOwnerActive => false;

	public int CreatorActorNr => 0;

	public bool isMine => false;

	protected internal void Awake()
	{
	}

	public void RequestOwnership()
	{
	}

	public void TransferOwnership(PhotonPlayer newOwner)
	{
	}

	public void TransferOwnership(int newOwnerId)
	{
	}

	public void OnMasterClientSwitched(PhotonPlayer newMasterClient)
	{
	}

	protected internal void OnDestroy()
	{
	}

	public void SerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	public void DeserializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	protected internal void DeserializeComponent(Component component, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	protected internal void SerializeComponent(Component component, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	protected internal void ExecuteComponentOnSerialize(Component component, PhotonStream stream, PhotonMessageInfo info)
	{
	}

	public void RefreshRpcMonoBehaviourCache()
	{
	}

	public void RPC(string methodName, PhotonTargets target, params object[] parameters)
	{
	}

	public void RpcSecure(string methodName, PhotonTargets target, bool encrypt, params object[] parameters)
	{
	}

	public void RPC(string methodName, PhotonPlayer targetPlayer, params object[] parameters)
	{
	}

	public void RpcSecure(string methodName, PhotonPlayer targetPlayer, bool encrypt, params object[] parameters)
	{
	}

	public static PhotonView Get(Component component)
	{
		return null;
	}

	public static PhotonView Get(GameObject gameObj)
	{
		return null;
	}

	public static PhotonView Find(int viewID)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
