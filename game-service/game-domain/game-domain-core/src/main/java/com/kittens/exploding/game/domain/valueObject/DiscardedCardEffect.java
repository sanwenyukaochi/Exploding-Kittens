package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum DiscardedCardEffect {
    NONE("None"),
    TOOLTIP("Tooltip"),
    BLIND("Blind");

    private final String value;
}