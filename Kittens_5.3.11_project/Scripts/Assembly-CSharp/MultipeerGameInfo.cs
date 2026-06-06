using System.Collections.Generic;

public struct MultipeerGameInfo
{
	private MultipeerPeerInfo HostPeerInfo;

	public string HostPeerId => null;

	public Dictionary<string, string> DiscoveryInfo => null;

	public string DisplayName => null;

	public DeckType DeckType => default(DeckType);

	public int ApiVersion => 0;

	public int SyncedSeed => 0;

	public DeckMetadata DeckMetadata => null;

	public string MatchmakingServiceName => null;

	public MultipeerGameInfo(MultipeerPeerInfo hostPeerInfo)
	{
		HostPeerInfo = default(MultipeerPeerInfo);
	}

	public static bool operator ==(MultipeerGameInfo m1, MultipeerGameInfo m2)
	{
		return false;
	}

	public static bool operator !=(MultipeerGameInfo m1, MultipeerGameInfo m2)
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
