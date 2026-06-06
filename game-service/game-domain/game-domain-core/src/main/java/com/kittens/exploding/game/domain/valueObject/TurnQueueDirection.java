package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum TurnQueueDirection {
    FORWARD("Forward"),
    BACKWARD("Backward");

    private final String value;
}