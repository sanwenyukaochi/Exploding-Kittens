public class KittensAnalytics
{
	private const int MAX_SEGMENT_LENGTH = 16;

	public static KittensAnalytics instance;

	public static KittensAnalytics Instance => null;

	private string NetworkType => null;

	public void RecordGameStats(GameStats gameStats)
	{
	}

	private void RecordGameStat(string key, int val)
	{
	}

	public void HostCreatedGame()
	{
	}

	public void HostCancelledGame()
	{
	}

	public void PlayerJoinedGame()
	{
	}

	public void PlayerJoinedRandomGame()
	{
	}

	public void PlayerLeftRandomGame()
	{
	}

	public void PlayerLeftGame()
	{
	}

	public void GameStarted()
	{
	}

	public void SinglePlayerGameStarted()
	{
	}

	public void Disconnected(ClientPhase clientPhase)
	{
	}

	public void IapPurchaseSucceeded(string sku)
	{
	}

	public void IapPurchaseFailed(int code)
	{
	}

	public void ChangeAvatar(string avatarId)
	{
	}

	public void EmoteTapped(string emoteId)
	{
	}

	public void PromotionalPlayPopupAccepted(string deckType)
	{
	}

	public void PromotionalPlayPopupRejected(string deckType)
	{
	}

	public void AvatarUnlocked(string avatarId)
	{
	}

	private string SafeSegmentName(string segment)
	{
		return null;
	}
}
