package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum ClientPhase {
    LOBBY("Lobby"),
    GAME("Game");

    private final String value;
}