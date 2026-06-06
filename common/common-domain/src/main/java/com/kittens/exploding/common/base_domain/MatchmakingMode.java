package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum MatchmakingMode {
    FILL_ROOM("FillRoom"),
    SERIAL_MATCHING("SerialMatching"),
    RANDOM_MATCHING("RandomMatching");

    private final String value;
}