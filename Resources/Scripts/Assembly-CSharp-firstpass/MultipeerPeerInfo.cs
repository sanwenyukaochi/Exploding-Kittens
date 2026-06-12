using System.Collections.Generic;

public struct MultipeerPeerInfo
{
	public string PeerId;

	public Dictionary<string, string> DiscoveryInfo;

	public MultipeerPeerInfo(string peerId)
	{
		PeerId = null;
		DiscoveryInfo = null;
	}

	public MultipeerPeerInfo(string peerId, Dictionary<string, string> discoveryInfo)
	{
		PeerId = null;
		DiscoveryInfo = null;
	}

	public static bool operator ==(MultipeerPeerInfo m1, MultipeerPeerInfo m2)
	{
		return false;
	}

	public static bool operator !=(MultipeerPeerInfo m1, MultipeerPeerInfo m2)
	{
		return false;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
