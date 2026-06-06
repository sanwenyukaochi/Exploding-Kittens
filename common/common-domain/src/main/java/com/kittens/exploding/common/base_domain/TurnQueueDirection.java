package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum TurnQueueDirection {
    FORWARD("Forward"),
    BACKWARD("Backward");

    private final String value;
}