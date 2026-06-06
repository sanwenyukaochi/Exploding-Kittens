package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum ServerConnection {
    MASTER_SERVER("MasterServer"),
    GAME_SERVER("GameServer"),
    NAME_SERVER("NameServer");

    private final String value;
}