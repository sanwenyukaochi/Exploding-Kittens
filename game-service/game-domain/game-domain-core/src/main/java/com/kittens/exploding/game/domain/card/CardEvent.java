package com.kittens.exploding.game.domain.card;

@FunctionalInterface
public interface CardEvent {
    void invoke(Card card);
}