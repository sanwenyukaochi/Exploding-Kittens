package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum CountdownState {
    STOPPED("Stopped"),
    RUNNING("Running"),
    PAUSED("Paused");

    private final String value;
}