using System.Collections.Generic;
using ExitGames.Client.Photon;
using Photon;

public class PunTurnManager : PunBehaviour
{
	public float TurnDuration;

	public IPunTurnManagerCallbacks TurnManagerListener;

	private readonly HashSet<PhotonPlayer> finishedPlayers;

	public const byte TurnManagerEventOffset = 0;

	public const byte EvMove = 1;

	public const byte EvFinalMove = 2;

	private bool _isOverCallProcessed;

	public int Turn
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public float ElapsedTimeInTurn => 0f;

	public float RemainingSecondsInTurn => 0f;

	public bool IsCompletedByAll => false;

	public bool IsFinishedByMe => false;

	public bool IsOver => false;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void BeginTurn()
	{
	}

	public void SendMove(object move, bool finished)
	{
	}

	public bool GetPlayerFinishedTurn(PhotonPlayer player)
	{
		return false;
	}

	public void OnEvent(byte eventCode, object content, int senderId)
	{
	}

	public override void OnPhotonCustomRoomPropertiesChanged(Hashtable propertiesThatChanged)
	{
	}
}
