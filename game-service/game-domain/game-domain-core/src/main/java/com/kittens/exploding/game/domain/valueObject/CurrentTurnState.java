package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum CurrentTurnState {
    IDLE("Idle"),
    DRAWING_CARD("DrawingCard");

    private final String value;
}