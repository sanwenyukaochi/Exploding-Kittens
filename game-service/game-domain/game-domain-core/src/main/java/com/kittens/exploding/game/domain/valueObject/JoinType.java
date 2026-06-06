package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum JoinType {
    CREATE_ROOM("CreateRoom"),
    JOIN_ROOM("JoinRoom"),
    JOIN_RANDOM_ROOM("JoinRandomRoom"),
    JOIN_OR_CREATE_ROOM("JoinOrCreateRoom");

    private final String value;
}