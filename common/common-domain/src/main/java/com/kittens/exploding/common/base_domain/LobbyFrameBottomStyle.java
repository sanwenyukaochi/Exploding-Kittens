package com.kittens.exploding.common.base_domain;

import lombok.RequiredArgsConstructor;

@Deprecated(forRemoval = true)
@RequiredArgsConstructor
public enum LobbyFrameBottomStyle {
    GRADIENT("Gradient"),
    PLAIN("Plain");

    private final String value;
}