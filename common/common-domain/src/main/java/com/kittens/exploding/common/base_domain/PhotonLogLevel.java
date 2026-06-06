package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@Deprecated(forRemoval = true)
@RequiredArgsConstructor
public enum PhotonLogLevel {
    ERRORS_ONLY("ErrorsOnly"),
    INFORMATIONAL("Informational"),
    FULL("Full");

    private final String value;
}