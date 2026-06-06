using System;
using ExitGames.Client.Photon;

public class RoomInfo
{
	private Hashtable customPropertiesField;

	protected byte maxPlayersField;

	protected int emptyRoomTtlField;

	protected int playerTtlField;

	protected string[] expectedUsersField;

	protected bool openField;

	protected bool visibleField;

	protected bool autoCleanUpField;

	protected string nameField;

	protected internal int masterClientIdField;

	public bool removedFromList { get; internal set; }

	protected internal bool serverSideMasterClient { get; private set; }

	public Hashtable CustomProperties => null;

	public string Name => null;

	public int PlayerCount { get; private set; }

	public bool IsLocalClientInside { get; set; }

	public byte MaxPlayers => 0;

	public bool IsOpen => false;

	public bool IsVisible => false;

	[Obsolete("Please use CustomProperties (updated case for naming).")]
	public Hashtable customProperties => null;

	[Obsolete("Please use Name (updated case for naming).")]
	public string name => null;

	[Obsolete("Please use PlayerCount (updated case for naming).")]
	public int playerCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Obsolete("Please use IsLocalClientInside (updated case for naming).")]
	public bool isLocalClientInside
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete("Please use MaxPlayers (updated case for naming).")]
	public byte maxPlayers => 0;

	[Obsolete("Please use IsOpen (updated case for naming).")]
	public bool open => false;

	[Obsolete("Please use IsVisible (updated case for naming).")]
	public bool visible => false;

	protected internal RoomInfo(string roomName, Hashtable properties)
	{
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public string ToStringFull()
	{
		return null;
	}

	protected internal void InternalCacheProperties(Hashtable propertiesToCache)
	{
	}
}
