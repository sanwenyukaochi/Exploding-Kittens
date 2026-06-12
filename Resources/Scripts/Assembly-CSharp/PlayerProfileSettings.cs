using UnityEngine;

public class PlayerProfileSettings : MonoBehaviour
{
	public PlayerAvatarRepository PlayerAvatarRepository;

	public PlayerNameChangeEvent OnPlayerNameChanged;

	public PlayerAvatarEvent OnPlayerAvatarChanged;

	public SkuEvent OnSavePurchaseItem;

	public SkuEvent OnFeatureSeen;

	public BoolEvent OnIsAudioEnabledChanged;

	private DefaultNameProvider DefaultNameProvider;

	private const string DEFAULT_PLAYER_AVATAR_ID = "Set1.blue";

	private const string PLAYER_NAME_KEY = "PlayerName";

	private const string PLAYER_DEVICE_IDENTIFIER_KEY = "PlayerDeviceIdentifier";

	private const string PLAYER_AVATAR_ID_KEY = "PlayerAvatarId";

	private const string TUTORIAL_SEEN_KEY = "TutorialSeen";

	private const string NUM_GAMES_PLAYED_KEY = "NumGamesPlayed";

	private const string RATE_POPUP_SHOWN = "RatePopupShown";

	private const string LAST_GAME_CODE = "LastGameCode";

	private const string IS_WIZARD_KEY = "IsWizard";

	private const string AUDIO_ENABLED_KEY = "IsAudioEnabled";

	private const string UNLOCKED_FRAMERATE = "IsFramerateUnlocked";

	private const string UNLOCKED_VIBRATION = "IsVibrationUnlocked";

	private const string PROMOTIONAL_PLAY_OFFER_KEY = "PromotionalPlayOffer.";

	private const string AI_DIFFICULTY_UNLOCKED = "AIDifficultyUnlocked";

	private const string AI_EASY_WINS = "AIEasyWins";

	private const string AI_MEDIUM_WINS = "AIMediumWins";

	private const string AI_HARD_WINS = "AIHardWins";

	private const string AI_EASY_LOSSES = "AIEasyLosses";

	private const string AI_MEDIUM_LOSSES = "AIMediumLosses";

	private const string AI_HARD_LOSSES = "AIHardLosses";

	private const string STREAKING_DECK_REMINDER = "StreakingDeckReminder";

	public static PlayerProfileSettings Instance;

	public int StreakingDeckReminder
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public string PlayerName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string PlayerAvatarId
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string LastGameCode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string DeviceIdentifier => null;

	public PlayerAvatar PlayerAvatar
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool IsWizard
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasSeenTutorial
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsAudioEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsFramerateUnlocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsVibrationUnlocked
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int NumGamesPlayed
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AIDifficultyUnlocked
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AIEasyWins
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AIMediumWins
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AIHardWins
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AIEasyLosses
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AIMediumLosses
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int AIHardLosses
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool RatePopupShown
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public void Reset()
	{
	}

	public void SavePurchasedItem(string sku)
	{
	}

	public bool IsPurchased(string sku)
	{
		return false;
	}

	public bool HasSeenFeature(string key)
	{
		return false;
	}

	public void SaveFeatureSeen(string key)
	{
	}

	private bool PurchasesAreFreeOnThisPlatform()
	{
		return false;
	}

	public bool HaveSeenPromotionalPlayOffer(int numGamesPlayed)
	{
		return false;
	}

	public bool HaveSeenPromotionalPlayOffer(PromotionalPlayOffer offer)
	{
		return false;
	}

	public void SavePromotionalPlayOfferSeen(int numGamesPlayed)
	{
	}

	public void SavePromotionalPlayOfferSeen(PromotionalPlayOffer offer)
	{
	}

	private bool GetBool(string key, bool defaultValue)
	{
		return false;
	}

	private void SetBool(string key, bool value)
	{
	}
}
