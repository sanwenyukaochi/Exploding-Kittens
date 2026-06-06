package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum LobbyType {
    DEFAULT("Default"),
    SQL_LOBBY("SqlLobby"),
    ASYNC_RANDOM_LOBBY("AsyncRandomLobby");

    private final String value;
}