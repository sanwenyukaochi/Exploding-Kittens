using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameMessages : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAIPlayEmoteDelay_003Ed__129 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public GameMessages _003C_003E4__this;

		public Player player;

		public string emote;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAIPlayEmoteDelay_003Ed__129(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CSendPlayCardDelayedCO_003Ed__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public CardCommand cardCommand;

		public GameMessages _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CSendPlayCardDelayedCO_003Ed__104(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public TurnQueue TurnQueue;

	public StartTurnController StartTurnController;

	public EndTurnController EndTurnController;

	public CardRepository CardRepository;

	public PlayerRepository PlayerRepository;

	public SkipDrawController SkipDrawController;

	public SlapController SlapController;

	public DefuseController DefuseController;

	public SeeTheFutureController SeeTheFutureController;

	public AlterTheFutureController AlterTheFutureController;

	public DrawCardController DrawCardController;

	public ShuffleController ShuffleController;

	public FakeShuffleController FakeShuffleController;

	public KittenRollCallController KittenRollCallController;

	public StealController StealController;

	public ReverseController ReverseController;

	public DiarrheaController DiarrheaController;

	public CatButtController CatButtController;

	public BombPlayedController BombPlayedController;

	public StreakingKittenController StreakingKittenController;

	public SwapTopBottomController SwapTopBottomController;

	public MarkController MarkController;

	public GarbageCollectionController GarbageCollectionController;

	public CatomicBombController CatomicBombController;

	public BarkingKittenController BarkingController;

	public TakeThatController TakeThatController;

	public BuryController BuryController;

	public PotLuckController PotLuckController;

	public TowerOfPowerController TowerOfPowerController;

	public ShareTheFutureController ShareTheFutureController;

	public MoveCardsToTopController MoveCardsToTopController;

	public PlayerReadinessMonitor PlayerReadinessMonitor;

	public GameDeck GameDeck;

	public ActivityMessages ActivityMessages;

	private Dictionary<CardCategory, Action<Player, Card>> PostPlayCardActions;

	private Dictionary<CardCategory, Action<Player, Player, Card>> ChooseOpponentHandlers;

	public int m_SyncInt;

	private Card LastCardPlayed;

	private NetworkMessageRouter router => null;

	private IMessageClient MessageClient => null;

	public void Initialize()
	{
	}

	private void OnDestroy()
	{
	}

	private void Send(string messageType, Player player, List<Card> cards)
	{
	}

	private void Send(string messageType, Deck deck, string sound)
	{
	}

	private void Send(string messageType, Player playerA, Player playerB)
	{
	}

	private void Send(string messageType, Player playerA, Card card)
	{
	}

	private void Send(string messageType, Player playerA, Player playerB, Card card)
	{
	}

	private void Send(string messageType, Player playerA, Card card, string stringA)
	{
	}

	private void Send(string messageType, Player playerA)
	{
	}

	private void Send(string messageType, Player playerA, string stringA)
	{
	}

	public void Deserialize(NetworkMessage message, Action<Deck> next)
	{
	}

	public void Deserialize(NetworkMessage message, Action<Player, List<Card>> next)
	{
	}

	public void Deserialize(NetworkMessage message, Action<Player, Player> next)
	{
	}

	public void Deserialize(NetworkMessage message, Action<Player, Player, int> next)
	{
	}

	public void Deserialize(NetworkMessage message, Action<Player, Player, Card> next)
	{
	}

	public void Deserialize(NetworkMessage message, Action<Player, Card> next)
	{
	}

	public void Deserialize(NetworkMessage message, Action<Player, string> next)
	{
	}

	public void Deserialize(NetworkMessage message, Action<Player> next)
	{
	}

	public void Deserialize(NetworkMessage message, Action<Card> next)
	{
	}

	public void Deserialize(NetworkMessage message, Action<Card, int> next)
	{
	}

	public void Deserialize(NetworkMessage message, Action<Player, Card, int> next)
	{
	}

	private string serializeStringList(List<string> strings)
	{
		return null;
	}

	private List<string> deserializeStringToList(string strings)
	{
		return null;
	}

	public int GetSyncInteger()
	{
		return 0;
	}

	public void SendSyncInt(Player sender, int syncint)
	{
	}

	private void SyncInt(NetworkMessage message)
	{
	}

	public void SendEmote(Player sender, string emoteId)
	{
	}

	private void Emote(NetworkMessage message)
	{
	}

	public void SendPlayerDied(Player player)
	{
	}

	public void PlayerDied(NetworkMessage message)
	{
	}

	public void SendPlayerReady(Player player)
	{
	}

	public void PlayerReady(NetworkMessage message)
	{
	}

	public void SendDrawCard(Player player, Card card)
	{
	}

	public void DrawCard(NetworkMessage message)
	{
	}

	private bool ValidDrawCard()
	{
		return false;
	}

	private bool ValidPlayCard()
	{
		return false;
	}

	public void DrawCard(Player player)
	{
	}

	public void SendEndTurn()
	{
	}

	public void EndTurn(Player player)
	{
	}

	public void SendSetDeck(Deck deck, string sound = "")
	{
	}

	public void SetDeck(NetworkMessage message)
	{
	}

	public void SetDeck(Deck deck)
	{
	}

	public void SendMoveCardsToTop(Player player, List<Card> cards)
	{
	}

	public void MoveCardsToTop(NetworkMessage message)
	{
	}

	public void MoveCardsToTop(Player player, List<Card> cards)
	{
	}

	public void SendInsertCardInDeck(Player player, Card bomb, int index)
	{
	}

	public void SendBuryCardInDeck(Player player, Card bomb, int index)
	{
	}

	public void BuryCard(NetworkMessage message)
	{
	}

	public void InsertCardInDeck(NetworkMessage message)
	{
	}

	private void BombPlaced(Player player, bool placed = true)
	{
	}

	public void DiarrheadCard(Card card)
	{
	}

	public void UndiarrheaCard(Card card)
	{
	}

	public void OpponentChosen(NetworkMessage message)
	{
	}

	public void SendOpponentChosen(Player player, Player targetedPlayer, Card card)
	{
	}

	public void SendGarbageCollectionChosen(Player player, Player targetedPlayer, Card card)
	{
	}

	public void SendPotLuckChosen(Player player, Player targetedPlayer, Card card)
	{
	}

	public void GarbageCollectionChosen(NetworkMessage message)
	{
	}

	public void PotLuckChosen(NetworkMessage message)
	{
	}

	public void SendGiveSteal(Player player, Player targetedPlayer, Card card)
	{
	}

	public void SendGiveBarkingSteal(Player player, Player targetedPlayer, Card card)
	{
	}

	public void GiveBarking(NetworkMessage message)
	{
	}

	public void GiveSteal(NetworkMessage message)
	{
	}

	public void GiveSteal(Player player, Player targetedPlayer, Card card)
	{
	}

	public void SendPlayCard(CardCommand cardCommand)
	{
	}

	public void SendPlayCardDelayed(CardCommand cardCommand, float delay)
	{
	}

	[IteratorStateMachine(typeof(_003CSendPlayCardDelayedCO_003Ed__104))]
	public IEnumerator SendPlayCardDelayedCO(CardCommand cardCommand, float delay)
	{
		return null;
	}

	public void SendPlayCard(Player player, Card card)
	{
	}

	public void PlayCard(NetworkMessage message)
	{
	}

	public void PlayCard(Player player, Card card)
	{
	}

	public void SendStartTurn()
	{
	}

	public void StartTurn(NetworkMessage message)
	{
	}

	public void StartTurn()
	{
	}

	public void SendRemoveCard(Player player, Card card)
	{
	}

	public void RemoveCard(NetworkMessage message)
	{
	}

	public void DealCard(Player player, Card card)
	{
	}

	public void SendNagPlayer(Player player, Player otherPlayer)
	{
	}

	public void ReceiveNagPlayer(NetworkMessage message)
	{
	}

	public void SendRematchGame(Player player, string newRoomCode)
	{
	}

	public void ReceiveRematchGame(NetworkMessage message)
	{
	}

	public void SendRematchResponse(Player player, bool acceptRematch)
	{
	}

	public void ReceiveRematchGameAccepted(NetworkMessage message)
	{
	}

	public void ReceiveRematchGameDeclined(NetworkMessage message)
	{
	}

	private void GuardIsCurrentPlayer(string playerId, Action<Player> OnSuccess)
	{
	}

	private void GuardIsLocalPlayer(string playerId, Action<Player> OnSuccess)
	{
	}

	private void GuardIsLobbyHost(Action OnSuccess)
	{
	}

	public void SendEmoteDelayed(Player player, string emote, float delay)
	{
	}

	public void WriteLocalActivityMessage(ActivityType type, Player sourceplayer, Player targetplayer)
	{
	}

	[IteratorStateMachine(typeof(_003CAIPlayEmoteDelay_003Ed__129))]
	private IEnumerator AIPlayEmoteDelay(Player player, string emote, float delay)
	{
		return null;
	}

	private void Update()
	{
	}

	private void DisplayNetworkError(string error)
	{
	}
}
