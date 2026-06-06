package com.kittens.exploding.common.base_domain;

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