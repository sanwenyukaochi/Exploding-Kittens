package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@Deprecated(forRemoval=true)
@RequiredArgsConstructor
public enum ViewSynchronization {
    OFF("Off"),
    RELIABLE_DELTA_COMPRESSED("ReliableDeltaCompressed"),
    UNRELIABLE("Unreliable"),
    UNRELIABLE_ON_CHANGE("UnreliableOnChange");

    private final String value;
}