package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum CurrentTurnState {
    IDLE("Idle"),
    DRAWING_CARD("DrawingCard");

    private final String value;
}