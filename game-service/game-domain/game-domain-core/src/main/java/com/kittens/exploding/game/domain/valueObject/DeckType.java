package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum DeckType {
    CORE("Core"),
    PARTY("Party"),
    BETRAYAL("Betrayal"),
    STREAKING("Streaking"),
    BARKING_KITTENS("BarkingKittens"),
    MIXED("Mixed");

    private final String value;
}