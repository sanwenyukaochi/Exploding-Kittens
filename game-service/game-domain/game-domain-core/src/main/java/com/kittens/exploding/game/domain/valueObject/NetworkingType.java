package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum NetworkingType {
    @Deprecated(forRemoval = true)
    LOCAL("Local"),
    @Deprecated(forRemoval = true)
    MULTIPEER("Multipeer"),
    PHOTON("Photon");

    private final String value;
}