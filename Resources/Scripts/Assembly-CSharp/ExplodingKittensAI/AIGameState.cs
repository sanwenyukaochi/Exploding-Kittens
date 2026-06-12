using System;
using System.Collections.Generic;

namespace ExplodingKittensAI
{
	public class AIGameState
	{
		private static readonly IList<string> TypesThatDeferDrawingTopCard;

		public readonly IList<CardAction> _aIHand;

		private readonly List<CardAction> _allCards;

		private readonly double _aIRiskThreshold;

		private readonly Random _rand;

		private IList<CardAction> _playedCards;

		private int _playerKnownCards;

		private int _aIKnownCards;

		private bool _playerPlacedKitten;

		public int _knownKittenPosition;

		public int _knownKittenPosition2;

		private int _knownNumberOfPlayerCards;

		private double _chanceOfDrawingExplodingKitten;

		public string GameId;

		public DifficultyLevel DifficultyLevel;

		private bool m_ClearDiarrhea;

		public bool m_CatButted;

		private int m_SelfSlapTurns;

		private int m_AlteredWithBomb;

		private bool PlayerHasBombInHand;

		public bool PlayAllCardsForDefuse;

		private bool PlayerHasBarkingKitten;

		public bool PlayerKnowsAIHasBarking;

		private List<CardAction> diarrheaCards;

		private bool NextCardIsRandom;

		private bool JustShuffled;

		private bool PlayerJustDefused;

		private bool PlayedSteal;

		public bool StoleDefuseWhileBlind;

		private bool BarkingPlayed;

		private bool ITTPlayed;

		private bool PotLuckPlayed;

		private bool PlayerDrewFromBottom;

		public IList<CardAction> Deck { get; private set; }

		public AIGameState(IList<CardAction> deck, IList<CardAction> playerHand, IList<CardAction> aIHand, DifficultyLevel difficultyLevel)
		{
		}

		public List<CardAction> PlayDefuse(bool barking = false)
		{
			return null;
		}

		public IList<CardAction> ChooseCardToGive(bool shuffle)
		{
			return null;
		}

		public void ProcessActions()
		{
		}

		public IList<CardAction> RespondToActions(IList<CardAction> playerActions, int turnCount)
		{
			return null;
		}

		private bool HasDefuseOrStreakingFree()
		{
			return false;
		}

		private bool HasStreakingFree()
		{
			return false;
		}

		private void UpdateKittenExplosionChance(CardAction lastAction = null)
		{
		}

		private int GetKittenPosition()
		{
			return 0;
		}

		private void ChooseToPlayCards(IList<CardAction> returnCardActions, int turns, CardAction lastAction, CardAction earlyPlayedCard = null)
		{
		}

		private void PlayAction(CardAction card, IList<CardAction> returnCardActions)
		{
		}

		private List<CardAction> PlayDefuse(CardAction kittenCard, int turns, int cardAdvantage)
		{
			return null;
		}

		private CardAction DrawCard(bool lastCard, bool AI = true)
		{
			return null;
		}

		private void ResolvePlayerNonInteractiveActions(CardAction action)
		{
		}

		private void ResolveNonInteractiveAction(CardAction action)
		{
		}

		private double CardValue(string cardType)
		{
			return 0.0;
		}

		private void SetKittenKnownPosition(int index, int position)
		{
		}

		private double AlterCardValue(string cardType)
		{
			return 0.0;
		}
	}
}
