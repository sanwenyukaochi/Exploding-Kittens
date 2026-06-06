package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum DrawType {
    UNDRAWN("Undrawn"),
    DRAWN("Drawn"),
    STEAL("Steal"),
    INITIAL_HAND("InitialHand");

    private final String value;
}