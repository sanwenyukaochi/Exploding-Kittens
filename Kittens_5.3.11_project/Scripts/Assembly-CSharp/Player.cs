using System;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
	public string Id;

	public bool IsLocalPlayer;

	public bool IsAI;

	public bool IsDead;

	public bool IsConnected;

	public bool PauseAI;

	public PlayerStats Stats;

	public PlayerDelegate OnWin;

	public PlayerIntDelegate OnStartTurn;

	public PlayerListDelegate OnPotLuckCompleted;

	public PlayerIntDelegate OnDisplayStartTurn;

	public PlayerDelegate OnEndTurn;

	public PlayerDelegate OnDisconnect;

	public PlayerDelegate OnStartPartying;

	public PlayerDelegate OnEndPartying;

	public PlayerPlayerAvatarDelegate OnPlayerAvatarChanged;

	public PlayerDelegate OnPlayerUsernameChanged;

	public PlayerDelegate OnFlaggedStateChange;

	public PlayerDelegate OnDeath;

	public PlayerEmoteDelegate OnEmote;

	public PlayerDelegate OnDisguiseHand;

	public PlayerDelegate OnShedDisguisedHand;

	public PlayerDelegate OnCancelChooseOpponent;

	public PlayerAttackDelegate OnAttack;

	public PlayerCardDelegate OnRemoveCard;

	public PlayerCardDelegate OnDrawCard;

	public PlayerCardDelegate OnPlayCard;

	public PlayerCardDelegate OnDiscardCard;

	public PlayerCardDelegate OnDrawExplodingKitten;

	public PlayerCardDelegate OnBuryCard;

	public PlayerCardDelegate OnExtraBombAdded;

	public PlayerCardDelegate OnChooseOpponent;

	public PlayerCardsDelegate OnSeeTheFutureCardsRevealed;

	public PlayerCardsDelegate OnAlteringTheFuture;

	public PlayerCardsDelegate OnSharingTheFuture;

	public PlayerPhaseDelegate OnPlayerPhaseEnded;

	public PlayerPhaseDelegate OnPlayerPhaseChange;

	public PlayerPlayerCardDelegate OnReceiveCardFromPlayer;

	public PlayerPlayerCardCallbackDelegate OnRequestCardFromPlayer;

	public PlayerPlayerCardCallbackDelegate OnRequestGarbageCollectionCardFromPlayer;

	public PlayerPlayerCardCallbackDelegate OnRequestPotLuckCardFromPlayer;

	public PlayerPlayerCardCallbackDelegate OnRequestBarkingKittenFromPlayer;

	public PlayerCardCardDelegate OnStreakingTriggered;

	public PlayerDelegate OnPlayerDefuse;

	public PlayerDelegate OnOpponentDefuse;

	public PlayerDelegate OnDeadPlayerSkipTurn;

	public List<Card> Hand;

	public CurrentTurnState CurrentTurnState;

	public string InnocuousUsername;

	public string DeviceId;

	public int PhotonPlayerID;

	public RematchGamePlayerState rematchGamePlayerState;

	private PlayerPhase playerPhase;

	public bool DefuseEndTurn;

	private bool IsHandFrozen;

	private PlayerAvatar playerAvatar;

	private string username;

	private bool isMuted;

	private bool isFlagged;

	private int NumberOfTimesNagged;

	public bool GarbageCollectionActive;

	public bool PotLuckActive;

	public bool DefusedReadyForPlacement;

	public bool NextCardIsRandom;

	public int AlterableCards;

	public bool PlayedCatButted;

	public Card DefuseBombCard;

	public Card DefuseBombCard2;

	public bool ChoosingStealCard;

	public bool ChoosingGarbageCard;

	public bool ChoosingPotLuckCard;

	public bool ChoosingOpponent;

	public bool HandDisguised;

	public int DefuseCount;

	public bool StoleBomb;

	public string StoleBombPlayerName;

	public bool PlayedBomb;

	public bool PlayedStreaking;

	public bool GaveStreaking;

	public bool ThinksBombInHand;

	public bool BarkingKittenFlag;

	public bool TowerOfPowerFlag;

	public string ITT_Player;

	public bool ShakeITTIcon;

	public bool GetITTCard;

	public bool PlayerPlacedKitten;

	public bool DefusingTakeThatBomb;

	public string DisplayName => null;

	public string Username
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

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

	public PlayerPhase PlayerPhase
	{
		get
		{
			return default(PlayerPhase);
		}
		private set
		{
		}
	}

	public string AvatarSpriteName => null;

	public Color AvatarColor => default(Color);

	public bool IsMuted => false;

	public bool IsFlagged
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool CannotDefuse => false;

	public string PlayerPronoun => null;

	public string PossessivePronoun => null;

	public bool HasNoCards => false;

	public List<Card> UnMarkedCards => null;

	public List<Card> UndiarrheadCards => null;

	public bool CanBeStolenFrom => false;

	public Player(string id, string username, PlayerAvatar playerAvatar, bool isLocalPlayer, string deviceId, int photonPlayerID)
	{
	}

	public void SetPlayerPhase(PlayerPhase phase)
	{
	}

	public void Attack(Player victim, int turns)
	{
	}

	public void StreakingTriggered(Card card1, Card card2)
	{
	}

	public void StartDrawingCard()
	{
	}

	public void EndDrawingCard()
	{
	}

	public void DisguiseHand()
	{
	}

	public void ShedDisguisedHand()
	{
	}

	public bool CanPlayCard(Card card)
	{
		return false;
	}

	public void StartPartying()
	{
	}

	public void StopPartying()
	{
	}

	public bool IsCardInHand(Card card)
	{
		return false;
	}

	public Card GetCard(CardCategory cardCategory)
	{
		return null;
	}

	public List<Card> GetCards(CardCategory cardCategory)
	{
		return null;
	}

	public void Disconnect()
	{
	}

	public void Emote(string emoteId)
	{
	}

	public void Mute()
	{
	}

	public void Unmute()
	{
	}

	public void Die()
	{
	}

	public void Win()
	{
	}

	public void ChooseOpponent(Card card)
	{
	}

	public void CancelChoosingOpponent()
	{
	}

	public void EndChoosingOpponent(Card card)
	{
	}

	public void CancelSteal()
	{
	}

	public void DrawExplodingKitten(Card card)
	{
	}

	public void PlayedBuryCard(Card card)
	{
	}

	public void ExtraBombAdded(Card card)
	{
	}

	public bool DrawCard(Card card)
	{
		return false;
	}

	public bool CheckStreaking()
	{
		return false;
	}

	public void ReceiveCardFromPlayer(Player otherPlayer, Card card)
	{
	}

	public void ReceiveBarkingCardFromPlayer(Player otherPlayer, Card card)
	{
	}

	public void ReceiveNag(Player otherPlayer)
	{
	}

	public void RemoveCard(Card card)
	{
	}

	public void PlayCard(Card card)
	{
	}

	public void DiscardCard(Card card)
	{
	}

	public void StartTurn(int numTurnsRemaining)
	{
	}

	public void PotLuckCompleted(List<Player> players)
	{
	}

	public void DisplayStartTurn(int numTurnsRemaining)
	{
	}

	public void EndTurn()
	{
	}

	public void BarkingKittenRequestFromPlayer(Player attacker, Action<Card> cardCallback)
	{
	}

	public void RequestGarbageCollectionCardFromPlayer(Player attacker, Action<Card> cardCallback)
	{
	}

	public void RequestPotLuckCardFromPlayer(Player attacker, Action<Card> cardCallback)
	{
	}

	public void RequestCardFromPlayer(Player attacker, Action<Card> cardCallback)
	{
	}

	public void StartChoosingCardToGiveUp()
	{
	}

	public void EndChoosingCardToGiveUp()
	{
	}

	public void EndChoosingGarbageCollectionCardToGiveUp()
	{
	}

	public void EndChoosingGarbageCollectionPhase()
	{
	}

	public void StartSeeingTheFuture(List<Card> cards)
	{
	}

	public void StartSeeSharingTheFuture(List<Card> cards)
	{
	}

	public void EndSeeingTheFuture()
	{
	}

	public void StartAlteringTheFuture(List<Card> cards)
	{
	}

	public void StartSharingTheFuture(List<Card> cards)
	{
	}

	public void EndAlteringTheFuture()
	{
	}

	public void PlayerDefuse()
	{
	}

	public Card GetExpodingBombInHand()
	{
		return null;
	}

	public Card GetNonExpodingBombInHand()
	{
		return null;
	}

	public void WhenLocalPlayer(Action callback)
	{
	}

	private void Callback(PlayerAttackDelegate playerAttackDelegate, Player victim, int turns)
	{
	}

	private void Callback(PlayerDelegate playerDelegate)
	{
	}

	private void Callback(PlayerListDelegate playerListDelegate, List<Player> players)
	{
	}

	private void Callback(PlayerPlayerCardCallbackDelegate callbackDelegate, Player attacker, Action<Card> callback)
	{
	}

	private void Callback(PlayerCardDelegate playerDelegate, Card card)
	{
	}

	private void Callback(PlayerEmoteDelegate playerDelegate, Emote emote)
	{
	}

	private void Callback(PlayerCardsDelegate playerDelegate, List<Card> cards)
	{
	}

	private void Callback(PlayerIntDelegate intDelegate, int integer)
	{
	}
}
