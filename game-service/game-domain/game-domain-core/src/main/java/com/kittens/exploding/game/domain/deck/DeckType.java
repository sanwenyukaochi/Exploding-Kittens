package com.kittens.exploding.game.domain.deck;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum DeckType {
    CORE("核心包"),
    PARTY("派对包"),
    BETRAYAL("背叛包"),
    STREAKING("裸奔包"),
    BARKING_KITTENS("吠叫猫包"),
    MIXED("混合包");

    private final String description;
}