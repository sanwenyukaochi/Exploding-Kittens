package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum ConnectionState {
    DISCONNECTED("Disconnected"),
    CONNECTING("Connecting"),
    CONNECTED("Connected"),
    DISCONNECTING("Disconnecting"),
    INITIALIZING_APPLICATION("InitializingApplication");

    private final String value;
}