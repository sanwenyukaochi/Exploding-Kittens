package com.kittens.exploding.common.base_domain;

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