package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@Deprecated(forRemoval = true)
@RequiredArgsConstructor
public enum OnSerializeRigidBody {
    ONLY_VELOCITY("OnlyVelocity"),
    ONLY_ANGULAR_VELOCITY("OnlyAngularVelocity"),
    ALL("All");

    private final String value;
}