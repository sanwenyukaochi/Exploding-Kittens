package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum ClientPhase {
    LOBBY("Lobby"),
    GAME("Game");

    private final String value;
}