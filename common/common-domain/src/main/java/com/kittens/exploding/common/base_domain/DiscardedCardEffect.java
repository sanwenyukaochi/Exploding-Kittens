package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum DiscardedCardEffect {
    NONE("None"),
    TOOLTIP("Tooltip"),
    BLIND("Blind");

    private final String value;
}