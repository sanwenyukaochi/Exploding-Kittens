using System.Collections.Generic;

public static class GameOptions
{
	public static bool IsSinglePlayerGame;

	public static bool SinglePlayerMuted;

	public static int AIDifficultySelected;

	public static bool GameExited;

	public static bool ReturnChooseDifficultyScreen;

	public static bool IsLobbyHost;

	public static List<Player> Players;

	public static List<Player> PlayerTurnQueue;

	public static Player CurrentPlayer;

	public const int MAX_PLAYERS = 5;

	public const int MIN_PLAYERS = 2;

	public static Dictionary<MultipeerPeerInfo, Player> PeerRepo;

	public static MultipeerGameInfo GameHostInfo;

	public static DeckTypeEvent OnDeckTypeChanged;

	private static string localPlayerId;

	private static DeckType deckType;

	public static int SyncedSeed;

	public static string SyncedSeedOldString;

	public static float GamePlayTime;

	public static int GamesPlayed;

	public static int PlayerActionCount;

	public static bool ReadyToReceive;

	public static DeckType DeckType
	{
		get
		{
			return default(DeckType);
		}
		set
		{
		}
	}

	public static string LocalPlayerId => null;

	public static string HostPeerId => null;

	public static bool IsLobbyClient => false;

	public static List<Player> LocalPlayers()
	{
		return null;
	}

	public static Player GetPlayerWithPhotonID(int id)
	{
		return null;
	}

	public static int GetRandomSynced(int i1, int i2)
	{
		return 0;
	}

	public static void SendEmail(string email, string subject, string body)
	{
	}

	public static string MyEscapeURL(string url)
	{
		return null;
	}

	public static int GetActivePlayerCount()
	{
		return 0;
	}

	public static bool isWide()
	{
		return false;
	}
}
