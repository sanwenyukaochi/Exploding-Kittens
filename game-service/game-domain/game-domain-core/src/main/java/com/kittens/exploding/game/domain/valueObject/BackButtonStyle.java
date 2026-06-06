package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum BackButtonStyle {
    BACK("Back"),
    CANCEL("Cancel");

    private final String value;
}