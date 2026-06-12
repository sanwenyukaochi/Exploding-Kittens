using System;

public class Region
{
	public CloudRegionCode Code;

	public string Cluster;

	public string HostAndPort;

	public int Ping;

	public Region(CloudRegionCode code)
	{
	}

	public Region(CloudRegionCode code, string regionCodeString, string address)
	{
	}

	public static CloudRegionCode Parse(string codeAsString)
	{
		return default(CloudRegionCode);
	}

	internal static CloudRegionFlag ParseFlag(CloudRegionCode region)
	{
		return default(CloudRegionFlag);
	}

	[Obsolete]
	internal static CloudRegionFlag ParseFlag(string codeAsString)
	{
		return default(CloudRegionFlag);
	}

	public override string ToString()
	{
		return null;
	}
}
