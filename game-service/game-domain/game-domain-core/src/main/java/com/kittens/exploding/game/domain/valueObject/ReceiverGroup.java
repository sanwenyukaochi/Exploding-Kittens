package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@Deprecated(forRemoval = true)
@RequiredArgsConstructor
public enum ReceiverGroup {
    OTHERS("Others"),
    ALL("All"),
    MASTER_CLIENT("MasterClient");

    private final String value;
}