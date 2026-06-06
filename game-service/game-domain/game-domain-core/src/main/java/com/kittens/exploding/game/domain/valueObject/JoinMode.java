package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum JoinMode {
    DEFAULT("Default"),
    CREATE_IF_NOT_EXISTS("CreateIfNotExists"),
    JOIN_OR_REJOIN("JoinOrRejoin"),
    REJOIN_ONLY("RejoinOnly");

    private final String value;
}