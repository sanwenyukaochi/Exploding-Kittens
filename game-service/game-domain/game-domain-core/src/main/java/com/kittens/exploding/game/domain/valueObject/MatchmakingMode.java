package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum MatchmakingMode {
    FILL_ROOM("FillRoom"),
    SERIAL_MATCHING("SerialMatching"),
    RANDOM_MATCHING("RandomMatching");

    private final String value;
}