package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum CountdownState {
    STOPPED("Stopped"),
    RUNNING("Running"),
    PAUSED("Paused");

    private final String value;
}