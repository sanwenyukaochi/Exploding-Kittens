package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@Deprecated(forRemoval = true)
@RequiredArgsConstructor
public enum PhotonLogLevel {
    ERRORS_ONLY("ErrorsOnly"),
    INFORMATIONAL("Informational"),
    FULL("Full");

    private final String value;
}