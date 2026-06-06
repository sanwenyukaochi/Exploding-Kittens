package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum DrawType {
    UNDRAWN("Undrawn"),
    DRAWN("Drawn"),
    STEAL("Steal"),
    INITIAL_HAND("InitialHand");

    private final String value;
}