using System;
using ExitGames.Client.Photon;

public class Room : RoomInfo
{
	public new string Name
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	public new bool IsOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public new bool IsVisible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string[] PropertiesListedInLobby { get; private set; }

	public bool AutoCleanUp => false;

	public new int MaxPlayers
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public new int PlayerCount => 0;

	public string[] ExpectedUsers => null;

	public int PlayerTtl
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int EmptyRoomTtl
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected internal int MasterClientId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Obsolete("Please use Name (updated case for naming).")]
	public new string name
	{
		get
		{
			return null;
		}
		internal set
		{
		}
	}

	[Obsolete("Please use IsOpen (updated case for naming).")]
	public new bool open
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete("Please use IsVisible (updated case for naming).")]
	public new bool visible
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	[Obsolete("Please use PropertiesListedInLobby (updated case for naming).")]
	public string[] propertiesListedInLobby
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	[Obsolete("Please use AutoCleanUp (updated case for naming).")]
	public bool autoCleanUp => false;

	[Obsolete("Please use MaxPlayers (updated case for naming).")]
	public new int maxPlayers
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	[Obsolete("Please use PlayerCount (updated case for naming).")]
	public new int playerCount => 0;

	[Obsolete("Please use ExpectedUsers (updated case for naming).")]
	public string[] expectedUsers => null;

	[Obsolete("Please use MasterClientId (updated case for naming).")]
	protected internal int masterClientId
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	internal Room(string roomName, RoomOptions options)
		: base(null, null)
	{
	}

	public void SetCustomProperties(Hashtable propertiesToSet, Hashtable expectedValues = null, bool webForward = false)
	{
	}

	public void SetPropertiesListedInLobby(string[] propsListedInLobby)
	{
	}

	public void ClearExpectedUsers()
	{
	}

	public void SetExpectedUsers(string[] expectedUsers)
	{
	}

	public override string ToString()
	{
		return null;
	}

	public new string ToStringFull()
	{
		return null;
	}
}
