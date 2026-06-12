package io.kittens.exploding.deck.domain.entity;

import io.kittens.exploding.card.domain.entity.Card;
import io.kittens.exploding.card.domain.valueObject.CardCategory;
import io.kittens.exploding.common.domain.entity.AggregateRoot;
import io.kittens.exploding.deck.domain.valueObject.DeckId;
import java.util.List;
import java.util.function.Function;

public class Deck extends AggregateRoot<DeckId> {
    public List<Card> Cards;

    public Deck() {}

    public Deck(List<Card> cards) {}

    public int IndexOfCard(Card card) {
        return 0;
    }

    public List<Card> Top(int n) {
        return null;
    }

    public void ClearPlacingPlayers() {}

    public void Truncate(int count) {}

    public void RemoveTopCard(CardCategory category) {}

    public Card Draw() {
        return null;
    }

    public Card DrawFromBottom() {
        return null;
    }

    public void NotifyChange() {}

    public List<Card> FindAllCardsInCategory(CardCategory category) {
        return null;
    }

    public int NumberOfCardsInCategory(CardCategory category) {
        return 0;
    }

    public void Shuffle() {}

    public void orderByDescending(Function<Card, ? extends Comparable<?>> keyExtractor) {}

    public void Add(Deck other) {}

    public void Add(Card card) {}

    public void Insert(int index, Card card) {}

    public void Replace(Deck deck) {}

    public void MoveCardsToTop(List<Card> topCards) {}

    public void Remove(Card card) {}

    public void Swap(int index1, int index2) {}
}
