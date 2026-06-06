package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum PropertyTypeFlag {
    NONE("None"),
    GAME("Game"),
    ACTOR("Actor"),
    GAME_AND_ACTOR("GameAndActor");

    private final String value;
}