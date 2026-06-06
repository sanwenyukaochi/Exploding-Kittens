package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum PropertyTypeFlag {
    NONE("None"),
    GAME("Game"),
    ACTOR("Actor"),
    GAME_AND_ACTOR("GameAndActor");

    private final String value;
}