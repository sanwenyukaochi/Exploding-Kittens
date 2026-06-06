package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@RequiredArgsConstructor
public enum EnterCodeFrameBottomStyle {
    GRADIENT("Gradient"),
    PLAIN("Plain");

    private final String value;
}