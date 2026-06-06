package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@Deprecated(forRemoval = true)
@RequiredArgsConstructor
public enum OnSerializeRigidBody {
    ONLY_VELOCITY("OnlyVelocity"),
    ONLY_ANGULAR_VELOCITY("OnlyAngularVelocity"),
    ALL("All");

    private final String value;
}