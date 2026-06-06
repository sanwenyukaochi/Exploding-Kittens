package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@Deprecated(forRemoval = true)
@RequiredArgsConstructor
public enum OnSerializeTransform {
    ONLY_POSITION("OnlyPosition"),
    ONLY_ROTATION("OnlyRotation"),
    ONLY_SCALE("OnlyScale"),
    POSITION_AND_ROTATION("PositionAndRotation"),
    ALL("All");

    private final String value;
}