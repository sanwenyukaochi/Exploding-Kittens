package com.kittens.exploding.game.domain.valueObject;

import lombok.RequiredArgsConstructor;

@Deprecated(forRemoval = true)
@RequiredArgsConstructor
public enum LobbyFrameBottomStyle {
    GRADIENT("Gradient"),
    PLAIN("Plain");

    private final String value;
}